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
    public partial class ClienteView : Form
    {
        private List<ClienteClass> listaMemoria = new List<ClienteClass>();

        public ClienteView()
        {
            InitializeComponent();
        }

        private void ClienteView_Load(object sender, EventArgs e)
        {
            ClienteController controller = new ClienteController();
            listaMemoria = controller.listarCliente();
            dtCliente.DataSource = listaMemoria;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteClass classe = new ClienteClass();
            classe.idCliente = int.Parse(txtIdCliente.Text);
            classe.nomeCliente = txtNomeCliente.Text;

            ClienteController controller = new ClienteController();
            controller.atualizarCliente(classe);

            dtCliente.DataSource = controller.listarCliente();
        }

        private void dtCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdCliente.Text = dtCliente.Rows[e.RowIndex].Cells["idCliente"].Value.ToString();
            txtNomeCliente.Text = dtCliente.Rows[e.RowIndex].Cells["nomeCliente"].Value.ToString();
            txtTelefone.Text = dtCliente.Rows[e.RowIndex].Cells["telCliente"].Value.ToString();
            txtRgCliente.Text = dtCliente.Rows[e.RowIndex].Cells["rgCliente"].Value.ToString();
            txtCpfCliente.Text = dtCliente.Rows[e.RowIndex].Cells["cpfCliente"].Value.ToString();
            txtEnderecoCliente.Text = dtCliente.Rows[e.RowIndex].Cells["endCliente"].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            ClienteClass classe = new ClienteClass();
            classe.nomeCliente = txtNomeCliente.Text;
            classe.telCliente = txtTelefone.Text;
            classe.rgCliente = txtRgCliente.Text;
            classe.cpfCliente = txtCpfCliente.Text;
            classe.endCliente = txtEnderecoCliente.Text;

            ClienteController controller = new ClienteController();
            controller.inserirCliente(classe);

            dtCliente.DataSource = controller.listarCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ClienteController controller = new ClienteController();
            controller.excluirCliente(int.Parse(txtIdCliente.Text));
            dtCliente.DataSource = controller.listarCliente();
        }

    }
}
