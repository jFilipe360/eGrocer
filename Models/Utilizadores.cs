using System.ComponentModel.DataAnnotations;

namespace eGrocer.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            ListaEncomendas = new HashSet<Encomendas>();
            ListaCarrinhos = new HashSet<Carrinhos>();
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Email do utilizador
        /// </summary>
        [Required(ErrorMessage = "É obrigatório preencher o email.")]
        public string Email { get; set; }


        /// <summary>
        /// Papel desempenhado pelo utilizador na plataforma
        /// </summary>
        [Required(ErrorMessage = "É obrigatório designar uma função.")]
        public string Funcao { get; set; }


        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [Required(ErrorMessage = "É obrigatório preencher o nome.")]
        [StringLength(50, ErrorMessage = "O nome não pode ter mais de {1} carateres.")]
        public string Nome { get; set; }

        public ICollection<Encomendas> ListaEncomendas { get; set; }
        public ICollection<Carrinhos> ListaCarrinhos { get; set; }
    }
}
