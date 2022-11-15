using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IReservationService _reservationService;
        private readonly IWebHostEnvironment _env;

        public ContactController(AppDbContext context,
                                 UserManager<AppUser> userManager,
                                 IReservationService reservationService,
                                 IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _reservationService = reservationService;
            _env = env;
        }

        public IActionResult Index()
        {
            ContactVM contactVm = new ContactVM();

            return View(contactVm);
        }


        [HttpPost]
        public async Task<IActionResult> Reservation(ContactVM contactVM)
        {
            var data = await _context.Reservations.AddAsync(contactVM.Reservation);
            _context.SaveChanges();


            string userName = User.Identity.Name;
            var appUser = await _userManager.FindByNameAsync(userName);
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Event Menegment System", "ayselabilovaa12@gmail.com"));

            message.To.Add(new MailboxAddress(appUser.FullName, appUser.Email));
            message.Subject = "Confirm Email";

            string emailbody = "New Year Reservation Invitation!";



            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();


            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ayselabilovaa12@gmail.com", "zzrwnzlbuzqglzmn\r\n");
            smtp.Send(message);

            smtp.Disconnect(true);


            return RedirectToAction("Index", "Contact");
        }
    }
}
