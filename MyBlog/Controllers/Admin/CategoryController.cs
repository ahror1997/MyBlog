using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private readonly ApplicationContext context;

        public CategoryController(ApplicationContext _context)
        {
            this.context = _context;
        }

        public IActionResult Index()
        {
            return View("Views/Admin/Category/Index.cshtml");
        }

        public IActionResult Create()
        {
            return View("Views/Admin/Category/Create.cshtml");
        }
    }
}
