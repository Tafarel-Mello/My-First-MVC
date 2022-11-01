using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesDoTafa.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descricao do lanche deve ser informada")]
        [Display(Name = "Descricao do lanche")]
        [MinLength(20, ErrorMessage = "A descricao deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descricao nao pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descricao do lanche deve ser informada")]
        [Display(Name = "Descricao do lanche")]
        [MinLength(20, ErrorMessage = "A descricao deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descricao nao pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required]
        [Display(Name = "Preco")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preco deve estar entre R$1,00 e R$999,99 reais")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracter")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracter")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}