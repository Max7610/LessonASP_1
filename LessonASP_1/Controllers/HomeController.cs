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
        private static readonly List<Product> __Book = new List<Product>()
        {
            new Product{Id = 1,Name ="Книга 1",TGenre=TypeGenre.epic,NameIMG = "1.jpg", Description="Описание",Prise=500},
            new Product{Id = 2,Name ="Книга 2",TGenre=TypeGenre.epic,NameIMG = "2.jpg", Description="Описание",Prise=200},
            new Product{Id = 3,Name ="Книга 3",TGenre=TypeGenre.epic,NameIMG = "3.jpg", Description="Описание",Prise=300},
            new Product{Id = 4,Name ="Книга 4",TGenre=TypeGenre.epic,NameIMG = "4.jpg", Description="Описание",Prise=400},
            new Product{Id = 5,Name ="Книга 5",TGenre=TypeGenre.epic,NameIMG = "5.jpg", Description="Описание",Prise=600},
            new Product{Id = 6,Name ="Книга 6",TGenre=TypeGenre.epic,NameIMG = "6.jpg", Description="Описание",Prise=530},
            new Product{Id = 7,Name ="Книга 7",TGenre=TypeGenre.epic,NameIMG = "7.jpg", Description="Описание",Prise=570},
            new Product{Id = 8,Name ="Книга 8",TGenre=TypeGenre.epic,NameIMG = "8.jpg", Description="Описание",Prise=580},
            new Product{Id = 9,Name ="Книга 9",TGenre=TypeGenre.epic,NameIMG = "9.jpg", Description="Описание",Prise=510},
            new Product{Id = 10,Name ="Книга 10",TGenre=TypeGenre.epic,NameIMG = "10.jpg", Description="Описание",Prise=340},
            new Product{Id = 11,Name ="Книга 11",TGenre=TypeGenre.epic,NameIMG = "11.jpg", Description="Описание",Prise=460},
            new Product{Id = 12,Name ="Книга 12",TGenre=TypeGenre.epic,NameIMG = "12.jpg", Description="Описание",Prise=260},
            new Product{Id = 13,Name ="Книга 13",TGenre=TypeGenre.epic,NameIMG = "13.jpg", Description="Описание",Prise=690},
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
            return View(__Book[0]);
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