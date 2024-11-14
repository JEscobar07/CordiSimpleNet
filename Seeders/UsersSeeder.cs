using System;
using System.Collections.Generic;
using Bogus;
using CordiSimpleNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Seeders
{
    public class UsersSeeder
    {
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var users = GenerateUsers(amount);
            modelBuilder.Entity<User>().HasData(users);
        }

        public static IEnumerable<User> GenerateUsers(int count)
        {
            var faker = new Faker<User>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.Name, f => f.Name.FullName()) // Nombre completo
                .RuleFor(u => u.Email, f => f.Internet.Email()) // Email válido
                .RuleFor(u => u.Password, f => f.Internet.Password(8, true)) // Contraseña aleatoria
                .RuleFor(u => u.Role_id, f => 2); // Role_id fijo en 2

            return faker.Generate(count);
        }
    }
}
