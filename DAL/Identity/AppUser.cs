using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Identity
{
    public class AppUser : IdentityUser
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsAdmin { get; set; }


        [NotMapped]
        public IFormFile ProfileImage { get; set; }
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
