﻿using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MyFinallyProje.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOrderService _orderservice;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public OrderController(AppDbContext context,
                              IOrderService orderservice,
                              UserManager<AppUser> userManager,
                              IHttpContextAccessor httpContextAccessor
                              )
        {
            _context = context;
            _orderservice = orderservice;
            _userManager = userManager;
             _httpContextAccessor=  httpContextAccessor;
        }
       
        public  IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public  async Task<IActionResult> CreateOrder(OrderVM orderVM)
        {
            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
            var basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
           

            string userName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            orderVM.Order.AppUser = user;

            var data = await _context.Orders.AddAsync(orderVM.Order);

            _context.SaveChanges();
            return RedirectToAction("Payment", "Order");
        }
        
        public IActionResult Payment()
        {
            return View();
        }
    }
}
