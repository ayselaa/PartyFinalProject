using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly UserManager<AppUser> _userManager;


        public ShopController(AppDbContext context,
                              IProductService productService,
                              IProductDetailService productDetailService,
                              UserManager<AppUser> userManager
)
        {
            _context = context;
            _productService = productService;
            _productDetailService = productDetailService;
            _userManager = userManager;
        }
        public async Task <IActionResult> Index()
        {

            ShopVM shopVm = new ShopVM();

            shopVm.Products = await _productService.GetAll();
            shopVm.ProductDetails = await _productDetailService.GetAll();


            return View(shopVm);
        }
        public IActionResult Detail(int? Id)
        {
            Product product =  _context.Products.Include(n => n.ProductDetail).Include(n => n.ProductImage).ThenInclude(n => n.Image).FirstOrDefault(s => s.Id == Id);

            return View(product);
        }


        #region Add Basket
        [HttpPost]
        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null) return BadRequest();

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            BasketVM basketVM = new BasketVM
            {
                Id = product.Id,

                Count = 1,
            };

            List<BasketVM> basketVMs = new List<BasketVM>();

            string cookie = HttpContext.Request.Cookies["basket"];


            if (cookie == null)
            {
                basketVMs.Add(basketVM);
            }
            else
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);

                if (basketVMs.Any(b => b.Id == basketVM.Id))
                {
                    basketVMs.FirstOrDefault(b => b.Id == basketVM.Id).Count += 1;
                }
                else
                {
                    basketVMs.Add(basketVM);
                }
            }
            string prod = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", prod);

            return Ok();
        }

        #endregion
        
        public async Task<IActionResult> RemoveFromBasket(int? id)
        {
            if (id == null) return BadRequest();

            AppUser member = null;
            
            if (User.Identity.IsAuthenticated)
            {
                member =  _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            List<BasketVM> basketVMs = new List<BasketVM>();
            if (member == null)
            {
                string cookie = HttpContext.Request.Cookies["basket"];
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
                basketVMs = basketVMs.Where(b => b.Id != id).ToList();

                


                string prod = JsonConvert.SerializeObject(basketVMs);
                HttpContext.Response.Cookies.Append("basket", prod);
            }
            return RedirectToAction("Index","Basket");
        }

        #region Get Session
        public IActionResult GetSession()
        {

            string cookie = HttpContext.Request.Cookies["basket"];

            List<BasketVM> basketVMs = new List<BasketVM>();

            if (cookie != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookie);
            }

            foreach (BasketVM basketVM in basketVMs)
            {
                basketVM.Price = _context.Products.FirstOrDefault(p => p.Id == basketVM.Id).Price;
            }

            return Json(basketVMs);
        }
        #endregion
    }
}
