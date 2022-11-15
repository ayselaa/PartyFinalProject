using DAL.Base;
using DAL.Entity;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Gallery : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public ICollection<GalleryImage> GalleryImage { get; set; }

    }
}
