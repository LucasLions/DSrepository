using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Etec.SistemaMotoboy.Controller;
using Etec.SistemaMotoboy.CLASS;

namespace Etec.SistemaMotoboy.View
{
    public partial class MotoboyView : Form
    {
        private List<MotoboyClass> listaMemoria = new List<MotoboyClass>();
        public MotoboyView()
        {
            InitializeComponent();
        }

        private void MotoboyView_Load(object sender, EventArgs e)
        {
            MotoboyController controller = new MotoboyController();
            listaMemoria = controller.listarMotoboy();
            dtMotoboy.DataSource = listaMemoria;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MotoboyClass classe = new MotoboyClass();
            classe.idMotoboy = int.Parse(txtIdMotoboy.Text);
            classe.nomeMotoboy = txtNomeMotoboy.Text;

            MotoboyController controller = new MotoboyController();
            controller.atualizarMotoboy(classe);

            dtMotoboy.DataSource = controller.listarMotoboy();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            MotoboyClass classe = new MotoboyClass();
            classe.idFuncionario = int.Parse(txtIdFuncionario.Text);
            classe.nomeMotoboy = txtNomeMotoboy.Text;
            classe.rgMotoboy = txtRgMotoboy.Text;
            classe.cpfMotoboy = txtCpfMotoboy.Text;
            classe.endMotoboy = txtEnderecoMotoboy.Text;

            MotoboyController controller = new MotoboyController();
            controller.inserirMotoboy(classe);

            dtMotoboy.DataSource = controller.listarMotoboy();
        }

        private void dtMotoboy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMotoboy.Text = dtMotoboy.Rows[e.RowIndex].Cells["idMotoboy"].Value.ToString();
            txtIdFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["idFuncionario"].Value.ToString();
            txtNomeMotoboy.Text = dtMotoboy.Rows[e.RowIndex].Cells["nomeMotoboy"].Value.ToString();
            txtRgMotoboy.Text = dtMotoboy.Rows[e.RowIndex].Cells["rgMotoboy"].Value.ToString();
            txtCpfMotoboy.Text = dtMotoboy.Rows[e.RowIndex].Cells["cpfMotoboy"].Value.ToString();
            txtEnderecoMotoboy.Text = dtMotoboy.Rows[e.RowIndex].Cells["endMotoboy"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MotoboyController controller = new MotoboyController();
            controller.excluirMotoboy(int.Parse(txtIdMotoboy.Text));

            dtMotoboy.DataSource = controller.listarMotoboy();
        }



        
    }
}
