using DAL.Base;
using DAL.Entity;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class ServiceDetail : BaseEntity, IEntity
    {
        [Required]
        public string Content { get; set; }
        public Service Service { get; set; }
    }
}
