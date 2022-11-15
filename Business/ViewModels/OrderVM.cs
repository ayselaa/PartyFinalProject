using DAL.Models;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ProductImage ProductImage { get; set; }

    }
}
