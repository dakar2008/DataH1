using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleAnalyzer.Data.Migrations
{
    public partial class Updated_ApplicationUser3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NormalizedFirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedLastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormalizedFirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedLastName",
                table: "AspNetUsers");
        }
    }
}
