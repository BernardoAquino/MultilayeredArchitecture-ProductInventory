namespace ProjetoProduto_3A44
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemTipos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuItemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemTipos,
            this.MnuItemCategorias,
            this.MnuItemFornecedores,
            this.MnuItemClientes,
            this.MnuItemProdutos});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // MnuItemTipos
            // 
            this.MnuItemTipos.Name = "MnuItemTipos";
            this.MnuItemTipos.Size = new System.Drawing.Size(180, 22);
            this.MnuItemTipos.Text = "Tipos de Usuários";
            this.MnuItemTipos.Click += new System.EventHandler(this.MnuItemTipos_Click);
            // 
            // MnuItemCategorias
            // 
            this.MnuItemCategorias.Name = "MnuItemCategorias";
            this.MnuItemCategorias.Size = new System.Drawing.Size(180, 22);
            this.MnuItemCategorias.Text = "Categorias";
            this.MnuItemCategorias.Click += new System.EventHandler(this.MnuItemCategorias_Click);
            // 
            // MnuItemFornecedores
            // 
            this.MnuItemFornecedores.Name = "MnuItemFornecedores";
            this.MnuItemFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MnuItemFornecedores.Text = "Fornecedores";
            this.MnuItemFornecedores.Click += new System.EventHandler(this.MnuItemFornecedores_Click);
            // 
            // MnuItemClientes
            // 
            this.MnuItemClientes.Name = "MnuItemClientes";
            this.MnuItemClientes.Size = new System.Drawing.Size(180, 22);
            this.MnuItemClientes.Text = "Clientes";
            this.MnuItemClientes.Click += new System.EventHandler(this.MnuItemClientes_Click);
            // 
            // MnuItemProdutos
            // 
            this.MnuItemProdutos.Name = "MnuItemProdutos";
            this.MnuItemProdutos.Size = new System.Drawing.Size(180, 22);
            this.MnuItemProdutos.Text = "Produtos";
            this.MnuItemProdutos.Click += new System.EventHandler(this.MnuItemProdutos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuItemTipos;
        private System.Windows.Forms.ToolStripMenuItem MnuItemCategorias;
        private System.Windows.Forms.ToolStripMenuItem MnuItemFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MnuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuItemProdutos;
    }
}