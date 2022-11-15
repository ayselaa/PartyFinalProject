using Business.Services;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBlogService _blogService;
        private readonly IWebHostEnvironment _env;
        private readonly IImageService _ımageService;
        private readonly IBlogDetailsService _blogDetailsService;

        public BlogController(AppDbContext context,
                                   IBlogService blogService,
                                   IWebHostEnvironment env,
                                   IImageService ımageService,
                                   IBlogDetailsService blogDetailsService)
        {
            _blogService = blogService;
            _env = env;
            _blogDetailsService = blogDetailsService;
            _context = context;
            _ımageService = ımageService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _blogService.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            List<BlogImage> blogImages = new List<BlogImage>();


            if (blog.ImageFile is null)
            {
                ModelState.AddModelError("ImageFile", "Image can not be empty");
                return View(blog);
            }

            foreach (var imageFile in blog.ImageFile)
            {
                string fileName = Guid.NewGuid().ToString() + imageFile.FileName;
                if (fileName.Length > 255)
                {
                    fileName = fileName.Substring(fileName.Length - 254);
                }

                string path = Path.Combine(_env.WebRootPath, "assets", "img", "blogsekilleri", fileName);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fs);
                }

                Image image = new Image();
                image.Url = fileName;

                await _ımageService.Create(image);

                BlogImage blogImage = new BlogImage()
                {
                    BlogId = blog.Id,
                    Blog = blog,
                    Image = image,
                    ImageId = image.Id
                };

                blogImages.Add(blogImage);
            }

            blog.BlogImage = blogImages;

            await _blogService.Create(blog);


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = await _blogService.Get(id);

            return View(data);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            await _blogService.Delete(id);


            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Update(int id, Blog blog)
        {
            await _blogService.Update(id, blog);

            return RedirectToAction(nameof(Index));
        }

    }
}
