using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVCwithSSMS.MVC.Models;
using WebMVCwithSSMS.MVC.Models.Data;

namespace WebMVCwithSSMS.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tasks = _context.ToDos.ToList();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(String TaskName)
        {
            var task = new ToDo { Task = TaskName, IsCompleted = false };
            _context.ToDos.Add(task);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
