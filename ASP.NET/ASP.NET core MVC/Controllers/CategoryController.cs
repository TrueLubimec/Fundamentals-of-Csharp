using ASP.NET_core_MVC.Data;
using ASP.NET_core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_core_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            
            return View();
        }
    }
}
