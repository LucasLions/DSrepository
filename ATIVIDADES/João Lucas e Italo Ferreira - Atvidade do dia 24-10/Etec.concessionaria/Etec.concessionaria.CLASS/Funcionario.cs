using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.concessionaria.CLASS
{
    public class Funcionario
    {
        public int codFunc { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public float salario { get; set; }

        public Funcionario(int id, string n, string rg, string cpf, string end, float sal) {
            this.codFunc = id;
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.endereco = end;
            this.salario = sal;
        }
    }
}
