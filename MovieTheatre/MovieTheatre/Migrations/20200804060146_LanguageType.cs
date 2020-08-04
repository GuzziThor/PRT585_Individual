using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieTheatre.Migrations
{
    public partial class LanguageType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "LanguageType",
                table: "Movies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageType",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
