using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entities
{
    public class Plano
    {
        public virtual int IdPlano { get; set; }
        public virtual string Descricao { get; set; }

        public virtual List<Cliente> Clientes { get; set; }

    }
}
