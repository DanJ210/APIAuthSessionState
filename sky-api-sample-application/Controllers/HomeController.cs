using Microsoft.AspNetCore.Mvc;

namespace CHS.SkyApiAuthCodeFlow
{
    
    /// <summary>
    /// Handles MVC actions and views.
    /// </summary>
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}