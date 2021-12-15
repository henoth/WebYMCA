using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebYMCA.Data.Migrations
{
    public partial class cos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "YMCA",
                newName: "Wzrost");

            migrationBuilder.RenameColumn(
                name: "Waist",
                table: "YMCA",
                newName: "Waga");

            migrationBuilder.RenameColumn(
                name: "IsMale",
                table: "YMCA",
                newName: "Man");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "YMCA",
                newName: "Dane");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wzrost",
                table: "YMCA",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "Waga",
                table: "YMCA",
                newName: "Waist");

            migrationBuilder.RenameColumn(
                name: "Man",
                table: "YMCA",
                newName: "IsMale");

            migrationBuilder.RenameColumn(
                name: "Dane",
                table: "YMCA",
                newName: "Date");
        }
    }
}
