using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Make> _makes;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Vehicle> _vehicles;
        private IGenericRepository<Booking> _bookings;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context; 
        }
        public IGenericRepository<Make> Makes => _makes ??= new GenericRepository<Make>(_context);
        public IGenericRepository<Color> Colors => _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this); 
        }

        public async Task Save(HttpContext httpCotext)
        {
            var entries = _context.ChangeTracker.Entries()
                .Where(entry => entry.State == EntityState.Added || entry.State == EntityState.Modified);
            foreach(var entry in entries)
            {
                var entity = ((BaseDomainModel)entry.Entity);                 
                entity.DateUpdated = DateTime.Now;
                entity.UpdatedBy = httpCotext.User.Identity.Name; 

                if (entry.State == EntityState.Added)
                {
                    entity.DateCreated = DateTime.Now;
                    entity.CreatedBy = httpCotext.User.Identity.Name; 
                }
            }

                
            await _context.SaveChangesAsync();
        }
    }
}
