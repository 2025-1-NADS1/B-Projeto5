namespace Cadastro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxSenha = new System.Windows.Forms.Label();
            this.TxConfirmarSenha = new System.Windows.Forms.Label();
            this.TxDtNasc = new System.Windows.Forms.Label();
            this.TxEmail = new System.Windows.Forms.Label();
            this.DtPnascimento = new System.Windows.Forms.DateTimePicker();
            this.Campoconfirmarsenha = new System.Windows.Forms.TextBox();
            this.Camposenha = new System.Windows.Forms.TextBox();
            this.Campoemail = new System.Windows.Forms.TextBox();
            this.Camponome = new System.Windows.Forms.TextBox();
            this.Btcancelar = new System.Windows.Forms.Button();
            this.Btsalvar = new System.Windows.Forms.Button();
            this.TxAvisodaSenha = new System.Windows.Forms.Label();
            this.TxValidarEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxNome
            // 
            this.TxNome.AutoSize = true;
            this.TxNome.Location = new System.Drawing.Point(206, 32);
            this.TxNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TxNome.Name = "TxNome";
            this.TxNome.Size = new System.Drawing.Size(77, 28);
            this.TxNome.TabIndex = 0;
            this.TxNome.Text = "Nome";
            this.TxNome.Click += new System.EventHandler(this.TxNome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 1;
            // 
            // TxSenha
            // 
            this.TxSenha.AutoSize = true;
            this.TxSenha.Location = new System.Drawing.Point(211, 186);
            this.TxSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TxSenha.Name = "TxSenha";
            this.TxSenha.Size = new System.Drawing.Size(82, 28);
            this.TxSenha.TabIndex = 2;
            this.TxSenha.Text = "Senha";
            this.TxSenha.Click += new System.EventHandler(this.TxSenha_Click);
            // 
            // TxConfirmarSenha
            // 
            this.TxConfirmarSenha.AutoSize = true;
            this.TxConfirmarSenha.Location = new System.Drawing.Point(211, 256);
            this.TxConfirmarSenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TxConfirmarSenha.Name = "TxConfirmarSenha";
            this.TxConfirmarSenha.Size = new System.Drawing.Size(205, 28);
            this.TxConfirmarSenha.TabIndex = 3;
            this.TxConfirmarSenha.Text = "Confirmar Senha";
            this.TxConfirmarSenha.Click += new System.EventHandler(this.TxConfirmarSenha_Click);
            // 
            // TxDtNasc
            // 
            this.TxDtNasc.AutoSize = true;
            this.TxDtNasc.Location = new System.Drawing.Point(205, 328);
            this.TxDtNasc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TxDtNasc.Name = "TxDtNasc";
            this.TxDtNasc.Size = new System.Drawing.Size(238, 28);
            this.TxDtNasc.TabIndex = 4;
            this.TxDtNasc.Text = "Data de Nascimento";
            this.TxDtNasc.Click += new System.EventHandler(this.TxDtNasc_Click);
            // 
            // TxEmail
            // 
            this.TxEmail.AutoSize = true;
            this.TxEmail.Location = new System.Drawing.Point(206, 102);
            this.TxEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(87, 28);
            this.TxEmail.TabIndex = 5;
            this.TxEmail.Text = "E-mail";
            this.TxEmail.Click += new System.EventHandler(this.TxEmail_Click);
            // 
            // DtPnascimento
            // 
            this.DtPnascimento.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPnascimento.Location = new System.Drawing.Point(184, 364);
            this.DtPnascimento.Name = "DtPnascimento";
            this.DtPnascimento.Size = new System.Drawing.Size(402, 27);
            this.DtPnascimento.TabIndex = 6;
            this.DtPnascimento.ValueChanged += new System.EventHandler(this.DtPnascimento_ValueChanged);
            // 
            // Campoconfirmarsenha
            // 
            this.Campoconfirmarsenha.Location = new System.Drawing.Point(211, 287);
            this.Campoconfirmarsenha.Name = "Campoconfirmarsenha";
            this.Campoconfirmarsenha.Size = new System.Drawing.Size(332, 36);
            this.Campoconfirmarsenha.TabIndex = 10;
            this.Campoconfirmarsenha.TextChanged += new System.EventHandler(this.Campoconfirmarsenha_TextChanged);
            // 
            // Camposenha
            // 
            this.Camposenha.Location = new System.Drawing.Point(210, 217);
            this.Camposenha.Name = "Camposenha";
            this.Camposenha.Size = new System.Drawing.Size(332, 36);
            this.Camposenha.TabIndex = 11;
            this.Camposenha.TextChanged += new System.EventHandler(this.Camposenha_TextChanged);
            this.Camposenha.Leave += new System.EventHandler(this.Camposenha_TextChanged);
            // 
            // Campoemail
            // 
            this.Campoemail.Location = new System.Drawing.Point(210, 137);
            this.Campoemail.Name = "Campoemail";
            this.Campoemail.Size = new System.Drawing.Size(332, 36);
            this.Campoemail.TabIndex = 12;
            this.Campoemail.TextChanged += new System.EventHandler(this.Campoemail_TextChanged);
            this.Campoemail.Leave += new System.EventHandler(this.Campoemail_TextChanged);
            // 
            // Camponome
            // 
            this.Camponome.Location = new System.Drawing.Point(210, 63);
            this.Camponome.Name = "Camponome";
            this.Camponome.Size = new System.Drawing.Size(332, 36);
            this.Camponome.TabIndex = 13;
            this.Camponome.TextChanged += new System.EventHandler(this.Camponome_TextChanged);
            // 
            // Btcancelar
            // 
            this.Btcancelar.Location = new System.Drawing.Point(99, 397);
            this.Btcancelar.Name = "Btcancelar";
            this.Btcancelar.Size = new System.Drawing.Size(258, 59);
            this.Btcancelar.TabIndex = 18;
            this.Btcancelar.Text = "Cancelar";
            this.Btcancelar.UseVisualStyleBackColor = true;
            this.Btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // Btsalvar
            // 
            this.Btsalvar.Location = new System.Drawing.Point(391, 397);
            this.Btsalvar.Name = "Btsalvar";
            this.Btsalvar.Size = new System.Drawing.Size(258, 59);
            this.Btsalvar.TabIndex = 20;
            this.Btsalvar.Text = "Salvar";
            this.Btsalvar.UseVisualStyleBackColor = true;
            this.Btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // TxAvisodaSenha
            // 
            this.TxAvisodaSenha.AutoSize = true;
            this.TxAvisodaSenha.BackColor = System.Drawing.SystemColors.Control;
            this.TxAvisodaSenha.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAvisodaSenha.ForeColor = System.Drawing.Color.Red;
            this.TxAvisodaSenha.Location = new System.Drawing.Point(12, 270);
            this.TxAvisodaSenha.Name = "TxAvisodaSenha";
            this.TxAvisodaSenha.Size = new System.Drawing.Size(0, 17);
            this.TxAvisodaSenha.TabIndex = 21;
            this.TxAvisodaSenha.Click += new System.EventHandler(this.TxAvisodaSenha_Click);
            // 
            // TxValidarEmail
            // 
            this.TxValidarEmail.AutoSize = true;
            this.TxValidarEmail.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxValidarEmail.Location = new System.Drawing.Point(315, 176);
            this.TxValidarEmail.Name = "TxValidarEmail";
            this.TxValidarEmail.Size = new System.Drawing.Size(12, 17);
            this.TxValidarEmail.TabIndex = 22;
            this.TxValidarEmail.Text = ".";
            this.TxValidarEmail.Click += new System.EventHandler(this.TxValidarEmail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1388, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 564);
            this.Controls.Add(this.TxValidarEmail);
            this.Controls.Add(this.TxAvisodaSenha);
            this.Controls.Add(this.Btsalvar);
            this.Controls.Add(this.Btcancelar);
            this.Controls.Add(this.Camponome);
            this.Controls.Add(this.Campoemail);
            this.Controls.Add(this.Camposenha);
            this.Controls.Add(this.Campoconfirmarsenha);
            this.Controls.Add(this.DtPnascimento);
            this.Controls.Add(this.TxEmail);
            this.Controls.Add(this.TxDtNasc);
            this.Controls.Add(this.TxConfirmarSenha);
            this.Controls.Add(this.TxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxNome);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxSenha;
        private System.Windows.Forms.Label TxConfirmarSenha;
        private System.Windows.Forms.Label TxDtNasc;
        private System.Windows.Forms.Label TxEmail;
        private System.Windows.Forms.DateTimePicker DtPnascimento;
        private System.Windows.Forms.TextBox Campoconfirmarsenha;
        private System.Windows.Forms.TextBox Camposenha;
        private System.Windows.Forms.TextBox Campoemail;
        private System.Windows.Forms.TextBox Camponome;
        private System.Windows.Forms.Button Btcancelar;
        private System.Windows.Forms.Button Btsalvar;
        private System.Windows.Forms.Label TxAvisodaSenha;
        private System.Windows.Forms.Label TxValidarEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

