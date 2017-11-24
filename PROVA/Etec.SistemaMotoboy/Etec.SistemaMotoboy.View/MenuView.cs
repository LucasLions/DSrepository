using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Etec.SistemaMotoboy.View
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteView cli = new ClienteView();
            cli.Show();    
            
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncionarioView func = new FuncionarioView();
            func.Show();
        }

        private void motoBoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotoboyView moto = new MotoboyView();
            moto.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntregaView entrega = new EntregaView();
            entrega.Show();
        }
    }
}
