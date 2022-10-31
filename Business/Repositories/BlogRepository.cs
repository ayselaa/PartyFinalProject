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
    public class BlogRepository : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Blog entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Blogs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }



        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }



        public async Task<Blog> Get(int? id)
        {

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Blogs.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.BlogImage)
                                                             .ThenInclude(n => n.Image)
                                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }



        public async Task<List<Blog>> GetAll()
        {
            var data = await _context.Blogs.Where(n => !n.IsDeleted)
                                                                    .Include(n => n.BlogImage)
                                                                    .ThenInclude(n => n.Image)
                                                                    .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }



        public async Task Update(int id, Blog entity)
        {
            var data = await Get(id);
            data.Title = entity.Title;
            data.Description = entity.Description;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
