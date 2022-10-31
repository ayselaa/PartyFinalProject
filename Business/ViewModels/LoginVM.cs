using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels
{
    public class LoginVM
    {
        [Required, MaxLength(20)]
        public string Username { get; set; }

        [Required, MaxLength(20), DataType(DataType.Password)]
        public string Password { get; set; }
     
        public bool RememberMe { get; set; }
    }
}
