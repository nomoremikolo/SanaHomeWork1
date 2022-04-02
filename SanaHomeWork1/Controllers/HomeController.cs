using Microsoft.AspNetCore.Mvc;
using SanaHomeWork1.Models;
using System.Diagnostics; 

namespace SanaHomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Greetings(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Greetings", user);
            }
            else
            {
                return View("Index");
            }
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}