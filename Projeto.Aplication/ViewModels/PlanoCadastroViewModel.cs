using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Aplication.ViewModels
{
    public class PlanoCadastroViewModel
    {
        [Required(ErrorMessage ="Campo Obrigatório")]
        [MinLength(6, ErrorMessage ="Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage ="Informe no máximo {1} caracteres.")]
        public string Descricao { get; set; }
    }
}
