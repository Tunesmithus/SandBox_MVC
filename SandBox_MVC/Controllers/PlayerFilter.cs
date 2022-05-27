using Microsoft.AspNetCore.Mvc;

namespace SandBox_MVC.Controllers
{
    public class PlayerFilter : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
