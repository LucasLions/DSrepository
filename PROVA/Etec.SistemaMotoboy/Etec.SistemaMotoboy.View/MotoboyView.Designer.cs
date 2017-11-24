namespace Etec.SistemaMotoboy.View
{
    partial class MotoboyView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtMotoboy = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMotoboy = new System.Windows.Forms.TextBox();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMotoboy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRgMotoboy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpfMotoboy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoMotoboy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtMotoboy)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMotoboy
            // 
            this.dtMotoboy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMotoboy.Location = new System.Drawing.Point(12, 259);
            this.dtMotoboy.Name = "dtMotoboy";
            this.dtMotoboy.Size = new System.Drawing.Size(560, 206);
            this.dtMotoboy.TabIndex = 0;
            this.dtMotoboy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMotoboy_CellDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(104, 218);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(238, 218);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(112, 35);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(371, 218);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Motoboy :";
            // 
            // txtIdMotoboy
            // 
            this.txtIdMotoboy.Enabled = false;
            this.txtIdMotoboy.Location = new System.Drawing.Point(173, 20);
            this.txtIdMotoboy.Name = "txtIdMotoboy";
            this.txtIdMotoboy.Size = new System.Drawing.Size(89, 20);
            this.txtIdMotoboy.TabIndex = 5;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(354, 20);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(108, 20);
            this.txtIdFuncionario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Funcionario :";
            // 
            // txtNomeMotoboy
            // 
            this.txtNomeMotoboy.Location = new System.Drawing.Point(173, 56);
            this.txtNomeMotoboy.Name = "txtNomeMotoboy";
            this.txtNomeMotoboy.Size = new System.Drawing.Size(289, 20);
            this.txtNomeMotoboy.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome: ";
            // 
            // txtRgMotoboy
            // 
            this.txtRgMotoboy.Location = new System.Drawing.Point(173, 95);
            this.txtRgMotoboy.Name = "txtRgMotoboy";
            this.txtRgMotoboy.Size = new System.Drawing.Size(121, 20);
            this.txtRgMotoboy.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RG: ";
            // 
            // txtCpfMotoboy
            // 
            this.txtCpfMotoboy.Location = new System.Drawing.Point(341, 95);
            this.txtCpfMotoboy.Name = "txtCpfMotoboy";
            this.txtCpfMotoboy.Size = new System.Drawing.Size(121, 20);
            this.txtCpfMotoboy.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF: ";
            // 
            // txtEnderecoMotoboy
            // 
            this.txtEnderecoMotoboy.Location = new System.Drawing.Point(173, 132);
            this.txtEnderecoMotoboy.Name = "txtEnderecoMotoboy";
            this.txtEnderecoMotoboy.Size = new System.Drawing.Size(289, 20);
            this.txtEnderecoMotoboy.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Endereço: ";
            // 
            // MotoboyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 474);
            this.Controls.Add(this.txtEnderecoMotoboy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCpfMotoboy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRgMotoboy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeMotoboy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMotoboy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtMotoboy);
            this.Name = "MotoboyView";
            this.Text = "MotoboyView";
            this.Load += new System.EventHandler(this.MotoboyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMotoboy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMotoboy;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMotoboy;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeMotoboy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRgMotoboy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpfMotoboy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoMotoboy;
        private System.Windows.Forms.Label label6;
    }
}