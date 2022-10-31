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
    public class TeamRepository : ITeamService
    {
        private readonly AppDbContext _context;
        public TeamRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Team entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Teams.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task<Team> Get(int? id)
        {

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Teams.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.TeamImage)
                                                             .ThenInclude(n => n.Image)
                                                             .FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task<List<Team>> GetAll()
        {
            var data = await _context.Teams.Where(n => !n.IsDeleted)
                                                                                           .Include(n => n.TeamImage)
                                                                                           .ThenInclude(n => n.Image)
                                                                                           .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public async Task Update(int id, Team entity)
        {
            var data = await Get(id);
            data.Title = entity.Title;
            data.Address = entity.Address;
            data.Number = entity.Number;
            data.Email = entity.Email;
            data.Job = entity.Job;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();
        }
    }
}
