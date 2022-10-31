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
    public class CommentRepository : ICommentService
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Comment entity)
        {
            entity.CreatedDate = DateTime.UtcNow.AddHours(4);
            await _context.Comments.AddAsync(entity);
            await _context.SaveChangesAsync();
        }



        public async Task Delete(int? id)
        {
            var data = await Get(id);
            data.IsDeleted = true;
            await _context.SaveChangesAsync();
        }



        public async Task<Comment> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            var data = await _context.Comments.Where(n => n.Id == id && !n.IsDeleted)
                                                             .Include(n => n.AppUser)
                                                             .FirstOrDefaultAsync();
            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }



        public async Task<List<Comment>> GetAll()
        {
            var data = await _context.Comments.Where(n => !n.IsDeleted)
                                                                        .Include(n => n.AppUser)
                                                                        .ToListAsync();

            if (data is null)
            {
                throw new EntityIsNullException();
            }
            return data;
        }

        public Task Update(int id, Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
