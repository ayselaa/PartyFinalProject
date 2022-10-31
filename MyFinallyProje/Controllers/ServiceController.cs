using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IServiceService _serviceService;
        private readonly IServiceDetailService _serviceDetailService;
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;


        public ServiceController(IServiceService serviceService,
                                 IServiceDetailService serviceDetailService,
                                 AppDbContext context,
                                 ICommentService commentService,
                                 UserManager<AppUser> userManager
)
        {
            _serviceService = serviceService;
            _serviceDetailService = serviceDetailService;
            _context = context;
            _commentService = commentService;
            _userManager = userManager;

        }


        public async Task<IActionResult> Index()
        {
            ServiceVM serviceVm = new ServiceVM();

            serviceVm.ServiceDetails = await _serviceDetailService.GetAll();
            serviceVm.Services = await _serviceService.GetAll();
            serviceVm.Comments = await _commentService.GetAll();


            return View(serviceVm);
        }


        public IActionResult Detail(int? Id)
        {
            Service service = _context.Services.Include(n => n.ServiceDetail).Include(n => n.ServiceImage).ThenInclude(n => n.Image).FirstOrDefault(s => s.ServiceDetailId == Id);

            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(int id, Comment comment)
        {

            AppUser member = null;

            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.GetUserAsync(User);
            Comment comment1 = new Comment()
            {
                AppUserId = User.Identity.IsAuthenticated ? member.Id : null,

                Username = member.UserName,
                Email = member.Email,
                Text = comment.Text,

            };

            await _context.Comments.AddAsync(comment1);
            await _context.SaveChangesAsync();
            }

            else
            {
                return View("ErrorPage");
            }


            return Redirect(HttpContext.Request.Headers["Referer"].ToString());

        }

     
    }
}
