using System.ComponentModel.DataAnnotations;

namespace MyBlog.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
