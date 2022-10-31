using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
   public  class ServiceVM
    {
        public List<ServiceDetail> ServiceDetails { get; set; }
        public List<Service> Services{ get; set; }
        public Comment Comment { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
 