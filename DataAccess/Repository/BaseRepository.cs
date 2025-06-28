using DataAccess.DBContext;
using DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;


        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual async Task<T> AddAysnc(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
          
        }

        Task IBaseRepository<T>.DeleteAysnc(T entity)
        {
            _dbSet.Remove(entity);
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAllAysnc()=> await _dbSet.ToListAsync();
       

        public virtual async Task<T> GetAysncById(int id) => await _dbSet.FindAsync(id);
      

        public virtual async Task UpdateAysnc(T entity)
        {
          _dbSet.Entry(entity).State = EntityState.Modified;
           await _context.SaveChangesAsync();

        }
    }
}
