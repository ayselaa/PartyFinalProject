using DAL.Base;
using DAL.Entity;
using DAL.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Reservation : BaseEntity, IEntity
    {
        public string Name { get; set; }
        
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Venue { get; set; }
        
        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        public string Text { get; set; }
      
    }
}
