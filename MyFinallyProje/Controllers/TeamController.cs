using Business.Repositories;
using Business.Services;
using Business.ViewModels;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinallyProje.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ITeamService _teamService;
        private readonly ITeamDetailService _teamDetailService;

        public TeamController(AppDbContext context,
                              ITeamService teamService,
                              ITeamDetailService teamDetailService)
        {
            _context = context;
            _teamService = teamService;
            _teamDetailService = teamDetailService;
        }
        public async Task <IActionResult> Index()
        {
            TeamVM teamVm = new TeamVM();

            teamVm.Teams = await _teamService.GetAll();
            teamVm.TeamDetails = await _teamDetailService.GetAll();

            return View(teamVm);
        }

        public async Task<IActionResult> Detail(int? Id)
        {
            Team team = await _context.Teams.Include(n => n.TeamDetail).Include(n => n.TeamImage).ThenInclude(n => n.Image).FirstOrDefaultAsync(s => s.Id == Id);

            return View(team);
        }
    }
}
