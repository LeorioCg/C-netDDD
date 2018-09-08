using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.ViewModels
{
    public class ClienteConsultaViewModel
    {
        
        public int IdCliente { get; set; }        
        public virtual string Nome { get; set; }        
        public virtual string Email { get; set; }       
        public virtual DateTime DataNascimento { get; set; }        
        public int IdPlano { get; set; }
        public string Descricao { get; set; }

    }
}
