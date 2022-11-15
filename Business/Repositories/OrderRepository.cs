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
    public class OrderRepository : IOrderService
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Order entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Orders.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Order> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Orders.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.OrderProducts)
                                                             .ThenInclude(n => n.Product)
                                                             .ThenInclude(m => m.ProductImage)
                                                             .Include(n => n.AppUser)
                                                             .FirstOrDefaultAsync();
            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Order>> GetAll()
        {
            var data = await _context.Orders.Where(n => !n.IsDeleted)
                                                                                .Include(n => n.OrderProducts)
                                                                                .ThenInclude(n => n.Product)
                                                                                .Include(n => n.AppUser)
                                                                                .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Update(int id, Order entity)
        {
            var data = await Get(id);
            data.Adress = entity.Adress;
            data.LastName = entity.LastName;
            data.FirstName = entity.FirstName;
            data.Email = entity.Email;
            data.PhoneNumber = entity.PhoneNumber;
            data.PostalCode = entity.PostalCode;
            data.City = entity.City;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
