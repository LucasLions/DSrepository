using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Etec.concessionaria.CLASS
{
    public class Veiculo
    {
        public int codVeiculo { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int anoVeiculo { get; set; }
        public float valorPago { get; set; }
        public float valorVenda { get; set; }

        public Veiculo(int id, string nome, string marca, int ano, float valP, float valV)
        {
            this.codVeiculo = id;
            this.nome = nome;
            this.marca = marca;
            this.anoVeiculo = ano;
            this.valorPago = valorPago;
            this.valorVenda = valV;
        }
    }
}
