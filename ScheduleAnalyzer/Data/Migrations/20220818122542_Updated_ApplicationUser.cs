using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScheduleAnalyzer.Data.Migrations
{
    public partial class Updated_ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UserMustChangePassword",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserMustChangePassword",
                table: "AspNetUsers");
        }
    }
}
