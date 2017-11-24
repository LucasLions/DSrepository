using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.SistemaMotoboy.CLASS
{
    public class EntregaClass
    {

        public int idEntrega { get; set; }
        public int idMotoboy { get; set; }
        public string especificacao { get; set; }        
        public string recebedor { get; set; }
        public string endEntrega{get;set;}
        public string dtEntrega { get; set; }


        public EntregaClass() { 
        
        }

        public EntregaClass(int idEntrega, int idMotoboy, string especificacao, string recebedor, string endEntrega, string dtEntrega)
        {
            this.idEntrega = idEntrega;
            this.idMotoboy = idMotoboy;
            this.especificacao = especificacao;
            this.recebedor = recebedor;
            this.endEntrega = endEntrega;
            this.dtEntrega = dtEntrega;

        }
    }
}
