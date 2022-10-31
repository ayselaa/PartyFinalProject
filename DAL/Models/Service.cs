﻿using DAL.Base;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Service : BaseEntity, IEntity
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        public int? ServiceDetailId { get; set; }
        public ServiceDetail ServiceDetail { get; set; }
        public int? CategoryId { get; set; }
        public Category Category{ get; set; }
        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }
        public ICollection<ServiceImage> ServiceImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}