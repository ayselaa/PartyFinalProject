using Business.Services;
using DAL.Data;
using DAL.Models;
using Exceptions.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class CategoryRepository : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Category entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Categories.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Category> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Categories.Where(n => n.Id == id && !n.IsDeleted)
                                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Category>> GetAll()
        {
            var data = await _context.Categories.Where(n => !n.IsDeleted)
                                                                   .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Update(int id, Category entity)
        {
            var data = await Get(id);
            data.Name = entity.Name;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
