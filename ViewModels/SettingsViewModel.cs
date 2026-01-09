namespace AvicennaDispensing.ViewModels
{
    public class SettingsViewModel
    {
        public string UserID { get; set; } = null!;
        public string? UserName { get; set; }
        public string? Email { get; set; }
    }

    public class ChangePasswordRequest
    {
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
}
