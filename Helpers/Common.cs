using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.RegularExpressions;

namespace AvicennaDispensing.Helpers
{
    public static class Common
    {
        public static async Task<string> RenderPartialViewToStringAsync(this Controller controller, string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = controller.ControllerContext.ActionDescriptor.ActionName;

            controller.ViewData.Model = model;

            using (var writer = new StringWriter())
            {
                var serviceProvider = controller.HttpContext.RequestServices;
                var viewEngine = serviceProvider.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine
                                 ?? throw new InvalidOperationException("Unable to resolve ICompositeViewEngine.");

                var viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);
                if (!viewResult.Success || viewResult.View == null)
                    throw new FileNotFoundException($"View '{viewName}' not found.");

                var viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    writer,
                    new HtmlHelperOptions()
                );

                await viewResult.View.RenderAsync(viewContext);
                return writer.GetStringBuilder().ToString();
            }
        }

        public static IHtmlContent HighlightSearch(this IHtmlHelper html, string? text, string? keyword = null)
        {
            keyword ??= html.ViewContext.ViewBag.Search as string;

            if (string.IsNullOrEmpty(text))
                return HtmlString.Empty;

            if (string.IsNullOrWhiteSpace(keyword))
                return new HtmlString(text);

            return new HtmlString(Regex.Replace(
                text,
                Regex.Escape(keyword),
                m => $"<mark>{m.Value}</mark>",
                RegexOptions.IgnoreCase
            ));
        }
    }
}
