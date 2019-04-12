using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesCourse.Migrations
{
    public partial class Credits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Credits",
                table: "Course",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Credits",
                table: "Course");
        }
    }
}
