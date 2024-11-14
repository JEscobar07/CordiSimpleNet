using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;
using CordiSimpleNet.Seeders;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Rol> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RolesSeeder.Seed(modelBuilder);
            EventsSeeder.Seed(modelBuilder);
            UsersSeeder.Seed(modelBuilder,5);
            ReservationsSeeder.Seed(modelBuilder,5);
        }

    }
}