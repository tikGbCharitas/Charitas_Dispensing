using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Globalization;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Host.UseSerilog();

var activeKey = builder.Configuration.GetConnectionString("Active");
if (string.IsNullOrWhiteSpace(activeKey))
{
    Log.Error("Active connection string key is missing in appsettings.json!");
    throw new InvalidOperationException($"Connection string for key '{activeKey}' is missing in appsettings.json!");
}

// Add services to the container.
builder.Services.AddHttpContextAccessor();

// Add Localization Services
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddControllersWithViews()
    .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

// Configure Request Localization Options
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("id")
    };

    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    
    // Custom culture provider to read from cookie first, then user claims
    options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(context =>
    {
        // First priority: Check cookie for latest language (set by Settings controller)
        if (context.Request.Cookies.TryGetValue("UserLanguage", out var cookieLanguage))
        {
            if (!string.IsNullOrEmpty(cookieLanguage) && (cookieLanguage == "en" || cookieLanguage == "id"))
            {
                return Task.FromResult<ProviderCultureResult?>(new ProviderCultureResult(cookieLanguage));
            }
        }
        
        // Fall back to default culture
        return Task.FromResult<ProviderCultureResult?>(null);
    }));
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString(activeKey),
            sqlOptions => sqlOptions.EnableRetryOnFailure());
        //options.EnableSensitiveDataLogging(); //Comment this for Production
        options.LogTo(log => Debug.WriteLine(log), LogLevel.Information);
    });

builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", config =>
    {
        config.Cookie.Name = "Avicenna.Cookie";
        config.Cookie.HttpOnly = true; // Prevent JavaScript access to the cookie
        config.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Always use secure cookies (HTTPS)

        config.Cookie.SameSite = SameSiteMode.Lax; // Set SameSite policy to Lax
        config.LoginPath = "/Login/Index"; // Redirect to login page if not authenticated
        config.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Set cookie expiration time (Minute)
        config.SlidingExpiration = true; // Renew cookie on each request
        config.Cookie.IsEssential = true;

        // Support for persistent cookies (Remember Me)
        // When IsPersistent is true in AuthenticationProperties, cookie will persist beyond browser session
        config.Events = new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents
        {
            OnSigningIn = context =>
            {
                Log.Information($"OnSigningIn - IsPersistent: {context.Properties.IsPersistent}, ExpiresUtc: {context.Properties.ExpiresUtc}");

                if (context.Properties.IsPersistent && context.Properties.ExpiresUtc.HasValue)
                {
                    var expiresUtc = context.Properties.ExpiresUtc.Value;
                    context.CookieOptions.Expires = expiresUtc;
                    context.CookieOptions.MaxAge = expiresUtc - DateTimeOffset.UtcNow;

                    Log.Information($"Setting PERSISTENT cookie - Expires: {expiresUtc}, MaxAge: {context.CookieOptions.MaxAge}");
                }
                else
                {
                    context.CookieOptions.Expires = null;
                    context.CookieOptions.MaxAge = null;

                    Log.Information("Setting SESSION cookie - Expires: null");
                }
                return Task.CompletedTask;
            },
            OnRedirectToLogin = context =>
            {
                Log.Information($"Redirecting to login - Original: {context.Request.Path}");
                context.Response.Redirect(context.RedirectUri);
                return Task.CompletedTask;
            }
        };
    });

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout (Minute)
    options.Cookie.HttpOnly = true; // Prevent JavaScript access to the session cookie
    options.Cookie.IsEssential = true; // Make the session cookie essential
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Always use secure cookies (HTTPS)
    
    options.Cookie.SameSite = SameSiteMode.Lax; // Set SameSite policy to Lax
});

// Configure AntiForgery for security (REQUIRED for production!)
builder.Services.AddAntiforgery(options =>
{
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // HTTPS only
    options.Cookie.SameSite = SameSiteMode.Lax;             // CSRF protection
    options.Cookie.HttpOnly = true;                          // XSS protection
});

builder.Services.Configure<ProgramSettings>(
    builder.Configuration.GetSection("ProgramSettings"));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//    //app.UsePathBase("/Dispensing"); // If Using virtual Directory
//}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRequestLocalization();
app.UseRouting();
app.UseDeveloperExceptionPage();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.AppUsers.FirstOrDefault();
    }
    catch (Exception ex)
    {
        Log.Error(ex, "An error occurred while connecting to the database.");
        throw; // Re-throw the exception after logging it
    }
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
