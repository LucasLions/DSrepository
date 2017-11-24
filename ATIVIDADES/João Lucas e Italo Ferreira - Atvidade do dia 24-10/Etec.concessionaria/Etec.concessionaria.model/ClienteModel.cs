using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Etec.concessionaria.CLASS;

namespace Etec.concessionaria.model
{
    public class ClienteModel
    {
        private string conexaoBd = "User ID=sa;Initial Catalog=Concessionaria;Data Source=LAB-08-04;Password=info211";
        SqlConnection conexaoServidor;

        public List<Cliente> listarClientes()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCliente", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<Cliente> clientes = new List<Cliente>();

            while (rs.Read())
            {
                Cliente v = new Cliente(int.Parse(rs["idCliente"].ToString()),
                                        rs["nome"].ToString(),
                                        rs["rg"].ToString(),
                                        rs["cpf"].ToString(),
                                        rs["endereco"].ToString(),
                                        float.Parse(rs["renda"].ToString())
                                        );

                clientes.Add(v);
            }

            conexaoServidor.Close();
            return clientes;
        }

        public void inserirCliente(int id, string nome, string rg, string cpf, string end, float renda)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();

            conexaoServidor.Close();
        }
    }
}
