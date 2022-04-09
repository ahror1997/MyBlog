using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System.Linq;

namespace MyBlog.Controllers.Admin
{
    [Route("admin/[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationContext context;

        public UserController(ApplicationContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Index()
        {
            var users = context.Users.ToList();
            return View("Views/Admin/User/Index.cshtml", users);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            return View("Views/Admin/User/Create.cshtml");
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id)
        {
            var user = context.Users.Find(Id);
            return View("Views/Admin/User/Edit.cshtml", user);
        }

        [HttpPost]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id, User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
