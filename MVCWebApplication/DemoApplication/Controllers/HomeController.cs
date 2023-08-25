using DemoApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Configuration;
using DemoApplication.Services;
using DemoApplication.Filters;

namespace DemoApplication.Controllers

{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         
        private readonly IEmailMessage _message;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IEmailMessage message)
        {
            _message = message;
        }

        [SampleActionFilter]
        public IActionResult Index()
        {
            //ErrorViewModel obj = new ErrorViewModel()
            //{
            //    Name = "Jayanth"
            //};
            //ViewData["obj"] = errorViewModel;
            //TempData["Class"] = 12;
            _message.Send("Email sent");

            ViewBag.Title = "Home";
            Student student = new Student()
            {
                Name = "Jayanth",
                Age = 20
            };
            ViewBag.A = "abc";
            StudentDetailsViewModel obj = new StudentDetailsViewModel()
            {
                Student=student,
                Title="Title1",
                Header="Header1"
            };
            return View(obj);
        }

        //[Route("login/{id?}")]
        public IActionResult Index1()
        {
            return View();
            
        }
		public IActionResult Index2()
		{
			return View();
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Student { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}