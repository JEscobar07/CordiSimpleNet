using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CordiSimpleNet.Migrations
{
    /// <inheritdoc />
    public partial class CreatedSeederWithBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password", "role_id" },
                values: new object[,]
                {
                    { 1, "Mabel_Hansen13@gmail.com", "Rosalinda Cruickshank", "haoeieie", 2 },
                    { 2, "Gage.Ward82@gmail.com", "Katharina Jones", "wiouooea", 2 },
                    { 3, "Lempi.Toy28@yahoo.com", "Dillon Volkman", "geieeioa", 2 },
                    { 4, "Toby_Abernathy@yahoo.com", "Elda Morissette", "diaueuoo", 2 },
                    { 5, "Herminio.Kunde@gmail.com", "Kirstin Gusikowski", "weiouiae", 2 }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "id", "event_id", "status", "user_id" },
                values: new object[,]
                {
                    { 1, 1, false, 2 },
                    { 2, 5, true, 5 },
                    { 3, 3, true, 2 },
                    { 4, 2, true, 5 },
                    { 5, 7, false, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
