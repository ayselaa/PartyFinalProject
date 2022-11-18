using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        private readonly IBlogService _blogService;
        private readonly IProductDetailService _productDetailService;
        private readonly UserManager<AppUser> _userManager;


        public ShopController(AppDbContext context,
                              IProductService productService,
                              IProductDetailService productDetailService,
                              UserManager<AppUser> userManager
,
                              IBlogService blogService
)
        {
            _context = context;
            _productService = productService;
            _productDetailService = productDetailService;
            _userManager = userManager;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index(int id)
        {

            ShopVM shopVm = new ShopVM();

            shopVm.Blogs = await _blogService.GetAll();


            List<Category> categories = _context.Categories.ToList();
            ViewBag.Categories = categories;

            if (id != 0)
            {
                var products = await _context.Products
                                                .Where(p => p.Category.Id == id)
                                                .Include(n => n.Category)
                                                .Include(n => n.ProductImage)
                                                .ThenInclude(n => n.Image)
                                                .ToListAsync();
                shopVm.Products =  products;

            }
            else
            {
                shopVm.Products = await _productService.GetAll();
            }

            

            return View(shopVm);

        }

        //public async Task<IActionResult> CategoryFilter(int id)
        //{

        //    ShopVM shopVm = new ShopVM();

        //    shopVm.Products = await _productService.GetAll();
            
        //    List<Category> categories = _context.Categories.ToList();


        //    ViewBag.Categories = categories;

        //    return View(shopVm);

        //}






        public IActionResult Detail(int? Id)
        {
            Product product = _context.Products.Include(n => n.ProductDetail).Include(n => n.ProductImage).ThenInclude(n => n.Image).FirstOrDefault(s => s.Id == Id);

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

            return Ok(basketVMs);
        }

        #endregion

        #region Remove Basket
        public async Task<IActionResult> RemoveFromBasket(int? id)
        {
            if (id == null) return BadRequest();

            AppUser member = null;

            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.Users.FirstOrDefaultAsync(x =>
                x.UserName == User.Identity.Name && !x.IsAdmin);
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
            return RedirectToAction("Index", "Shop");
        }

        #endregion

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
