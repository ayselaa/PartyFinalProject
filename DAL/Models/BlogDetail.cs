using DAL.Base;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class BlogDetail : BaseEntity , IEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog Blog { get; set; }
    }
}
