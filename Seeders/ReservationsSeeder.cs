using Bogus;
using CordiSimpleNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Seeders
{
    public class ReservationsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder, int amount)
        {
            var reservations = GenerateReservations(amount);
            modelBuilder.Entity<Reservation>().HasData(reservations);
        }

        public static IEnumerable<Reservation> GenerateReservations(int count)
        {
            var faker = new Faker<Reservation>()
                .RuleFor(r => r.Id, f => f.IndexFaker + 1)
                .RuleFor(r => r.Status, f => f.Random.Bool()) // Generar un valor aleatorio para 'Status'
                .RuleFor(r => r.User_id, f => f.PickRandom(1, 2, 3, 4, 5)) // Los 5 usuarios existentes (asegúrate que estos IDs existan)
                .RuleFor(r => r.Event_id, f => f.PickRandom(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); // Los 10 eventos existentes

            return faker.Generate(count);
        }
    }
}
