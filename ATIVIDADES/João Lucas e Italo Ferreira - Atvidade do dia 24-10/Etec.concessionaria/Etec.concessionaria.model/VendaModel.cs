using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Etec.concessionaria.CLASS;

namespace Etec.concessionaria.model
{
    public class VendaModel
    {
        private string conexaoBd = "User ID=sa;Initial Catalog=Concessionaria;Data Source=LAB-08-04;Password=info211";
        SqlConnection conexaoServidor;
        
        public List<Venda> listarVendas()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM tblVenda", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<Venda> vendas = new List<Venda>();

            while (rs.Read())
            {
                Venda v = new Venda();
                v.codVenda = int.Parse(rs["idVenda"].ToString());
                v.codCliente = int.Parse(rs["idCliente"].ToString());
                v.codFunc = int.Parse(rs["idFuncionario"].ToString());
                v.valVendido = float.Parse(rs["ValorVenda"].ToString());
                v.descVenda = float.Parse(rs["desconto"].ToString());

                vendas.Add(v);
            }

            conexaoServidor.Close();
            return vendas;
        }

        public void inserirVenda(int codVenda, int codFunc, int codCli, float valVenda, float valDesc)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();

            conexaoServidor.Close();
        }
    }
}
