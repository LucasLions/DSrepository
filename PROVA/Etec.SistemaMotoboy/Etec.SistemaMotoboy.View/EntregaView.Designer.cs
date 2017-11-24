namespace Etec.SistemaMotoboy.View
{
    partial class EntregaView
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDtEntrega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecebedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMotoboy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtEntrega = new System.Windows.Forms.DataGridView();
            this.txtEspecificacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(228, 173);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(338, 20);
            this.txtEndereco.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Endereço: ";
            // 
            // txtDtEntrega
            // 
            this.txtDtEntrega.Location = new System.Drawing.Point(445, 136);
            this.txtDtEntrega.Name = "txtDtEntrega";
            this.txtDtEntrega.Size = new System.Drawing.Size(121, 20);
            this.txtDtEntrega.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Data de Entrega: ";
            // 
            // txtRecebedor
            // 
            this.txtRecebedor.Location = new System.Drawing.Point(228, 136);
            this.txtRecebedor.Name = "txtRecebedor";
            this.txtRecebedor.Size = new System.Drawing.Size(121, 20);
            this.txtRecebedor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Recebedor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Especificação: ";
            // 
            // txtIdMotoboy
            // 
            this.txtIdMotoboy.Location = new System.Drawing.Point(458, 27);
            this.txtIdMotoboy.Name = "txtIdMotoboy";
            this.txtIdMotoboy.Size = new System.Drawing.Size(108, 20);
            this.txtIdMotoboy.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Motoboy:  ";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Enabled = false;
            this.txtEntrega.Location = new System.Drawing.Point(228, 27);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(89, 20);
            this.txtEntrega.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Entrega: ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(426, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(293, 225);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(112, 35);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(159, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtEntrega
            // 
            this.dtEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEntrega.Location = new System.Drawing.Point(67, 266);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(560, 206);
            this.dtEntrega.TabIndex = 16;
            this.dtEntrega.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEntrega_CellDoubleClick);
            // 
            // txtEspecificacao
            // 
            this.txtEspecificacao.Location = new System.Drawing.Point(228, 53);
            this.txtEspecificacao.Multiline = true;
            this.txtEspecificacao.Name = "txtEspecificacao";
            this.txtEspecificacao.Size = new System.Drawing.Size(338, 67);
            this.txtEspecificacao.TabIndex = 25;
            // 
            // EntregaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 499);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDtEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRecebedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEspecificacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMotoboy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtEntrega);
            this.Name = "EntregaView";
            this.Text = "EntregaView";
            this.Load += new System.EventHandler(this.EntregaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDtEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecebedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMotoboy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtEntrega;
        private System.Windows.Forms.TextBox txtEspecificacao;

    }
}