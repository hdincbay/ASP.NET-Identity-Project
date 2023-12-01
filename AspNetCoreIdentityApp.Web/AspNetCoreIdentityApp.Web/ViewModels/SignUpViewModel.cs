using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
            
        }
        public SignUpViewModel(string userName, string email, string phone, string password, string passwordConfirm)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
            PasswordConfirm = passwordConfirm;
        }

        [Required(ErrorMessage = "Kullanıcı ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "E-mail formatı yanlıştır.")]
        [Required(ErrorMessage = "E-mail alanı boş bırakılamaz.")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Numarası alanı boş bırakılamaz.")]
        [Display(Name = "Telefon Numarası:")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre:")]
        public string Password { get; set; }

        
        [Required(ErrorMessage = "Şifre Tekrar alanı boş bırakılamaz.")]
        [Display(Name = "Şifre Tekrar:")]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        public string PasswordConfirm { get; set; }
    }
}
