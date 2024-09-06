using System.ComponentModel.DataAnnotations;

namespace eGrocer.Models
{
    public class Encomendas
    {
        public Encomendas()
        {
            ListaProdutoEncomenda = new HashSet<ProdutosEncomendas>();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Morada de destino da encomenda
        /// </summary>
        [Required(ErrorMessage = "É obrigatório preencher a morada.")]
        public string Morada { get; set; }

        /// <summary>
        /// Utilizador que fará a encomenda
        /// </summary>
        public int Utilizador { get; set; }

        /// <summary>
        /// Carrinho onde se encontra a lista de produtos para encomenda
        /// </summary>
        public int Carrinho { get; set; }

        public ICollection<ProdutosEncomendas> ListaProdutoEncomenda { get; set; }
    }
}
