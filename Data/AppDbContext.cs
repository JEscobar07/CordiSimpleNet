using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Data
{
    public class AppDbContext : DbContext
    {

        DbSet<Rol> Roles {get; set;}
        DbSet<User> Users {get; set;}
        DbSet<Event> Events {get; set;}
        DbSet<Reservation> Reservations {get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
    }
}