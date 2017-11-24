using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Etec.concessionaria.CLASS;

namespace Etec.concessionaria.model
{
    public class FuncionarioModel
    {
        private string conexaoBd = "User ID=sa;Initial Catalog=Concessionaria;Data Source=LAB-08-04;Password=info211";
        SqlConnection conexaoServidor;

        public List<Funcionario> listarFuncionarios()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblFuncionario", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<Funcionario> funcionarios = new List<Funcionario>();

            while (rs.Read())
            {
                Funcionario v = new Funcionario(int.Parse(rs["idFuncionario"].ToString()),
                                                rs["nome"].ToString(),
                                                rs["rg"].ToString(),
                                                rs["cpf"].ToString(),
                                                rs["endereco"].ToString(),
                                                float.Parse(rs["salario"].ToString())
                                                ); 

                funcionarios.Add(v);
            }

            conexaoServidor.Close();
            return funcionarios;
        }

        public void inserirFuncionario(int id, string n, string rg, string cpf, string end, float sal)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();



            conexaoServidor.Close();
        }
    }
}
