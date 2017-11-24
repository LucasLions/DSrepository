using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Etec.SistemaMotoboy.CLASS;
using Etec.SistemaMotoboy.Controller;

namespace Etec.SistemaMotoboy.View
{
    public partial class EntregaView : Form
    {
        private List<EntregaClass> listaMemoria = new List<EntregaClass>();
        public EntregaView()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EntregaClass classe = new EntregaClass();
            classe.idMotoboy = int.Parse(txtIdMotoboy.Text);
            classe.especificacao = txtEspecificacao.Text;
            classe.recebedor = txtRecebedor.Text;
            classe.endEntrega = txtEntrega.Text;
            classe.dtEntrega = txtDtEntrega.Text;

            EntregaController controller = new EntregaController();
            controller.inserirEntrega(classe);

            dtEntrega.DataSource = controller.listarEntrega();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            EntregaClass classe = new EntregaClass();
            classe.idEntrega = int.Parse(txtEntrega.Text);

            EntregaController controller = new EntregaController();
            controller.atualizarEntrega(classe);

            dtEntrega.DataSource = controller.listarEntrega();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EntregaController controller = new EntregaController();
            controller.excluirEntrega(int.Parse(txtEntrega.Text));
            dtEntrega.DataSource = controller.listarEntrega();
        }

        private void EntregaView_Load(object sender, EventArgs e)
        {
            EntregaController controller = new EntregaController();
            listaMemoria = controller.listarEntrega();
            dtEntrega.DataSource = listaMemoria;
        }

        private void dtEntrega_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEntrega.Text = dtEntrega.Rows[e.RowIndex].Cells["idEntrega"].Value.ToString();
            txtIdMotoboy.Text = dtEntrega.Rows[e.RowIndex].Cells["idMotoboy"].Value.ToString();
            txtEspecificacao.Text = dtEntrega.Rows[e.RowIndex].Cells["especificacao"].Value.ToString();
            txtRecebedor.Text = dtEntrega.Rows[e.RowIndex].Cells["recebedor"].Value.ToString();
            txtEndereco.Text = dtEntrega.Rows[e.RowIndex].Cells["endEntrega"].Value.ToString();
            txtDtEntrega.Text = dtEntrega.Rows[e.RowIndex].Cells["dtEntrega"].Value.ToString();
            
        }
    }
}
