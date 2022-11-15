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
    public class ReservationRepository : IReservationService
    {
        private readonly AppDbContext _context;
        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Reservation entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Reservations.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Reservation> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Reservations.Where(n => n.Id == id && !n.IsDeleted)
                                                             .FirstOrDefaultAsync();
            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Reservation>> GetAll()
        {
            var data = await _context.Reservations.Where(n => !n.IsDeleted)
                                                                      .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public Task Update(int id, Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
