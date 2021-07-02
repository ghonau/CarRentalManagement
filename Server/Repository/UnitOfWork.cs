using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
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
        private UserManager<ApplicationUser> _userManager; 

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager; 
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
            
            //var user = httpCotext.User.Identity.Name; 
            
            var userId = httpCotext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId); 

            foreach(var entry in entries)
            {
                var entity = ((BaseDomainModel)entry.Entity);                 
                entity.DateUpdated = DateTime.Now;
                entity.UpdatedBy = user.UserName; 

                if (entry.State == EntityState.Added)
                {
                    entity.DateCreated = DateTime.Now;
                    entity.CreatedBy = user.UserName; 
                }
            }

                
            await _context.SaveChangesAsync();
        }
    }
}
