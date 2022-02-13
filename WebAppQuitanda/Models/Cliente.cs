using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppQuitanda.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O {0} campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ser de no máximo {1} caracteres. ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo deve conter uma data válida")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O {0} campo é obrigatório")]
        [MaxLength(11)]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser de 11 dígitos numéricos")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O {0} campo é obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "O campo {0} deve conter um endereço de e-mail valido.")]
        public string Email { get; set; }

    }
}
