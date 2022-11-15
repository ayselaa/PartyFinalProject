using DAL.Models;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class TeamVM
    {
        public List<TeamDetail> TeamDetails { get; set; }
        public List<Team> Teams { get; set; }
    }
}
