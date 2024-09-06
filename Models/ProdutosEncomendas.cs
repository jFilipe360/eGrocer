using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace eGrocer.Models
{
    public class ProdutosEncomendas
    {
        public ProdutosEncomendas()
        {
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Quantidade de produtos por encomenda.
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar a quantidade.")]
        public int Quantidade { get; set; }

        /// <summary>
        /// Preço dos produtos por encomenda
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar o preço.")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        /// <summary>
        /// FK do produto
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar o produto.")]
        [ForeignKey(nameof(Produto))]
        public int ProdutoFK { get; set; }
        public Produtos Produto { get; set; }

        /// <summary>
        /// FK da encomenda
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar a encomenda.")]
        [ForeignKey(nameof(Encomenda))]
        public int EncomendaFK { get; set; }
        public Encomendas Encomenda { get; set; }
    }
}
