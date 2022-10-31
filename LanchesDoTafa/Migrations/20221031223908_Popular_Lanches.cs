using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesDoTafa.Migrations
{
    public partial class Popular_Lanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Name, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, DataDeCriacao, CategoriaId)" +
                " VALUES('Dog especial', 'Dog especial artesanal' ,'Delicioso pao brioche com molho caseiro, salsicha artesanal, milho e ervilha, tomate e cebola picadinhas com queijo ralado', 7.50, 'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\hot-dog-vege-all-dressed.jpg', 'C:\\Users\\Tafarel\\Documents\\Portfolio\\Repositorios GitHub Pessoal\\My-First-MVC\\LanchesDoTafa\\My-First-MVC\\LanchesDoTafa\\wwwroot\\images\\hot-dog-vege-all-dressed.jpg'," +
                "1, 1, '30/10/2022', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
