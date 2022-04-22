using Microsoft.AspNetCore.Identity;

namespace MyBlog.Models
{
    public class MyUser : IdentityUser
    {
        public string Country { get; set; }
    }
}
