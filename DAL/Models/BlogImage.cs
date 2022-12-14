using DAL.Entity;

namespace DAL.Models
{
    public class BlogImage : IEntity
    {
        public int Id { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
