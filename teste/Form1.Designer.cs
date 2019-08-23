namespace teste
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtEmailContato = new System.Windows.Forms.TextBox();
            this.mtxtNumeroContato = new System.Windows.Forms.MaskedTextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 12);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome..";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(388, 12);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(83, 20);
            this.dtp.TabIndex = 1;
            this.dtp.Value = new System.DateTime(1999, 8, 22, 0, 0, 0, 0);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(12, 12);
            this.mtxtCPF.Mask = "999.999.999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(86, 20);
            this.mtxtCPF.TabIndex = 3;
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Location = new System.Drawing.Point(12, 64);
            this.mtxtCEP.Mask = "99999-999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(61, 20);
            this.mtxtCEP.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(79, 64);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(392, 20);
            this.txtLogradouro.TabIndex = 6;
            this.txtLogradouro.Text = "Logradouro..";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(12, 90);
            this.mtxtNumero.Mask = "00000";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(39, 20);
            this.mtxtNumero.TabIndex = 7;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(57, 90);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(99, 20);
            this.txtComplemento.TabIndex = 8;
            this.txtComplemento.Text = "Complemento..";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(162, 90);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(124, 20);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.Text = "Bairro..";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(292, 90);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(143, 20);
            this.txtLocalidade.TabIndex = 10;
            this.txtLocalidade.Text = "Localidade...";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(441, 90);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(30, 20);
            this.txtUF.TabIndex = 11;
            this.txtUF.Text = "UF";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(12, 116);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(459, 41);
            this.txtObservacoes.TabIndex = 13;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 192);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(459, 117);
            this.dataGridView2.TabIndex = 16;
            // 
            // txtEmailContato
            // 
            this.txtEmailContato.Location = new System.Drawing.Point(104, 38);
            this.txtEmailContato.Name = "txtEmailContato";
            this.txtEmailContato.Size = new System.Drawing.Size(367, 20);
            this.txtEmailContato.TabIndex = 18;
            this.txtEmailContato.Text = "email@example.com";
            // 
            // mtxtNumeroContato
            // 
            this.mtxtNumeroContato.Location = new System.Drawing.Point(12, 38);
            this.mtxtNumeroContato.Mask = "(99) 9 9999-9999";
            this.mtxtNumeroContato.Name = "mtxtNumeroContato";
            this.mtxtNumeroContato.Size = new System.Drawing.Size(86, 20);
            this.mtxtNumeroContato.TabIndex = 19;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(234, 163);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 20;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.onClickInserir);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(315, 163);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(396, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.mtxtNumeroContato);
            this.Controls.Add(this.txtEmailContato);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.mtxtNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.mtxtCEP);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtEmailContato;
        private System.Windows.Forms.MaskedTextBox mtxtNumeroContato;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

