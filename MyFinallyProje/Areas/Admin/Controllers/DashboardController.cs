using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
