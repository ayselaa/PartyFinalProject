using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IReservationService _reservationService;
        public ContactController(AppDbContext context,
                                 UserManager<AppUser> userManager,
                                 IReservationService reservationService)
        {
            _context = context;
            _userManager = userManager;
            _reservationService = reservationService;
        }

        public async Task<IActionResult> Index()
        {
            ContactVM contactVm = new ContactVM();

            

            return View(contactVm);
        }


        [HttpPost]
        public async Task<IActionResult> Reservation(ContactVM contactVM)
        {
            var data = await _context.Reservations.AddAsync(contactVM.Reservation);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Contact");
        }
    }
}
