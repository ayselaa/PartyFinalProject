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
    public class ServiceRepository : IServiceService
    {
        private readonly AppDbContext _context;
        public ServiceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Service entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Services.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Service> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Services.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.ServiceImage)
                                                             .ThenInclude(n => n.Image)
                                                             .Include(n => n.Comments)
                                                             .ThenInclude(n=> n.AppUser)
                                                             .FirstOrDefaultAsync();
            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Service>> GetAll()
        {
            var data = await _context.Services.Where(n => !n.IsDeleted)
                                                                    .Include(n => n.ServiceImage)
                                                                    .ThenInclude(n => n.Image)
                                                                    .Include(n => n.Comments)
                                                                    .ThenInclude(n => n.AppUser)
                                                                    .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Update(int id, Service entity)
        {
            var data = await Get(id);
            data.Title = entity.Title;
            data.Text1 = entity.Text1;
            data.Text2 = entity.Text2;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
