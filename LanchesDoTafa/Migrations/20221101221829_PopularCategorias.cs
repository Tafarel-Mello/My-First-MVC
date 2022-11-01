using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesDoTafa.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao)" +
                "VALUES ('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao)" +
                 "VALUES ('Natural', 'Lanche feito com ingredientes naturais e organicos')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao)" +
                 "VALUES ('Sobremesa', 'Sobremesas caseiras')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao)" +
                "VALUES ('Bebidas', 'Sucos, refrigerantes, agua, cervejas')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorais");
        }
    }
}
