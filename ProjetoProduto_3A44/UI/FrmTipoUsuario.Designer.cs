namespace ProjetoProduto_3A44
{
    partial class FrmTipoUsuario
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
            this.btn_gravar = new System.Windows.Forms.Button();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(8, 95);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(144, 30);
            this.btn_gravar.TabIndex = 9;
            this.btn_gravar.Text = "GRAVAR";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(69, 69);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(233, 20);
            this.txt_descricao.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(108, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(194, 20);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(5, 72);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 13);
            this.lbl_descricao.TabIndex = 6;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(5, 42);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(97, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID Tipo de usuário:";
            // 
            // gridFornecedor
            // 
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Location = new System.Drawing.Point(308, 8);
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.Size = new System.Drawing.Size(314, 150);
            this.gridFornecedor.TabIndex = 16;
            this.gridFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellClick);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(82, 131);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_limpar.TabIndex = 34;
            this.btn_limpar.Text = "LIMPAR DADOS";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(158, 95);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(144, 30);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // FrmTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 170);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.gridFornecedor);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmTipoUsuario";
            this.Text = "Manter Tipos de Usuário";
            this.Load += new System.EventHandler(this.FrmTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
    }
}