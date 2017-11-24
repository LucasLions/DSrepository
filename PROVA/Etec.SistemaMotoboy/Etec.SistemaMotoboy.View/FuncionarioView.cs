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
    public partial class FuncionarioView : Form
    {
        private List<FuncionarioClass> listaMemoria = new List<FuncionarioClass>();
        public FuncionarioView()
        {
            InitializeComponent();
        }

        private void FuncionarioView_Load(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();
            listaMemoria = controller.listarFuncionario();
            dtMotoboy.DataSource = listaMemoria;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FuncionarioClass classe = new FuncionarioClass();
            classe.idEntrega = int.Parse(txtIdEntrega.Text);
            classe.nomeFuncionario = txtNomeFuncionario.Text;

            FuncionarioController controller = new FuncionarioController();
            controller.atualizarFuncionario(classe);

            dtMotoboy.DataSource = controller.listarFuncionario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FuncionarioClass classe = new FuncionarioClass();
            classe.idEntrega = int.Parse(txtIdEntrega.Text);
            classe.nomeFuncionario = txtNomeFuncionario.Text;
            classe.rgFuncionario = txtRgFuncionario.Text;
            classe.cpfFuncionario = txtCpfFuncionario.Text;
            classe.endFuncionario = txtEnderecoFuncionario.Text;
            classe.salarioFuncionario = float.Parse(txtSalario.Text);

            FuncionarioController controller = new FuncionarioController();
            controller.inserirFuncionario(classe);

            dtMotoboy.DataSource = controller.listarFuncionario();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();
            controller.excluirFuncionario(int.Parse(txtFuncionario.Text));

            dtMotoboy.DataSource = controller.listarFuncionario();
        }

        private void dtMotoboy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["idFuncionario"].Value.ToString();
            txtIdEntrega.Text = dtMotoboy.Rows[e.RowIndex].Cells["idEntrega"].Value.ToString();
            txtNomeFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["nomeFuncionario"].Value.ToString();
            txtRgFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["rgFuncionario"].Value.ToString();
            txtCpfFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["cpfFuncionario"].Value.ToString();
            txtEnderecoFuncionario.Text = dtMotoboy.Rows[e.RowIndex].Cells["endFuncionario"].Value.ToString();
        }
    }
}
