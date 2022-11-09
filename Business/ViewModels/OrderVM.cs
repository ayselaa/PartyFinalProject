using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels
{
    public class OrderVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
