using Business.Services;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Area("admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOrderService _orderService;
        public OrderController(AppDbContext context, IOrderService orderService)
        {
            _context = context;
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _orderService.GetAll();
            return View(data);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            await _orderService.Delete(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int? id)
        {
            var data = await _orderService.Get(id);
            var url = data.OrderProducts.Select(n => n.Product.ProductImage.Select(m => m.Image.Url).FirstOrDefault()).ToList();

            return View(data);
        }
    }
}
