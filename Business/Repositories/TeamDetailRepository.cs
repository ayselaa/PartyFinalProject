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
    public class TeamDetailRepository : ITeamDetailService
    {
        private readonly AppDbContext _context;

        public TeamDetailRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(TeamDetail entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);

            await _context.TeamDetails.AddAsync(entity);
        }

        public async Task Delete(int? id)
        {
            var data = await Get(id);

            data.IsDeleted = true;
        }

        public async Task<TeamDetail> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.TeamDetails.Where(n => !n.IsDeleted).Where(n => n.Id == id).Include(n => n.Team).FirstOrDefaultAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }

        public async Task<List<TeamDetail>> GetAll()
        {
            var data = await _context.TeamDetails.Where(n => !n.IsDeleted).Include(n => n.Team).ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            return data;
        }

        public async Task Update(int id, TeamDetail entity)
        {

            var data = await Get(id);

            if (data is null)
            {
                throw new EntityIsNullException();
            }

            data.Title = entity.Title;
            data.Address = entity.Address;
            data.Email = entity.Email;
            data.Job = entity.Job;
            data.Number = entity.Number;
            data.UpdatedDate = DateTime.UtcNow.AddHours(4);
            _context.TeamDetails.Update(data);
        }
    }
}
