using Business.Services;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ReservationController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IReservationService _reservationService;

        public ReservationController(AppDbContext context,
                                     IReservationService reservationService)
        {
            _context = context;
            _reservationService = reservationService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _reservationService.GetAll();
            return View(data);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            await _reservationService.Delete(id);

            return RedirectToAction(nameof(Index));
        }



    }
}
