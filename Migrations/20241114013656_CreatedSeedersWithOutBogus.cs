using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CordiSimpleNet.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSeedersWithOutBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "id", "date_end", "date_start", "description", "location", "max_slots", "name", "occupied_slots", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "un festival de música al aire libre con artistas nacionales e internacionales.", "parque simón bolívar, bogotá", 250, "festival de música", 0, true },
                    { 2, new DateTime(2024, 10, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), "encuentro literario con escritores y editoriales locales.", "plaza mayor, medellín", 250, "feria del libro", 0, true },
                    { 3, new DateTime(2024, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "exposición de avances tecnológicos y nuevas innovaciones.", "corferias, bogotá", 250, "expo tecnología", 0, true },
                    { 4, new DateTime(2024, 11, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), "exposición de obras de arte contemporáneo de artistas colombianos.", "museo de arte moderno, cartagena", 250, "exposición de arte moderno", 0, false },
                    { 5, new DateTime(2024, 12, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), "concierto navideño con coros y orquestas locales.", "teatro metropolitano, medellín", 250, "concierto de navidad", 0, true },
                    { 6, new DateTime(2024, 11, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), "proyección de películas y charlas con cineastas colombianos.", "cine colombia, cali", 250, "festival de cine", 0, true },
                    { 7, new DateTime(2024, 11, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "encuentro de profesionales de la salud con charlas y talleres.", "hotel hilton, cartagena", 250, "congreso de medicina", 0, true },
                    { 8, new DateTime(2024, 12, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "muestra de la gastronomía colombiana con degustaciones y talleres.", "centro de convenciones, cali", 250, "expo gastronómica", 0, false },
                    { 9, new DateTime(2024, 11, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "presentaciones de grupos de danza folclórica de diferentes regiones.", "plaza mayor, medellín", 250, "festival de danza folclórica", 0, true },
                    { 10, new DateTime(2024, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), "competencia de atletismo en diferentes categorías.", "parque simón bolívar, bogotá", 250, "carrera 10k", 0, true }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Permite usar endpoint con jwt", "Usuario Administrador" },
                    { 2, "Permite usar endpoints que NO tengan jwt", "Usuario General" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
