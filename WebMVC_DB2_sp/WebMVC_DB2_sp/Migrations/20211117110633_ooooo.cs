using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC_DB2_sp.Migrations
{
    public partial class ooooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Type",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Type");
        }
    }
}
