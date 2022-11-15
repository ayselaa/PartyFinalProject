using Business.Base;
using DAL.Models;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IProductService : IBaseService<Product>
    {
        Task SaveChanges();
    }
}
