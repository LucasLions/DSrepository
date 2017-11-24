using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Etec.concessionaria.CLASS;

namespace Etec.concessionaria.model
{
    public class VeiculoModel
    {
        private string conexaoBd = "User ID=sa;Initial Catalog=Concessionaria;Data Source=LAB-08-04;Password=info211";
        SqlConnection conexaoServidor;

        public List<Veiculo> listarVeiculos()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblveiculos", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<Veiculo> veiculos = new List<Veiculo>();

            while (rs.Read())
            {
                Veiculo v = new Veiculo(int.Parse(rs["idVeiculo"].ToString()),
                                        rs["nomeVeiculo"].ToString(),
                                        rs["marca"].ToString(),
                                        int.Parse(rs["ano"].ToString()),
                                        float.Parse(rs["ValoVeiculo"].ToString()),
                                        float.Parse(rs["ValoVenda"].ToString())
                                        );

                veiculos.Add(v);
            }

            conexaoServidor.Close();
            return veiculos;            
        }

        public void inserirVeiculo(int id, string nome, string marca, int ano, float valP, float valV)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();

            conexaoServidor.Close();
        }
    }
}
