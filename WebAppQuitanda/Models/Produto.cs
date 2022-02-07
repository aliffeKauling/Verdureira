using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebAppQuitanda.Models
{
    public class Produto
    {
        [Key]
        public int IdProdto { get; set; }

        [Required(ErrorMessage = "Ocampo {0} é obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Ocampo {0} é obrigatório")]
        [MaxLength(1000)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Ocampo {0} é obrigatório")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Ocampo {0} é obrigatório")]
        public int Estoque { get; set; }
    }
}
