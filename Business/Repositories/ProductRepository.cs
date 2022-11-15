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
    public class ProductRepository : IProductService
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Products.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Product> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Products.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.ProductImage)
                                                             .ThenInclude(n => n.Image)
                                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Product>> GetAll()
        {
            var data = await _context.Products.Where(n => !n.IsDeleted)
                                                                                .Include(n => n.ProductImage)
                                                                                 .ThenInclude(n => n.Image)
                                                                                .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Product entity)
        {
            var data = await Get(id);
            data.Title = entity.Title;
            data.Description = entity.Description;
            data.Price = entity.Price;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }

    }
}