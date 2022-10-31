using DAL.Base;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Category : BaseEntity, IEntity
    {
        [Required]
        public string Name { get; set; }
        public Service Service { get; set; }

    }
}
