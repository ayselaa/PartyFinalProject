using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBlogService _blogService;
        private readonly IBlogDetailsService _blogDetailsService;
        private readonly ICategoryService _categoryService;


        public BlogController(AppDbContext context,
                              IBlogService blogService,
                              IBlogDetailsService blogDetailsService,
                              ICategoryService categoryService
)
        {
            _context = context;
            _blogService = blogService;
            _blogDetailsService = blogDetailsService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            BlogVM blogVm = new BlogVM();

            blogVm.Blogs = await _blogService.GetAll();
            blogVm.BlogDetails = await _blogDetailsService.GetAll();
            blogVm.Categories = await _categoryService.GetAll();

            return View(blogVm);
        }

        public async Task<IActionResult> Detail(int? Id)
        {

            Blog blog = await _context.Blogs.Include(n => n.BlogDetail).Include(n => n.BlogImage).ThenInclude(n => n.Image).FirstOrDefaultAsync(s => s.Id == Id);

            return View(blog);
        }
    }
}
