using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        // controller 
        public IActionResult Index()
        {
            return View();
        }
    }    
}