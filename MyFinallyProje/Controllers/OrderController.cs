using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public  async Task<IActionResult> CreateOrder(OrderVM orderVM)
        {
            var data = await _context.Orders.AddAsync(orderVM.Order);
            _context.SaveChanges();
            return RedirectToAction("Index", "Order");
        }
    }
}
