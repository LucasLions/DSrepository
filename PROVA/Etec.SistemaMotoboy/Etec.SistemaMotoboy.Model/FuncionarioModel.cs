using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Etec.SistemaMotoboy.CLASS;

namespace Etec.SistemaMotoboy.Model
{
    public class FuncionarioModel
    {
        private string conexaoBd = ConnectionFactory.conexaoBancoDados;
        SqlConnection conexaoServidor;

        // SELECT
        public List<FuncionarioClass> listarFuncionario()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblFuncionario", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<FuncionarioClass> func = new List<FuncionarioClass>();

            while (rs.Read())
            {
                FuncionarioClass mtb = new FuncionarioClass(int.Parse(rs["idFuncionario"].ToString()),
                                                    int.Parse(rs["idEntrega"].ToString()),
                                                    rs["nomeFuncionario"].ToString(),
                                                    rs["rgFuncionario"].ToString(),
                                                    rs["cpfFuncionario"].ToString(),
                                                    rs["endFuncionario"].ToString(),
                                                    float.Parse(rs["salarioFuncionario"].ToString()));
                func.Add(mtb);
            }
            conexaoServidor.Close();
            return func;
        }

        // INSERT
        public void inserirFuncionario(FuncionarioClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tblFuncionario (idEntrega,nomeFuncionario,rgFuncionario,cpfFuncionario,endFuncionario,salarioFuncionario) VALUES ('" + classe.idEntrega + "','" + classe.nomeFuncionario + "','" + classe.rgFuncionario + "','" + classe.cpfFuncionario + "','" + classe.endFuncionario + "','" + classe.salarioFuncionario + "') ", conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // UPDATE
        public void atualizarFuncionario(FuncionarioClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("UPDATE tblFuncionario set nomeFuncionario ='" + classe.nomeFuncionario + "', rgFuncionario ='" + classe.rgFuncionario + "', cpfFuncionario ='" + classe.cpfFuncionario + "', endFuncionario ='" + classe.endFuncionario + "', salarioFuncionario ='" + classe.salarioFuncionario + "' WHERE idFuncionario =" + classe.idFuncionario, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // DELETE
        public void excluirFuncionario(int idFuncionario)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM tblFuncionario WHERE idCliente =" + idFuncionario, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }

    }
}
