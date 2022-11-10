using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
