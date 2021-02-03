namespace ProjetoProduto_3A44
{
    partial class FrmCategoria
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.gridCategoria = new System.Windows.Forms.DataGridView();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(8, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(69, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID Categoria:";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(8, 62);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(58, 13);
            this.lbl_descricao.TabIndex = 1;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(83, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(222, 20);
            this.txt_id.TabIndex = 2;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(72, 59);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(233, 20);
            this.txt_descricao.TabIndex = 3;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(11, 85);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(144, 30);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "GRAVAR";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // gridCategoria
            // 
            this.gridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategoria.Location = new System.Drawing.Point(311, 12);
            this.gridCategoria.Name = "gridCategoria";
            this.gridCategoria.Size = new System.Drawing.Size(314, 150);
            this.gridCategoria.TabIndex = 15;
            this.gridCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategoria_CellClick_1);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(161, 85);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_limpar.TabIndex = 32;
            this.btn_limpar.Text = "LIMPAR DADOS";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(83, 118);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(144, 30);
            this.btn_excluir.TabIndex = 31;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 171);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.gridCategoria);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Categoria :.";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.DataGridView gridCategoria;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
    }
}