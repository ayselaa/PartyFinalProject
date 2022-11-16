using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MyFinallyProje.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        private readonly IOrderService _orderservice;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public OrderController(AppDbContext context,
                              IOrderService orderservice,
                              UserManager<AppUser> userManager,
                              IHttpContextAccessor httpContextAccessor,
                              IProductService productService
                              )
        {
            _context = context;
            _orderservice = orderservice;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
        }

      
        #region Create Order
        [HttpGet]
        public IActionResult CreateOrder()
        {
            OrderVM orderVM = new OrderVM();
            orderVM.Alert = "false";
            return View(orderVM);
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderVM orderVM)
        {
            
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            var basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            orderVM.Alert = "true";

            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            orderVM.Order.AppUser = user;

            var data = await _context.Orders.AddAsync(orderVM.Order);
            OrderProduct orderp = new OrderProduct();
            _context.SaveChanges();

            foreach (var item in basketVMs)
            {
                var product = await _productService.Get(item.Id);
                orderp.Order = orderVM.Order;
                orderp.Product = product;
                _context.OrderProducts.Add(orderp);
                _context.SaveChanges();

            }
            return View(orderVM);
        }


        
        #endregion
    }

}
