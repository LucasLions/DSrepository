using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.SistemaMotoboy.CLASS
{
    public class ClienteClass
    {

        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public string telCliente { get; set; }
        public string rgCliente { get; set; }
        public string cpfCliente { get; set; }
        public string endCliente { get; set; }

        
        public ClienteClass() { 
        
        }

        public ClienteClass(int idCliente, string nomeCliente, string telCliente, string rgCliente, string cpfCliente, string endCliente)
        {
            this.idCliente = idCliente;
            this.nomeCliente = nomeCliente;
            this.telCliente = telCliente;
            this.rgCliente = rgCliente;
            this.cpfCliente = cpfCliente;
            this.endCliente = endCliente;

        }

    }
}
