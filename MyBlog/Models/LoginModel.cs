using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Incorrect login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Wrong password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
