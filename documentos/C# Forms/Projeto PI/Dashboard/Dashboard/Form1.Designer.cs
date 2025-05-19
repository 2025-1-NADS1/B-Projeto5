namespace Dashboard
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
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.Lbl_Saudacao = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Btn_Mensal = new System.Windows.Forms.Button();
            this.Btn_Consumo = new System.Windows.Forms.Button();
            this.Btn_Dia = new System.Windows.Forms.Button();
            this.LblMes = new System.Windows.Forms.Label();
            this.Lbl_ConsumoD = new System.Windows.Forms.Label();
            this.Lbl_Dia = new System.Windows.Forms.Label();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.LblMesAgua = new System.Windows.Forms.Label();
            this.LblAguaD = new System.Windows.Forms.Label();
            this.LblGastoDL = new System.Windows.Forms.Label();
            this.LblGastoMes = new System.Windows.Forms.Label();
            this.Lbl_AguaD = new System.Windows.Forms.Label();
            this.Lbl_AguaM = new System.Windows.Forms.Label();
            this.LblGastoDA = new System.Windows.Forms.Label();
            this.LblGastoA = new System.Windows.Forms.Label();
            this.Lbl_AG = new System.Windows.Forms.Label();
            this.Lbl_LG = new System.Windows.Forms.Label();
            this.Pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_Menu.Controls.Add(this.Btn_Menu);
            this.Pnl_Menu.Location = new System.Drawing.Point(-1, 0);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(129, 461);
            this.Pnl_Menu.TabIndex = 0;
            this.Pnl_Menu.UseWaitCursor = true;
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu.Image")));
            this.Btn_Menu.Location = new System.Drawing.Point(34, 12);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(60, 40);
            this.Btn_Menu.TabIndex = 0;
            this.Btn_Menu.UseVisualStyleBackColor = false;
            this.Btn_Menu.UseWaitCursor = true;
            // 
            // Lbl_Saudacao
            // 
            this.Lbl_Saudacao.AutoSize = true;
            this.Lbl_Saudacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Saudacao.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saudacao.Location = new System.Drawing.Point(281, 9);
            this.Lbl_Saudacao.Name = "Lbl_Saudacao";
            this.Lbl_Saudacao.Size = new System.Drawing.Size(149, 23);
            this.Lbl_Saudacao.TabIndex = 1;
            this.Lbl_Saudacao.Text = "Bem vindo, Usuário.";
            this.Lbl_Saudacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Saudacao.UseWaitCursor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(239, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.UseWaitCursor = true;
            // 
            // Btn_Mensal
            // 
            this.Btn_Mensal.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Mensal.Location = new System.Drawing.Point(156, 242);
            this.Btn_Mensal.Name = "Btn_Mensal";
            this.Btn_Mensal.Size = new System.Drawing.Size(102, 39);
            this.Btn_Mensal.TabIndex = 3;
            this.Btn_Mensal.Text = "Média Mensal";
            this.Btn_Mensal.UseVisualStyleBackColor = false;
            this.Btn_Mensal.UseWaitCursor = true;
            this.Btn_Mensal.Click += new System.EventHandler(this.Btn_Mensal_Click);
            // 
            // Btn_Consumo
            // 
            this.Btn_Consumo.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Consumo.Location = new System.Drawing.Point(450, 242);
            this.Btn_Consumo.Name = "Btn_Consumo";
            this.Btn_Consumo.Size = new System.Drawing.Size(102, 39);
            this.Btn_Consumo.TabIndex = 4;
            this.Btn_Consumo.Text = "Maior Consumo";
            this.Btn_Consumo.UseVisualStyleBackColor = false;
            this.Btn_Consumo.UseWaitCursor = true;
            this.Btn_Consumo.Click += new System.EventHandler(this.Btn_Consumo_Click);
            // 
            // Btn_Dia
            // 
            this.Btn_Dia.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Dia.Location = new System.Drawing.Point(302, 242);
            this.Btn_Dia.Name = "Btn_Dia";
            this.Btn_Dia.Size = new System.Drawing.Size(102, 39);
            this.Btn_Dia.TabIndex = 5;
            this.Btn_Dia.Text = "Média Diária";
            this.Btn_Dia.UseVisualStyleBackColor = false;
            this.Btn_Dia.UseWaitCursor = true;
            this.Btn_Dia.Click += new System.EventHandler(this.Btn_Dia_Click);
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMes.Location = new System.Drawing.Point(156, 284);
            this.LblMes.Name = "LblMes";
            this.LblMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMes.Size = new System.Drawing.Size(27, 16);
            this.LblMes.TabIndex = 6;
            this.LblMes.Text = "*****";
            this.LblMes.UseWaitCursor = true;
            this.LblMes.Click += new System.EventHandler(this.LblMes_Click);
            // 
            // Lbl_ConsumoD
            // 
            this.Lbl_ConsumoD.AutoSize = true;
            this.Lbl_ConsumoD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsumoD.Location = new System.Drawing.Point(450, 284);
            this.Lbl_ConsumoD.Name = "Lbl_ConsumoD";
            this.Lbl_ConsumoD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_ConsumoD.Size = new System.Drawing.Size(27, 16);
            this.Lbl_ConsumoD.TabIndex = 7;
            this.Lbl_ConsumoD.Text = "*****";
            this.Lbl_ConsumoD.UseWaitCursor = true;
            this.Lbl_ConsumoD.Click += new System.EventHandler(this.Lbl_ConsumoD_Click);
            // 
            // Lbl_Dia
            // 
            this.Lbl_Dia.AutoSize = true;
            this.Lbl_Dia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dia.Location = new System.Drawing.Point(302, 284);
            this.Lbl_Dia.Name = "Lbl_Dia";
            this.Lbl_Dia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Dia.Size = new System.Drawing.Size(27, 16);
            this.Lbl_Dia.TabIndex = 8;
            this.Lbl_Dia.Text = "*****";
            this.Lbl_Dia.UseWaitCursor = true;
            this.Lbl_Dia.Click += new System.EventHandler(this.Lbl_Dia_Click);
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(450, 300);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Mes.Size = new System.Drawing.Size(27, 16);
            this.Lbl_Mes.TabIndex = 9;
            this.Lbl_Mes.Text = "*****";
            this.Lbl_Mes.UseWaitCursor = true;
            this.Lbl_Mes.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn1
            // 
            this.Btn1.Image = global::Dashboard.Properties.Resources.BotãoOcultar;
            this.Btn1.Location = new System.Drawing.Point(156, 213);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(27, 21);
            this.Btn1.TabIndex = 10;
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.UseWaitCursor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Image = global::Dashboard.Properties.Resources.BotãoOcultar;
            this.Btn2.Location = new System.Drawing.Point(302, 215);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(27, 21);
            this.Btn2.TabIndex = 11;
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.UseWaitCursor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Image = global::Dashboard.Properties.Resources.BotãoOcultar;
            this.Btn3.Location = new System.Drawing.Point(450, 215);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(27, 21);
            this.Btn3.TabIndex = 12;
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.UseWaitCursor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // LblMesAgua
            // 
            this.LblMesAgua.AutoSize = true;
            this.LblMesAgua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesAgua.Location = new System.Drawing.Point(156, 300);
            this.LblMesAgua.Name = "LblMesAgua";
            this.LblMesAgua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblMesAgua.Size = new System.Drawing.Size(27, 16);
            this.LblMesAgua.TabIndex = 13;
            this.LblMesAgua.Text = "*****";
            this.LblMesAgua.UseWaitCursor = true;
            this.LblMesAgua.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAguaD
            // 
            this.LblAguaD.AutoSize = true;
            this.LblAguaD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAguaD.Location = new System.Drawing.Point(302, 300);
            this.LblAguaD.Name = "LblAguaD";
            this.LblAguaD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblAguaD.Size = new System.Drawing.Size(27, 16);
            this.LblAguaD.TabIndex = 14;
            this.LblAguaD.Text = "*****";
            this.LblAguaD.UseWaitCursor = true;
            this.LblAguaD.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblGastoDL
            // 
            this.LblGastoDL.AutoSize = true;
            this.LblGastoDL.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastoDL.Location = new System.Drawing.Point(302, 316);
            this.LblGastoDL.Name = "LblGastoDL";
            this.LblGastoDL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblGastoDL.Size = new System.Drawing.Size(27, 16);
            this.LblGastoDL.TabIndex = 15;
            this.LblGastoDL.Text = "*****";
            this.LblGastoDL.UseWaitCursor = true;
            this.LblGastoDL.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // LblGastoMes
            // 
            this.LblGastoMes.AutoSize = true;
            this.LblGastoMes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastoMes.Location = new System.Drawing.Point(156, 316);
            this.LblGastoMes.Name = "LblGastoMes";
            this.LblGastoMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblGastoMes.Size = new System.Drawing.Size(27, 16);
            this.LblGastoMes.TabIndex = 16;
            this.LblGastoMes.Text = "*****";
            this.LblGastoMes.UseWaitCursor = true;
            this.LblGastoMes.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_AguaD
            // 
            this.Lbl_AguaD.AutoSize = true;
            this.Lbl_AguaD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AguaD.Location = new System.Drawing.Point(450, 316);
            this.Lbl_AguaD.Name = "Lbl_AguaD";
            this.Lbl_AguaD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_AguaD.Size = new System.Drawing.Size(27, 16);
            this.Lbl_AguaD.TabIndex = 17;
            this.Lbl_AguaD.Text = "*****";
            this.Lbl_AguaD.UseWaitCursor = true;
            this.Lbl_AguaD.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lbl_AguaM
            // 
            this.Lbl_AguaM.AutoSize = true;
            this.Lbl_AguaM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AguaM.Location = new System.Drawing.Point(156, 332);
            this.Lbl_AguaM.Name = "Lbl_AguaM";
            this.Lbl_AguaM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_AguaM.Size = new System.Drawing.Size(27, 16);
            this.Lbl_AguaM.TabIndex = 18;
            this.Lbl_AguaM.Text = "*****";
            this.Lbl_AguaM.UseWaitCursor = true;
            this.Lbl_AguaM.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblGastoDA
            // 
            this.LblGastoDA.AutoSize = true;
            this.LblGastoDA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastoDA.Location = new System.Drawing.Point(302, 332);
            this.LblGastoDA.Name = "LblGastoDA";
            this.LblGastoDA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblGastoDA.Size = new System.Drawing.Size(27, 16);
            this.LblGastoDA.TabIndex = 19;
            this.LblGastoDA.Text = "*****";
            this.LblGastoDA.UseWaitCursor = true;
            // 
            // LblGastoA
            // 
            this.LblGastoA.AutoSize = true;
            this.LblGastoA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGastoA.Location = new System.Drawing.Point(450, 332);
            this.LblGastoA.Name = "LblGastoA";
            this.LblGastoA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblGastoA.Size = new System.Drawing.Size(27, 16);
            this.LblGastoA.TabIndex = 20;
            this.LblGastoA.Text = "*****";
            this.LblGastoA.UseWaitCursor = true;
            // 
            // Lbl_AG
            // 
            this.Lbl_AG.AutoSize = true;
            this.Lbl_AG.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AG.Location = new System.Drawing.Point(450, 364);
            this.Lbl_AG.Name = "Lbl_AG";
            this.Lbl_AG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_AG.Size = new System.Drawing.Size(27, 16);
            this.Lbl_AG.TabIndex = 21;
            this.Lbl_AG.Text = "*****";
            this.Lbl_AG.UseWaitCursor = true;
            // 
            // Lbl_LG
            // 
            this.Lbl_LG.AutoSize = true;
            this.Lbl_LG.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LG.Location = new System.Drawing.Point(450, 348);
            this.Lbl_LG.Name = "Lbl_LG";
            this.Lbl_LG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_LG.Size = new System.Drawing.Size(27, 16);
            this.Lbl_LG.TabIndex = 22;
            this.Lbl_LG.Text = "*****";
            this.Lbl_LG.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(588, 461);
            this.Controls.Add(this.Lbl_LG);
            this.Controls.Add(this.Lbl_AG);
            this.Controls.Add(this.LblGastoA);
            this.Controls.Add(this.LblGastoDA);
            this.Controls.Add(this.Lbl_AguaM);
            this.Controls.Add(this.Lbl_AguaD);
            this.Controls.Add(this.LblGastoMes);
            this.Controls.Add(this.LblGastoDL);
            this.Controls.Add(this.LblAguaD);
            this.Controls.Add(this.LblMesAgua);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Lbl_Dia);
            this.Controls.Add(this.Lbl_ConsumoD);
            this.Controls.Add(this.LblMes);
            this.Controls.Add(this.Btn_Dia);
            this.Controls.Add(this.Btn_Consumo);
            this.Controls.Add(this.Btn_Mensal);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Lbl_Saudacao);
            this.Controls.Add(this.Pnl_Menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.Label Lbl_Saudacao;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Btn_Mensal;
        private System.Windows.Forms.Button Btn_Consumo;
        private System.Windows.Forms.Button Btn_Dia;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Label Lbl_ConsumoD;
        private System.Windows.Forms.Label Lbl_Dia;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label LblMesAgua;
        private System.Windows.Forms.Label LblAguaD;
        private System.Windows.Forms.Label LblGastoDL;
        private System.Windows.Forms.Label LblGastoMes;
        private System.Windows.Forms.Label Lbl_AguaD;
        private System.Windows.Forms.Label Lbl_AguaM;
        private System.Windows.Forms.Label LblGastoDA;
        private System.Windows.Forms.Label LblGastoA;
        private System.Windows.Forms.Label Lbl_AG;
        private System.Windows.Forms.Label Lbl_LG;
    }
}

