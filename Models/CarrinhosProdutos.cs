using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eGrocer.Models
{
    public class CarrinhosProdutos
    {
        public CarrinhosProdutos()
        {
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Quantidade de produtos no carrinho
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar a quantidade.")]
        public int Quantidade { get; set; }

        /// <summary>
        /// Preço dos produtos no carrinho
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar o preço.")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        /// <summary>
        /// FK do produto
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [ForeignKey(nameof(Produto))]
        public int ProdutoFK { get; set; }
        public Produtos Produto { get; set; }

        /// <summary>
        /// FK da encomenda
        /// </summary>
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [ForeignKey(nameof(Carrinho))]
        public int CarrinhoFK { get; set; }
        public Carrinhos Carrinho { get; set; }
    }
}
