﻿using System;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            dataGridView1.DataSource = controller.listarClientesController();
        }
    }
}
