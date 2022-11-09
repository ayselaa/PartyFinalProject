using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MyFinallyProje.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOrderService _orderservice;
        private readonly UserManager<AppUser> _userManager;
       
        public OrderController(AppDbContext context,
                              IOrderService orderservice,
                              UserManager<AppUser> userManager
                              )
        {
            _context = context;
            _orderservice = orderservice;
            _userManager = userManager;
        }
       
        public  IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateOrder(OrderVM order)
        {
            return Ok();
        }
    }
}
