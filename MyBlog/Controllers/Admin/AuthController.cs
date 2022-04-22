//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using MyBlog.Models;

//namespace MyBlog.Controllers.Admin
//{
//    [Route("admin/[controller]")]
//    public class AuthController : Controller
//    {
//        private readonly ApplicationContext context;

//        public AuthController(ApplicationContext context)
//        {
//            this.context = context;
//        }
        

//        [HttpGet]
//        [Route("[action]")]
//        public IActionResult Register()
//        {
//            return View("Views/Admin/Auth/Register.cshtml");
//        }

//        [HttpPost]
//        [Route("[action]")]
//        [ValidateAntiForgeryToken]
//        public IActionResult Register(RegisterModel registerModel)
//        {
//            if(ModelState.IsValid)
//            {
//                var user = new User
//                {
//                    Login = registerModel.Login,
//                    Email = registerModel.Email,
//                    Password = registerModel.Password,
//                };

//                context.Users.Add(user);
//                context.SaveChanges();
//                return RedirectToAction("Index", "User");
//            }

//            return RedirectToAction();
//        }

//        [HttpGet]
//        [Route("[action]")]
//        public IActionResult Login()
//        {
//            return View("Views/Admin/Auth/Login.cshtml");
//        }

//        [HttpPost]
//        [Route("[action]")]
//        public IActionResult Login(LoginModel loginModel)
//        {
//            var user = context.Users.FirstOrDefaultAsync(u => u.Login == loginModel.Login && u.Password == loginModel.Password);
//            if(user == null)
//            {
//                return NotFound();
//            }
//            return RedirectToAction("Index", "User");
//        }

//    }
//}
