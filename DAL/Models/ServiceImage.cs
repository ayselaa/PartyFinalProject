using DAL.Entity;

namespace DAL.Models
{
    public class ServiceImage : IEntity
    {
        public int Id { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
