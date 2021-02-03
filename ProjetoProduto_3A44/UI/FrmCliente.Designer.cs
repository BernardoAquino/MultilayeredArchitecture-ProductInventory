namespace ProjetoProduto_3A44
{
    partial class FrmCliente
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
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_email = new System.Windows.Forms.RadioButton();
            this.rdb_telefone = new System.Windows.Forms.RadioButton();
            this.rdb_endereco = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grp_pesquisa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(78, 340);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_limpar.TabIndex = 30;
            this.btn_limpar.Text = "LIMPAR DADOS";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(156, 304);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(144, 30);
            this.btn_excluir.TabIndex = 28;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(310, 86);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(568, 356);
            this.gridCliente.TabIndex = 27;
            this.gridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellClick);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(71, 134);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 20);
            this.txt_telefone.TabIndex = 26;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(7, 137);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefone.TabIndex = 25;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(71, 76);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(233, 20);
            this.txt_endereco.TabIndex = 24;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(7, 79);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "Endereço:";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(6, 304);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(144, 30);
            this.btn_gravar.TabIndex = 22;
            this.btn_gravar.Text = "INSERIR";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(71, 45);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 20);
            this.txt_nome.TabIndex = 21;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(82, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(222, 20);
            this.txt_id.TabIndex = 20;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(7, 48);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(7, 18);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(71, 13);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "ID do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "UF:";
            // 
            // cbx_uf
            // 
            this.cbx_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Items.AddRange(new object[] {
            "MG",
            "SP",
            "RJ",
            "ES",
            "RS",
            "PR",
            "SC",
            "BA",
            "PA",
            "AM",
            "AC",
            "MT",
            "MS",
            "GO",
            "DF",
            "PE",
            "TO",
            "RR",
            "RO",
            "RN"});
            this.cbx_uf.Location = new System.Drawing.Point(71, 107);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(121, 21);
            this.cbx_uf.TabIndex = 32;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(71, 164);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(233, 20);
            this.txt_email.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "E-mail:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(71, 194);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(233, 20);
            this.txt_senha.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Senha:";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Location = new System.Drawing.Point(101, 219);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(121, 21);
            this.cbx_tipo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = " Tipo de Usuário:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_pesquisa);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Location = new System.Drawing.Point(310, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 68);
            this.panel1.TabIndex = 39;
            // 
            // rdb_email
            // 
            this.rdb_email.AutoSize = true;
            this.rdb_email.Location = new System.Drawing.Point(94, 32);
            this.rdb_email.Name = "rdb_email";
            this.rdb_email.Size = new System.Drawing.Size(53, 17);
            this.rdb_email.TabIndex = 5;
            this.rdb_email.TabStop = true;
            this.rdb_email.Text = "E-mail";
            this.rdb_email.UseVisualStyleBackColor = true;
            // 
            // rdb_telefone
            // 
            this.rdb_telefone.AutoSize = true;
            this.rdb_telefone.Location = new System.Drawing.Point(3, 31);
            this.rdb_telefone.Name = "rdb_telefone";
            this.rdb_telefone.Size = new System.Drawing.Size(67, 17);
            this.rdb_telefone.TabIndex = 4;
            this.rdb_telefone.TabStop = true;
            this.rdb_telefone.Text = "Telefone";
            this.rdb_telefone.UseVisualStyleBackColor = true;
            // 
            // rdb_endereco
            // 
            this.rdb_endereco.AutoSize = true;
            this.rdb_endereco.Location = new System.Drawing.Point(94, 9);
            this.rdb_endereco.Name = "rdb_endereco";
            this.rdb_endereco.Size = new System.Drawing.Size(71, 17);
            this.rdb_endereco.TabIndex = 3;
            this.rdb_endereco.TabStop = true;
            this.rdb_endereco.Text = "Endereço";
            this.rdb_endereco.UseVisualStyleBackColor = true;
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(3, 8);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(53, 17);
            this.rdb_nome.TabIndex = 2;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(186, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(365, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // grp_pesquisa
            // 
            this.grp_pesquisa.Controls.Add(this.rdb_email);
            this.grp_pesquisa.Controls.Add(this.rdb_telefone);
            this.grp_pesquisa.Controls.Add(this.rdb_nome);
            this.grp_pesquisa.Controls.Add(this.rdb_endereco);
            this.grp_pesquisa.Location = new System.Drawing.Point(15, 6);
            this.grp_pesquisa.Name = "grp_pesquisa";
            this.grp_pesquisa.Size = new System.Drawing.Size(165, 54);
            this.grp_pesquisa.TabIndex = 40;
            this.grp_pesquisa.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_uf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_pesquisa.ResumeLayout(false);
            this.grp_pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdb_email;
        private System.Windows.Forms.RadioButton rdb_telefone;
        private System.Windows.Forms.RadioButton rdb_endereco;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.GroupBox grp_pesquisa;
    }
}