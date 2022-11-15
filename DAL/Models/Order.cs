using DAL.Base;
using DAL.Entity;
using DAL.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Order : BaseEntity, IEntity
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
        public AppUser AppUser { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }






    }
}
