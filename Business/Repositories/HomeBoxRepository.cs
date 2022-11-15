using Business.Services;
using DAL.Data;
using DAL.Models;
using Exceptions.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HomeBoxRepository : IHomeBoxService
    {
        private readonly AppDbContext _context;
        public HomeBoxRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(HomeBox entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.HomeBoxs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<HomeBox> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.HomeBoxs.Where(n => n.Id == id && !n.IsDeleted)
                                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<HomeBox>> GetAll()
        {
            var data = await _context.HomeBoxs.Where(n => !n.IsDeleted).ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Update(int id, HomeBox entity)
        {
            var data = await Get(id);
            data.Icon = entity.Icon;
            data.Title = entity.Title;
            data.Description = entity.Description;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
