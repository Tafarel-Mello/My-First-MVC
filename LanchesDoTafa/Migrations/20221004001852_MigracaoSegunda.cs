using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesDoTafa.Migrations
{
    public partial class MigracaoSegunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId1",
                table: "Lanches");

            migrationBuilder.DropIndex(
                name: "IX_Lanches_CategoriaId1",
                table: "Lanches");

            migrationBuilder.DropColumn(
                name: "CategoriaId1",
                table: "Lanches");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Lanches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId",
                table: "Lanches");

            migrationBuilder.DropIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Lanches");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId1",
                table: "Lanches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId1",
                table: "Lanches",
                column: "CategoriaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Categorias_CategoriaId1",
                table: "Lanches",
                column: "CategoriaId1",
                principalTable: "Categorias",
                principalColumn: "CategoriaId");
        }
    }
}
