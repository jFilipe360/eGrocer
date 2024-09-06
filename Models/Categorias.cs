using System.ComponentModel.DataAnnotations;

namespace eGrocer.Models
{
    public class Categorias
    {
        public Categorias()
        {
            ListaCategorias = new HashSet<Produtos>();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Designação do produto
        /// </summary>
        [Required(ErrorMessage = "É obrigatório atribuir designação à categoria.")]
        [StringLength(30, ErrorMessage = "O nome não pode ter mais de {1} carateres.")]
        [Display(Name = "Desiganação")]
        public string Designacao { get; set; }

        public ICollection<Produtos> ListaCategorias { get; set; }
    }
}
