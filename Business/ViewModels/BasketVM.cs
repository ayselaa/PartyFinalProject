using DAL.Identity;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class BasketVM
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ProductImage ProductImage { get; set; }
    }
}
