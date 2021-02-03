namespace ProjetoProduto_3A44
{
    partial class FrmFornecedor
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(11, 125);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(144, 30);
            this.btn_gravar.TabIndex = 9;
            this.btn_gravar.Text = "INSERIR";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(72, 38);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(83, 8);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(222, 20);
            this.txt_id.TabIndex = 7;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 41);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(8, 11);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(78, 13);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "ID Fornecedor:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(72, 69);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(233, 20);
            this.txt_email.TabIndex = 11;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(8, 72);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(72, 99);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 20);
            this.txt_telefone.TabIndex = 13;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(8, 102);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefone.TabIndex = 12;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // gridFornecedor
            // 
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Location = new System.Drawing.Point(311, 5);
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.Size = new System.Drawing.Size(421, 186);
            this.gridFornecedor.TabIndex = 14;
            this.gridFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellClick);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(161, 125);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(144, 30);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(12, 161);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(144, 30);
            this.btn_alterar.TabIndex = 16;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(161, 161);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "LIMPAR DADOS";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 199);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.gridFornecedor);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmFornecedor";
            this.Text = "Manter Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_limpar;
    }
}