using DAL.Data;
using DAL.Identity;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class BasketController : Controller
    {
        //private readonly AppDbContext _context;
        //private readonly UserManager<AppUser> _userManager;
        //public BasketController(AppDbContext context,
        //                       UserManager<AppUser> userManager)
        //{
        //    _context = context;
        //    _userManager = userManager;
        //}

        //[Authorize(Roles = "Member")]
        public IActionResult Index()
        {
            //List<Basket> baskets = _context.Baskets.Where(x => x.AppUser.UserName == User.Identity.Name).ToList();
            //return View(baskets);
            return View();
        }


        //public async Task<IActionResult> Checkout(int id)
        //{
        //    Product product = _context.Products.Include(x => x.ProductImage).FirstOrDefault(x => x.Id == id);
        //    AppUser member = null;
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        member = await _userManager.FindByNameAsync(User.Identity.Name);
        //    }

        //    Basket basket = new Basket
        //    {
        //        FullName = member.FullName,
        //        TotalPrice = product.Price,
        //        AppUserId = member.Id,
        //        ProductId = product.Id,
        //        CreatedDate = System.DateTime.UtcNow
        //    };

        //    _context.Baskets.Add(basket);
        //    _context.SaveChanges();
        //    return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        //}

        //public IActionResult DeleteFromBasket(int id)
        //{
        //    Basket basket = _context.Baskets.FirstOrDefault(x => x.Id == id);

        //    if (basket == null) return NotFound();

        //    _context.Baskets.Remove(basket);
        //    _context.SaveChanges();

        //    return RedirectToAction("index", "basket");
        //}
    }
}
