using DAL.Base;
using DAL.Entity;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class BlogDetail : BaseEntity, IEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog Blog { get; set; }
    }
}
