using CordiSimpleNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CordiSimpleNet.Seeders
{
    public class EventsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1, // Asignación explícita de Id
                    Name = "festival de música",
                    Description = "un festival de música al aire libre con artistas nacionales e internacionales.",
                    Date_start = DateTime.Parse("2024-11-10 12:00:00"),
                    Date_end = DateTime.Parse("2024-11-10 23:59:00"),
                    Location = "parque simón bolívar, bogotá",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 2, // Asignación explícita de Id
                    Name = "feria del libro",
                    Description = "encuentro literario con escritores y editoriales locales.",
                    Date_start = DateTime.Parse("2024-10-25 09:00:00"),
                    Date_end = DateTime.Parse("2024-10-29 18:00:00"),
                    Location = "plaza mayor, medellín",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 3, // Asignación explícita de Id
                    Name = "expo tecnología",
                    Description = "exposición de avances tecnológicos y nuevas innovaciones.",
                    Date_start = DateTime.Parse("2024-12-01 10:00:00"),
                    Date_end = DateTime.Parse("2024-12-01 18:00:00"),
                    Location = "corferias, bogotá",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 4, // Asignación explícita de Id
                    Name = "exposición de arte moderno",
                    Description = "exposición de obras de arte contemporáneo de artistas colombianos.",
                    Date_start = DateTime.Parse("2024-11-20 11:00:00"),
                    Date_end = DateTime.Parse("2024-11-20 20:00:00"),
                    Location = "museo de arte moderno, cartagena",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = false
                },
                new Event
                {
                    Id = 5, // Asignación explícita de Id
                    Name = "concierto de navidad",
                    Description = "concierto navideño con coros y orquestas locales.",
                    Date_start = DateTime.Parse("2024-12-15 19:00:00"),
                    Date_end = DateTime.Parse("2024-12-15 21:00:00"),
                    Location = "teatro metropolitano, medellín",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 6, // Asignación explícita de Id
                    Name = "festival de cine",
                    Description = "proyección de películas y charlas con cineastas colombianos.",
                    Date_start = DateTime.Parse("2024-10-30 14:00:00"),
                    Date_end = DateTime.Parse("2024-11-02 22:00:00"),
                    Location = "cine colombia, cali",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 7, // Asignación explícita de Id
                    Name = "congreso de medicina",
                    Description = "encuentro de profesionales de la salud con charlas y talleres.",
                    Date_start = DateTime.Parse("2024-11-05 08:00:00"),
                    Date_end = DateTime.Parse("2024-11-07 17:00:00"),
                    Location = "hotel hilton, cartagena",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 8, // Asignación explícita de Id
                    Name = "expo gastronómica",
                    Description = "muestra de la gastronomía colombiana con degustaciones y talleres.",
                    Date_start = DateTime.Parse("2024-12-10 10:00:00"),
                    Date_end = DateTime.Parse("2024-12-12 19:00:00"),
                    Location = "centro de convenciones, cali",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = false
                },
                new Event
                {
                    Id = 9, // Asignación explícita de Id
                    Name = "festival de danza folclórica",
                    Description = "presentaciones de grupos de danza folclórica de diferentes regiones.",
                    Date_start = DateTime.Parse("2024-11-18 15:00:00"),
                    Date_end = DateTime.Parse("2024-11-18 19:00:00"),
                    Location = "plaza mayor, medellín",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                },
                new Event
                {
                    Id = 10, // Asignación explícita de Id
                    Name = "carrera 10k",
                    Description = "competencia de atletismo en diferentes categorías.",
                    Date_start = DateTime.Parse("2024-12-20 07:00:00"),
                    Date_end = DateTime.Parse("2024-12-20 12:00:00"),
                    Location = "parque simón bolívar, bogotá",
                    Max_slots = 250,
                    Occupied_slots = 0,
                    Status = true
                }
            );
        }
    }
}
