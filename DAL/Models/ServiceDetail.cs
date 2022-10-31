using DAL.Base;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class ServiceDetail : BaseEntity, IEntity
    {
        [Required]
        public string Content { get; set; }
        public Service Service { get; set; }
    }
}
