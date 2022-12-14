using Business.Services;
using DAL.Data;
using DAL.Models;
using Exceptions.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class ProductDetailRepository : IProductDetailService
    {
        private readonly AppDbContext _context;

        public ProductDetailRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(ProductDetail entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);

            await _context.ProductDetails.AddAsync(entity);
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);

            data.IsDeleted = true;
        }

        public async Task<ProductDetail> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.ProductDetails.Where(n => !n.IsDeleted).Where(n => n.Id == id).Include(n => n.Product)
                                                                                                        .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }

        public async Task<List<ProductDetail>> GetAll()
        {
            var data = await _context.ProductDetails.Where(n => !n.IsDeleted).Include(n => n.Product).ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }

        public async Task Update(int id, ProductDetail entity)
        {
            var data = await Get(id);

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            data.Title = entity.Title;
            data.Price = entity.Price;
            data.Description = entity.Description;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            _context.ProductDetails.Update(data);
        }
    }
}
