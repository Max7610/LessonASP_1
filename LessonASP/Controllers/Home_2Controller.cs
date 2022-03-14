using Microsoft.AspNetCore.Mvc;

namespace LessonASP.Controllers
{
    public class Home_2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
