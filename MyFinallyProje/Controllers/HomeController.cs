using Business.Services;
using Business.ViewModels;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHomeBoxService _homeBoxService;
        private readonly IServiceService _serviceService;
        private readonly IServiceDetailService _serviceDetailService;
        private readonly IImageService _ımageService;
        private readonly IBlogService _blogService;
        private readonly IBlogDetailsService _blogDetailsService;
        private readonly IGalleryService _galleryService;

        public HomeController(IHomeBoxService homeBoxService,
                             IServiceService serviceService,
                             IServiceDetailService serviceDetailService,
                             IImageService ımageService,
                              AppDbContext context,
                             IBlogService blogService,
                             IBlogDetailsService blogDetailsService,
                              IGalleryService galleryService)
        {
            _homeBoxService = homeBoxService;
            _serviceService = serviceService;
           _serviceDetailService= serviceDetailService;
            _ımageService = ımageService;
            _context = context;
            _blogService = blogService;
            _blogDetailsService= blogDetailsService;
            _galleryService = galleryService;

        }
        public async Task <IActionResult> Index()
        {
            HomeVM homeVm = new HomeVM();

            homeVm.HomeBoxes = await _homeBoxService.GetAll();
            homeVm.Services =await _context.Services.Include(s=>s.ServiceDetail).ToListAsync();
            homeVm.ServiceDetails = await _serviceDetailService.GetAll();
            homeVm.Images = await _ımageService.GetAll();
            homeVm.Blogs = await _blogService.GetAll();
            homeVm.BlogDetails = await _blogDetailsService.GetAll();
            homeVm.Galleries= await _galleryService.GetAll();

            return View(homeVm);
        }
    }
}
