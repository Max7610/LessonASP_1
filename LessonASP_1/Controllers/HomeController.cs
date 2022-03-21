using LessonASP_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LessonASP_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static readonly List<Student> __Students = new List<Student>() 
        {
            new Student{Id = 1,Name = "St1",Age = 15,Klass = 9,CharKlass = "А" },
            new Student{Id = 2,Name = "St2",Age = 16,Klass = 10,CharKlass = "Б" },
            new Student{Id = 3,Name = "St3",Age = 17,Klass = 11,CharKlass = "В" },
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult StudentPersonalAccount(int id)
        {
            return View(__Students[id-1]);
        }
        public IActionResult Student()
        {
            return View(__Students);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}