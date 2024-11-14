
using CordiSimpleNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Seeders
{
    public class RolesSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    Id = 1,
                    Name = "Usuario Administrador",
                    Description = "Permite usar endpoint con jwt"
                },
                new Rol
                {
                    Id = 2,
                    Name = "Usuario General",
                    Description = "Permite usar endpoints que NO tengan jwt"
                }
            );
        }
    }
}