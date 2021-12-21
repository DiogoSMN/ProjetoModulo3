using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace avds.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {

        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Informe seu nome completo.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe E-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe seu CPF.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe seu Telefone.")]
        public string Telefone { get; set; }
    }

}
