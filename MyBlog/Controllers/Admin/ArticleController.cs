using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System.Linq;

namespace MyBlog.Controllers.Admin
{
    [Route("admin/[controller]")]
    public class ArticleController : Controller
    {
        private readonly ApplicationContext context;

        public ArticleController(ApplicationContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Index()
        {
            var articles = context.Articles.ToList();
            return View("Views/Admin/Article/Index.cshtml", articles);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View("Views/Admin/Article/Create.cshtml");
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id)
        {
            ViewBag.Categories = context.Categories.ToList();
            var article = context.Articles.Find(Id);
            return View("Views/Admin/Article/Edit.cshtml", article);
        }

        [HttpPost]
        [Route("[action]/{Id}")]
        public IActionResult Edit(int Id, Article article)
        {
            context.Articles.Update(article);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
