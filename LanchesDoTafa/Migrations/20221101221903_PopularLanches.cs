using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesDoTafa.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, " +
               "Nome, Preco) VALUES(1, 'Pao, hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pao de hamburguer com ovo frito, presunto e quijo de primeira qualidade com batata palha', 1, 'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel11.jpg'," +
               "'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel11.jpg', 0, 'Xis Batatinha', 10.50M)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, " +
                "Nome, Preco) VALUES(1, 'Pao, hamburguer, ovo, presunto, queijo, tomate, alface, milho e ervilhas', 'Delicioso lanche super completo', 1, 'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel12.jpg'," +
                "'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel12.jpg', 0, 'Xis Salada', 12.50M)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, " +
                "Nome, Preco) VALUES(2, 'Pao integral, hamburguer de frango, queijo, tomate, alface e molho verde', 'Delicioso lanche com pao integral e frango, para uma refeicao leve', 1, 'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel13.jpg'," +
                "'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\carousel13.jpg', 1, 'Xis Saude', 13.50M)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
