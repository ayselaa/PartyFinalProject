using DAL.Base;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Service : BaseEntity, IEntity
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public int? ServiceDetailId { get; set; }
        public ServiceDetail ServiceDetail { get; set; }
      
        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }
        public ICollection<ServiceImage> ServiceImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}