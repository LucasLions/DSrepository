using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Etec.SistemaMotoboy.CLASS;

namespace Etec.SistemaMotoboy.Model
{
    public class ClienteModel
    {
        private string conexaoBd = ConnectionFactory.conexaoBancoDados;
        SqlConnection conexaoServidor;

        // SELECT
        public List<ClienteClass> listarCliente()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCliente", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<ClienteClass> cliente = new List<ClienteClass>();

            while (rs.Read())
            {
                ClienteClass mtb = new ClienteClass(int.Parse(rs["idCliente"].ToString()),
                                                    rs["nomeCliente"].ToString(),
                                                    rs["telCliente"].ToString(),
                                                    rs["rgCliente"].ToString(),
                                                    rs["cpfCliente"].ToString(),
                                                    rs["endCliente"].ToString());
                cliente.Add(mtb);
            }
            conexaoServidor.Close();
            return cliente;
        }

        // INSERT
        public void inserirCliente(ClienteClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tblCliente (nomeCliente,telCliente,rgCliente,cpfCliente,endCliente) VALUES ('" + classe.nomeCliente + "','" + classe.telCliente + "','" + classe.rgCliente + "','" + classe.cpfCliente + "','" + classe.endCliente + "') ", conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // UPDATE
        public void atualizarCliente(ClienteClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("UPDATE tblCliente set nomeCliente ='" + classe.nomeCliente + "', telCliente ='" + classe.telCliente + "', rgCliente ='" + classe.rgCliente + "', cpfCliente ='" + classe.cpfCliente + "', endCliente ='" + classe.endCliente + "' WHERE idCliente =" + classe.idCliente, conexaoServidor);
            comando.ExecuteNonQuery();

            conexaoServidor.Close();
        }


        // DELETE
        public void excluirCliente(int idClinete)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM tblCliente WHERE idCliente =" + idClinete, conexaoServidor);
            comando.ExecuteNonQuery();

            conexaoServidor.Close();
        }

    }
}
