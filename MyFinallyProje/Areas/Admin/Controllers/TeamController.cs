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
using Team = DAL.Models.Team;

namespace MyFinallyProje.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    [Area("admin")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ITeamService _teamService;
        private readonly ITeamDetailService _teamDetailService;
        private readonly IWebHostEnvironment _env;
        private readonly IImageService _ımageService;


        public TeamController(AppDbContext context,
                                   ITeamService teamService,
                                   ITeamDetailService teamDetailService,
                                   IWebHostEnvironment env,
                                   IImageService ımageService)
        {
            _context = context;
            _teamService = teamService;
            _teamDetailService = teamDetailService;
            _env = env;
            _ımageService = ımageService;


        }
        public async Task<IActionResult> Index()
        {
            var data = await _teamService.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Details(int? id)
        {
            var data = await _teamService.Get(id);

            return View(data);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            List<TeamImage> teamImages = new List<TeamImage>();


            if (team.ImageFile is null)
            {
                ModelState.AddModelError("ImageFile", "Image can not be empty");
                return View(team);
            }

            foreach (var imageFile in team.ImageFile)
            {
                string fileName = Guid.NewGuid().ToString() + imageFile.FileName;
                if (fileName.Length > 255)
                {
                    fileName = fileName.Substring(fileName.Length - 254);
                }

                string path = Path.Combine(_env.WebRootPath, "assets", "img", "team", fileName);

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fs);
                }

                Image image = new Image();
                image.Url = fileName;

                await _ımageService.Create(image);

                TeamImage teamImage = new TeamImage()
                {
                    TeamId = team.Id,
                    Team = team,
                    Image = image,
                    ImageId = image.Id
                };

                teamImages.Add(teamImage);
            }

            team.TeamImage = teamImages;

            await _teamService.Create(team);


            return RedirectToAction(nameof(Index));


        }





        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Team team = await _context.Teams.Where(n => n.Id == id).FirstOrDefaultAsync();
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, Team team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }

            Team DbTeam = await _context.Teams.Include(s => s.TeamImage)
                                                    .ThenInclude(s => s.Image)
                                                    .FirstOrDefaultAsync(n => n.Id == id);
            if (DbTeam is null) return NotFound();
            string newRoot = Path.Combine(_env.WebRootPath, "assets", "img", "team", DbTeam.TeamImage.FirstOrDefault().Image.Url);
            foreach (var teamImage in DbTeam.TeamImage)
            {
                if (System.IO.File.Exists(Path.Combine(newRoot, teamImage.Image.Url)))
                {
                    System.IO.File.Delete(Path.Combine(newRoot, teamImage.Image.Url));
                }
            }


            if (team.Title is null)
            {
                ModelState.AddModelError("Title", "Please enter title name!");
                return View(DbTeam);
            }

            //if (team.ImageFile is null)
            //{
            //    ModelState.AddModelError("ImageFile", "Please enter image!");
            //    return View(DbTeam);

            //}

            List<Image> images = new List<Image>();
            if (team.ImageFile != null)
            {
                foreach (var item in team.ImageFile)
                {
                    string rootPath = _env.WebRootPath;

                    string fileName = Guid.NewGuid().ToString() + item.FileName;
                    if (fileName.Length > 255)
                    {
                        fileName = fileName.Substring(fileName.Length - 254);
                    }
                    string root = Path.Combine(rootPath, "assets", "img", "team", fileName);
                    using (FileStream fs = new FileStream(root, FileMode.Create))
                    {
                        await item.CopyToAsync(fs);
                    };
                    DbTeam.TeamImage.FirstOrDefault().Image.Url = fileName;
                }
            }

            DbTeam.Number = team.Number;
            DbTeam.TeamDetail = team.TeamDetail;
            DbTeam.Address = team.Address;
            DbTeam.Email = team.Email;
            DbTeam.Title = team.Title;
            DbTeam.Job = team.Job;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





        public async Task<IActionResult> Delete(int? id)
        {
            await _teamService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
