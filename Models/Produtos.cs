using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eGrocer.Models
{
    public class Produtos
    {
        public Produtos()
        {
            ListaProdutoEncomenda = new HashSet<ProdutosEncomendas>();
            ListaCarrinhosProdutos = new HashSet<CarrinhosProdutos>();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Designação do produto
        /// </summary>
        [Required(ErrorMessage = "É obrigatório preencher a designação do produto.")]
        [StringLength(30, ErrorMessage = "O nome não pode ter mais de {1} carateres.")]
        [Display(Name = "Designação")]
        public string Designacao { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Required(ErrorMessage = "É obrigatório preencher a descrição do produto.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        /// <summary>
        /// Imagem do produto
        /// </summary>
        [Required(ErrorMessage = "É obrigatório atribuir uma imagem ao produto.")]
        public string Imagem { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "É obrigatório atribuir um preço ao produto.")]
        public double Preco { get; set; }

        /// <summary>
        /// FK da categoria
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar a categoria.")]
        [ForeignKey(nameof(Categoria))]
        public int CategoriaFK { get; set; }
        public Categorias Categoria { get; set; }


        public ICollection<ProdutosEncomendas> ListaProdutoEncomenda { get; set; }
        public ICollection<CarrinhosProdutos> ListaCarrinhosProdutos { get; set; }
    }
}
