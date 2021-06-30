using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>(); 
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _db.AnyAsync(expression); 
        }

        public async Task Delete(int id)
        {
            var record = await _db.FindAsync(id);
            _db.Remove(record); 
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities); 
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            foreach (var include in includes ?? Enumerable.Empty<string>())
            {
                query.Include(include);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            
            if (expression != null)
                query = _db.Where(expression); 

            foreach(var include in includes?? Enumerable.Empty<string>())
            {
               query =  query.Include(include); 
            }

            if(orderBy != null)
            {
                query = orderBy(query); 
            }

            var result =  await query.AsNoTracking().ToListAsync();
            return result; 
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity); 
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities); 
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
