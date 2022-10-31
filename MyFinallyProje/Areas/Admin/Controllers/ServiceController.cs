using Business.Services;
using DAL.Data;
using DAL.Migrations;
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
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IServiceService _serviceService;
        private readonly IServiceDetailService _serviceDetailService;
        private readonly IWebHostEnvironment _env;
        private readonly IImageService _ımageService;
        public ServiceController(AppDbContext context,
                                 IServiceService serviceService,
                                 IServiceDetailService serviceDetailService,
                                 IWebHostEnvironment env,
                                  IImageService ımageService)
        {
            _context = context;
            _serviceService = serviceService;
            _serviceDetailService = serviceDetailService;
            _env = env;
            _ımageService = ımageService;

        }

        public async Task<IActionResult> Index()
        {
            var data = await _serviceService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {

            await _serviceService.Create(service);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Update(int id, Service service)
        {
            await _serviceService.Update(id, service);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = await _serviceService.Get(id);

            return View(data);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            await _serviceService.Delete(id);

            return RedirectToAction(nameof(Index));
        }


    }
}
