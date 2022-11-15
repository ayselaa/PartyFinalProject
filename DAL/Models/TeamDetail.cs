using DAL.Base;
using DAL.Entity;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class TeamDetail : BaseEntity, IEntity
    {
        [Required, MaxLength(20)]
        public string Title { get; set; }

        [Required, MaxLength(20)]
        public string Job { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Number is not valid")]
        [Required, MaxLength(20)]
        public string Number { get; set; }
        public Team Team { get; set; }
    }
}
