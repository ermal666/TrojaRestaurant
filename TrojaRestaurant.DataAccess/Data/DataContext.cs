﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrojaRestaurant.Models;
using TrojaRestaurant.Models.Models;

namespace TrojaRestaurant.DataAccess
{
    public class DataContext : IdentityDbContext
    {
        public DataContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DataContext(DbContextOptions options) : base(options) {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }    
        public object SingleOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
 