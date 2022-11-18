using Business.Services;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        private readonly IProductDetailService _productDetailService;
        private readonly IWebHostEnvironment _env;
        private readonly IImageService _ımageService;

        public ProductController(AppDbContext context,
                                   IProductService productService,
                                   IWebHostEnvironment env,
                                   IImageService ımageService,
                                   IProductDetailService productDetailService)
        {
            _context = context;
            _productService = productService;
            _env = env;
            _ımageService = ımageService;
            _productDetailService = productDetailService;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = await _productService.Get(id);

            return View(data);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var catagories = _context.Categories.ToList();
            ViewBag.Categories = catagories;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            List<ProductImage> productImages = new List<ProductImage>();
            var category = _context.Categories.FirstOrDefault(x => x.Id == product.Category.Id);
            product.Category = category;

            if (product.ImageFile is null)
            {
                ModelState.AddModelError("ImageFile", "Image can not be empty");
                return View(product);
            }

            foreach (var imageFile in product.ImageFile)
            {
                string fileName = Guid.NewGuid().ToString() + imageFile.FileName;
                if (fileName.Length > 255)
                {
                    fileName = fileName.Substring(fileName.Length - 254);
                }

                string path = Path.Combine(_env.WebRootPath, "assets", "uploads", "images", fileName);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fs);
                }

                Image image = new Image();
                image.Url = fileName;

                await _ımageService.Create(image);

                ProductImage productImage = new ProductImage()
                {
                    ProductId = product.Id,
                    Product = product,
                    Image = image,
                    ImageId = image.Id
                };

                productImages.Add(productImage);
            }

            product.ProductImage = productImages;

            await _productService.Create(product);


            return RedirectToAction(nameof(Index));


        }

       
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Product product = await _context.Products.Where(n => n.Id == id).FirstOrDefaultAsync();
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, Product product)
        {
            await _productService.Update(id, product);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            await _productService.Delete(id);


            return RedirectToAction(nameof(Index));
        }
    }
}
