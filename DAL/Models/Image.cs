using DAL.Entity;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public ICollection<ServiceImage> ServiceImages { get; set; }
        public ICollection<BlogImage> BlogImages { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<TeamImage> TeamImages { get; set; }
        public ICollection<GalleryImage> GalleryImages { get; set; }
    }
}
