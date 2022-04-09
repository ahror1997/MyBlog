using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System.Linq;

namespace MyBlog.Controllers.Admin
{
    [Route("admin/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationContext context;

        public CategoryController(ApplicationContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View("Views/Admin/Category/Index.cshtml", categories);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            return View("Views/Admin/Category/Create.cshtml");
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id)
        {
            var category = context.Categories.Find(Id);
            return View("Views/Admin/Category/Edit.cshtml", category);
        }

        [HttpPost]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id, Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}