using DAL.Base;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Blog : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int? BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }
        public ICollection<BlogImage> BlogImage { get; set; }
    }
}
