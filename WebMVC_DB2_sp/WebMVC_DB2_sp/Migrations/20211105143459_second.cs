using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC_DB2_sp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId1",
                table: "Animal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrCage = table.Column<int>(type: "int", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TypeId1",
                table: "Animal",
                column: "TypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Type_TypeId1",
                table: "Animal",
                column: "TypeId1",
                principalTable: "Type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Type_TypeId1",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Animal_TypeId1",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "TypeId1",
                table: "Animal");
        }
    }
}
