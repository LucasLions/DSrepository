using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.SistemaMotoboy.CLASS
{
    public class FuncionarioClass
    {
        public int idFuncionario { get; set; }
        public int idEntrega { get; set; }
        public string nomeFuncionario { get; set; }
        public string rgFuncionario { get; set; }
        public string cpfFuncionario { get; set; }
        public string endFuncionario { get; set; }
        public float salarioFuncionario { get; set; }


        public FuncionarioClass() { 
        
        }

        public FuncionarioClass(int idFuncionario, int idEntrega, string nomeFuncionario, string rgFuncionario, string cpfFuncionario, string endFuncionario,float salarioFuncionario)
        {
            this.idFuncionario = idFuncionario;
            this.idEntrega = idEntrega;
            this.nomeFuncionario = nomeFuncionario;
            this.rgFuncionario = rgFuncionario;
            this.cpfFuncionario = cpfFuncionario;
            this.endFuncionario = endFuncionario;
            this.salarioFuncionario = salarioFuncionario;

        }

    }
}
