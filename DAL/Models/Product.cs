using DAL.Base;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Product : BaseEntity, IEntity
    {
        [Required, MaxLength(30)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [Range(0, 100)]
        public double Price { get; set; }

        public int? ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }


    }
}
