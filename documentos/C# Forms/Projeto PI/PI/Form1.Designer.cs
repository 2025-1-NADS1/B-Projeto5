namespace PI
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.TituloLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtSair = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 319);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 32);
            this.textBox2.TabIndex = 2;
            // 
            // BtEntrar
            // 
            this.BtEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtEntrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtEntrar.Location = new System.Drawing.Point(58, 368);
            this.BtEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(270, 55);
            this.BtEntrar.TabIndex = 3;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = false;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click_1);
            // 
            // TituloLogin
            // 
            this.TituloLogin.AutoSize = true;
            this.TituloLogin.BackColor = System.Drawing.Color.Transparent;
            this.TituloLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TituloLogin.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLogin.Location = new System.Drawing.Point(191, 68);
            this.TituloLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TituloLogin.Name = "TituloLogin";
            this.TituloLogin.Size = new System.Drawing.Size(315, 91);
            this.TituloLogin.TabIndex = 4;
            this.TituloLogin.Text = "LOGIN";
            this.TituloLogin.Click += new System.EventHandler(this.TituloLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(70, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(70, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(29, 447);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Esqueci senha";
            // 
            // BtSair
            // 
            this.BtSair.AutoSize = true;
            this.BtSair.BackColor = System.Drawing.SystemColors.Menu;
            this.BtSair.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BtSair.Location = new System.Drawing.Point(311, 447);
            this.BtSair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(43, 23);
            this.BtSair.TabIndex = 8;
            this.BtSair.Text = "Sair";
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 232);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 32);
            this.textBox3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PI.Properties.Resources.thumbnail_;
            this.pictureBox1.Location = new System.Drawing.Point(383, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(923, 531);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BtSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TituloLogin);
            this.Controls.Add(this.BtEntrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Label TituloLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BtSair;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

