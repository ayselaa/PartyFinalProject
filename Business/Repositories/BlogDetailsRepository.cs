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
    public class BlogDetailsRepository : IBlogDetailsService
    {
        private readonly AppDbContext _context;

        public BlogDetailsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(BlogDetail entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);

            await _context.BlogDetails.AddAsync(entity);
        }



        public async Task Delete(int? id)
        {
            var data = await Get(id);

            data.IsDeleted = true;
        }


        public async Task<BlogDetail> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.BlogDetails.Where(n => !n.IsDeleted).Where(n => n.Id == id).Include(n => n.Blog).FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }



        public async Task<List<BlogDetail>> GetAll()
        {
            var data = await _context.BlogDetails.Where(n => !n.IsDeleted).Include(n => n.Blog).ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }




        public async Task Update(int id, BlogDetail entity)
        {
            var data = await Get(id);

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            data.Title = entity.Title;
            data.Description = entity.Description;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            _context.BlogDetails.Update(data);
        }
    }
}
