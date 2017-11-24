using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Etec.SistemaMotoboy.CLASS;
using System.Data.SqlClient;

namespace Etec.SistemaMotoboy.Model
{
    public class MotoboyModel
    {

        private string conexaoBd = ConnectionFactory.conexaoBancoDados;
        SqlConnection conexaoServidor;

        // SELECT
        public List<MotoboyClass> listarMotoboy() {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblMotoboy", conexaoServidor);
            SqlDataReader rs = cmd.ExecuteReader();

            List<MotoboyClass> motoboy = new List<MotoboyClass>();

            while (rs.Read()) {
                MotoboyClass mtb = new MotoboyClass(int.Parse(rs["idMotoboy"].ToString()),
                                                    int.Parse(rs["idFuncionario"].ToString()),
                                                    rs["nomeMotoboy"].ToString(),
                                                    rs["rgMotoboy"].ToString(),
                                                    rs["cpfMotoboy"].ToString(),
                                                    rs["endMotoboy"].ToString());
                motoboy.Add(mtb);  
            }
            conexaoServidor.Close();
            return motoboy;
        }





        // INSERT
        public void inserirMotoboy(MotoboyClass classe) {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO tblMotoboy (idFuncionario,nomeMotoboy,rgMotoboy,cpfMotoboy,endMotoboy) VALUES ('" + classe.idFuncionario + "','" + classe.nomeMotoboy + "','" + classe.rgMotoboy + "','" + classe.cpfMotoboy + "','" + classe.endMotoboy + "') ", conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // UPDATE
        public void atualizarMotoboy(MotoboyClass classe)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("UPDATE tblMotoboy set nomeMotoboy ='" + classe.nomeMotoboy + "',rgMotoboy ='" + classe.rgMotoboy + "',cpfMotoboy ='" + classe.cpfMotoboy + "',endMotoboy ='" + classe.endMotoboy + "' WHERE idMotoboy =" + classe.idMotoboy, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }


        // DELETE
        public void excluirMotoboy(int idMotoboy)
        {
            conexaoServidor = new SqlConnection(conexaoBd);
            conexaoServidor.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM tblMotoboy WHERE idMotoboy =" + idMotoboy, conexaoServidor);
            comando.ExecuteNonQuery();
            conexaoServidor.Close();
        }

    }
}
