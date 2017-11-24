using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.concessionaria.CLASS
{
    public class Cliente
    {
        public int codCliente { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public float renda { get; set; }

        public Cliente(int id, string nome, string rg, string cpf, string end, float renda) {
            this.codCliente = id;
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.endereco = end;
            this.renda = renda;
        }
    }
}
