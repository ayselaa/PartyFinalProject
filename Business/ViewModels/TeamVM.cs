using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class TeamVM
    {
        public List<TeamDetail> TeamDetails { get; set; }
        public List<Team> Teams { get; set; }
    }
}
