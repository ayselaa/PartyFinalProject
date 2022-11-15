using DAL.Base;
using DAL.Entity;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Category : BaseEntity, IEntity
    {
        [Required]
        public string Name { get; set; }
        public Service Service { get; set; }

    }
}
