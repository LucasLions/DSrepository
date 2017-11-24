using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Etec.concessionaria.controller;

namespace Etec.concessionaria.view
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            dataGridView1.DataSource = controller.listarFuncionarioController();
        }
    }
}
