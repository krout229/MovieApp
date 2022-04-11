using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "movieDetails",
                columns: new[] { "MovieId", "Director", "MovieGenre", "MovieName", "Price" },
                values: new object[] { 1, "Ari Aster", "Horror", "Heriditary", 150 });

            migrationBuilder.InsertData(
                table: "movieDetails",
                columns: new[] { "MovieId", "Director", "MovieGenre", "MovieName", "Price" },
                values: new object[] { 2, "Ari Aster", "Horror", "Midsommar", 250 });

            migrationBuilder.InsertData(
                table: "movieDetails",
                columns: new[] { "MovieId", "Director", "MovieGenre", "MovieName", "Price" },
                values: new object[] { 3, "Lin-Manuel Miranda", "Horror", "Tick,Tick...Boom!", 350 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movieDetails",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movieDetails",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movieDetails",
                keyColumn: "MovieId",
                keyValue: 3);
        }
    }
}
