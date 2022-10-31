using Microsoft.AspNetCore.Mvc;

namespace MyFinallyProje.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
