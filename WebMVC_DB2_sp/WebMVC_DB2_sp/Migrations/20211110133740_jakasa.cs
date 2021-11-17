using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC_DB2_sp.Migrations
{
    public partial class jakasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Type_TypeId1",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_TypeId1",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "TypeId1",
                table: "Animal");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Animal",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animal_TypeId",
                table: "Animal",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Type_TypeId",
                table: "Animal",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Type_TypeId",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_TypeId",
                table: "Animal");

            migrationBuilder.AlterColumn<string>(
                name: "TypeId",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId1",
                table: "Animal",
                type: "int",
                nullable: true);

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
    }
}
