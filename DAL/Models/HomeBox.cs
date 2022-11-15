using DAL.Base;
using DAL.Entity;

namespace DAL.Models
{
    public class HomeBox : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

    }
}
