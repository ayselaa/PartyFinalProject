using Microsoft.AspNetCore.Mvc;

namespace MyFinallyProje.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
