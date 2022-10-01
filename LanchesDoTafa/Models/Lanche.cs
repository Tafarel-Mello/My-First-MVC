using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesDoTafa.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    [Required(ErrorMessage ="O nome do lanche deve ser informado")]
    [Display(Name = "Nome do Lanche")]

    public string Name { get; set; }
    [Required(ErrorMessage = "A descricao do lanche deve ser informada")]
    [Display(Name = "Descricao do lanche")]
    [MinLength(20, ErrorMessage = "A descricao deve ter no minimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "A descricao nao pode exceder {1} caracteres")]

    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }
    public DateTime DataDeCriacao { get; set; }

    [NotMapped]
    public int CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; }
}



