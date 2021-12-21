using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace avds.Models
{
    [Table ("Contatos")]
    public class Contatos
    {

        [Key]
        public int IdContatos { get; set; }

        [Required(ErrorMessage = "Informe seu nome completo.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe E-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Escreva um Mensagem.")]
        public string Msg { get; set; }
        
    }

}
