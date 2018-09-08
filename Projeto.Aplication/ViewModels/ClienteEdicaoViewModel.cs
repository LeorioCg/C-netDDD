using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Aplication.ViewModels
{
    public class ClienteEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1}")]
        public virtual string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Insira um email válido")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public virtual string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public virtual DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int IdPlano { get; set; }
    }
}
