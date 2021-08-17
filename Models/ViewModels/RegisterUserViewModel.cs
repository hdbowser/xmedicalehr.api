namespace xmedicalehr.api.Models.ViewModels
{
    public class RegisterUserViewModel
    {
        public string Prefix { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}