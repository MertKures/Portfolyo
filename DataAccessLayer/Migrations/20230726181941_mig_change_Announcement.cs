using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_change_Announcement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Announcements");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Announcements");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Announcements",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
