using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class GalleryImage: IEntity
    {
        public int Id { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
    }
}
