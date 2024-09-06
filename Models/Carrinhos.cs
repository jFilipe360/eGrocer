using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eGrocer.Models
{
    public class Carrinhos
    {
        public Carrinhos()
        {
            ListaCarrinhoProduto = new HashSet<CarrinhosProdutos>();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Preço total
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar o preço total.")]
        [Display(Name = "Preço Total")]
        public double Total { get; set; }

        /// <summary>
        /// FK dos utilizadores
        /// </summary>
        [Required(ErrorMessage = "É obrigatório indicar o utilizador.")]
        [ForeignKey(nameof(Utilizador))]
        public int UtilizadorFK { get; set; }
        public Utilizadores Utilizador { get; set; }

        public ICollection<CarrinhosProdutos> ListaCarrinhoProduto { get; set; }
    }
}
