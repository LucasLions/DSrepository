using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Etec.SistemaMotoboy.CLASS;

namespace Etec.SistemaMotoboy.Model
{
    public class EntregaModel
    {

        private string conexaoBd = ConnectionFactory.conexaoBancoDados;
        SqlConnection conexaoServidor;

        // SELECT
        public List<EntregaClass> listarEntrega()
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEntrega", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<EntregaClass> entrega = new List<EntregaClass>();

            while (rs.Read())
            {
                EntregaClass et = new EntregaClass(int.Parse(rs["idEntrega"].ToString()),
                                                    int.Parse(rs["idMotoboy"].ToString()),
                                                    rs["especificacao"].ToString(),
                                                    rs["recebedor"].ToString(),
                                                    rs["endEntrega"].ToString(),
                                                    rs["dtEntrega"].ToString());
                entrega.Add(et);
            }
            conexaoServidor.Close();
            return entrega;
        }

        // INSERT
        public void inserirEntrega(EntregaClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tblEntrega (idMotoboy,especificacao,recebedor,endEntrega,dtEntrega) VALUES ('" + classe.idMotoboy + "','" + classe.especificacao + "','" + classe.recebedor + "','" + classe.endEntrega + "','" + classe.dtEntrega + "') ", conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // UPDATE
        public void atualizarEntrega(EntregaClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("UPDATE tblEntrega set idMotoboy ='" + classe.idMotoboy + "', especificacao ='" + classe.especificacao + "', recebedor ='" + classe.recebedor + "', endEntrega ='" + classe.endEntrega + "', dtEntrega ='" + classe.dtEntrega + "' WHERE idEntrega =" + classe.idEntrega, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // DELETE
        public void excluirEntrega(int idEntrega)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM tblEntrega WHERE idEntrega =" + idEntrega, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }

    }
}
