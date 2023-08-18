using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller
    {
        // controller 
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            
            // ViewBag.Selamlama= saat>12 ? "İyi günler":"Günaydın";
            // ViewBag.UserName="Furkan";
            ViewData["Selamlama"]=saat>12 ? "İyi günler":"Günaydın";
            ViewData["User"]="Furkan";
            return View();
        }
    }    
}