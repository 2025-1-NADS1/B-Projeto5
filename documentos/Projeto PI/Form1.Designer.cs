namespace Projeto_PI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel_expand = new System.Windows.Forms.Panel();
            this.Ajuda = new System.Windows.Forms.Button();
            this.Rank = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.Button();
            this.Usuario_img = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MENU = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ComodosPainel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Comodos = new System.Windows.Forms.Button();
            this.Quarto1 = new System.Windows.Forms.Button();
            this.Quarto2 = new System.Windows.Forms.Button();
            this.Sala = new System.Windows.Forms.Button();
            this.Cozinha = new System.Windows.Forms.Button();
            this.Piscina = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Menuflow = new System.Windows.Forms.Timer(this.components);
            this.Sidebartransmition = new System.Windows.Forms.Timer(this.components);
            this.ComodosFlow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usuario_tick = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.panel_expand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usuario_img)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ComodosPainel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do projeto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 1);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(59, 34);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_expand
            // 
            this.panel_expand.Controls.Add(this.Ajuda);
            this.panel_expand.Controls.Add(this.Rank);
            this.panel_expand.Controls.Add(this.Usuario);
            this.panel_expand.Controls.Add(this.Usuario_img);
            this.panel_expand.Location = new System.Drawing.Point(385, 107);
            this.panel_expand.Name = "panel_expand";
            this.panel_expand.Size = new System.Drawing.Size(76, 34);
            this.panel_expand.TabIndex = 5;
            this.panel_expand.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_usuario_Paint);
            // 
            // Ajuda
            // 
            this.Ajuda.Location = new System.Drawing.Point(0, 99);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(76, 23);
            this.Ajuda.TabIndex = 8;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.UseVisualStyleBackColor = true;
            // 
            // Rank
            // 
            this.Rank.Location = new System.Drawing.Point(0, 70);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(76, 23);
            this.Rank.TabIndex = 7;
            this.Rank.Text = "Rank";
            this.Rank.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(0, 41);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(76, 23);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario";
            this.Usuario.UseVisualStyleBackColor = true;
            // 
            // Usuario_img
            // 
            this.Usuario_img.Image = ((System.Drawing.Image)(resources.GetObject("Usuario_img.Image")));
            this.Usuario_img.Location = new System.Drawing.Point(16, 0);
            this.Usuario_img.Name = "Usuario_img";
            this.Usuario_img.Size = new System.Drawing.Size(42, 35);
            this.Usuario_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Usuario_img.TabIndex = 4;
            this.Usuario_img.TabStop = false;
            this.Usuario_img.Click += new System.EventHandler(this.Usuario_img_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Purple;
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.MenuContainer);
            this.sidebar.Controls.Add(this.ComodosPainel);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 35);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(171, 415);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.button13);
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(171, 34);
            this.pnDashboard.TabIndex = 13;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(171, 33);
            this.button13.TabIndex = 16;
            this.button13.Text = "DASHBOARD";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.Purple;
            this.MenuContainer.Controls.Add(this.panel5);
            this.MenuContainer.Controls.Add(this.button9);
            this.MenuContainer.Controls.Add(this.button7);
            this.MenuContainer.Location = new System.Drawing.Point(0, 40);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(171, 33);
            this.MenuContainer.TabIndex = 7;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuContainer_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MENU);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 32);
            this.panel5.TabIndex = 8;
            // 
            // MENU
            // 
            this.MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MENU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MENU.Image = ((System.Drawing.Image)(resources.GetObject("MENU.Image")));
            this.MENU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MENU.Location = new System.Drawing.Point(0, -1);
            this.MENU.Margin = new System.Windows.Forms.Padding(0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(171, 33);
            this.MENU.TabIndex = 2;
            this.MENU.Text = "MENU";
            this.MENU.UseVisualStyleBackColor = false;
            this.MENU.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(0, 32);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(171, 33);
            this.button9.TabIndex = 12;
            this.button9.Text = "SUB-MENU";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(0, 65);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 33);
            this.button7.TabIndex = 13;
            this.button7.Text = "SUB-MENU2";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ComodosPainel
            // 
            this.ComodosPainel.BackColor = System.Drawing.Color.Purple;
            this.ComodosPainel.Controls.Add(this.panel2);
            this.ComodosPainel.Controls.Add(this.Quarto1);
            this.ComodosPainel.Controls.Add(this.Quarto2);
            this.ComodosPainel.Controls.Add(this.Sala);
            this.ComodosPainel.Controls.Add(this.Cozinha);
            this.ComodosPainel.Controls.Add(this.Piscina);
            this.ComodosPainel.Location = new System.Drawing.Point(0, 73);
            this.ComodosPainel.Margin = new System.Windows.Forms.Padding(0);
            this.ComodosPainel.Name = "ComodosPainel";
            this.ComodosPainel.Size = new System.Drawing.Size(171, 33);
            this.ComodosPainel.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Comodos);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 32);
            this.panel2.TabIndex = 8;
            // 
            // Comodos
            // 
            this.Comodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Comodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Comodos.Image = ((System.Drawing.Image)(resources.GetObject("Comodos.Image")));
            this.Comodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Comodos.Location = new System.Drawing.Point(0, 0);
            this.Comodos.Margin = new System.Windows.Forms.Padding(0);
            this.Comodos.Name = "Comodos";
            this.Comodos.Size = new System.Drawing.Size(171, 33);
            this.Comodos.TabIndex = 2;
            this.Comodos.Text = "Comodos";
            this.Comodos.UseVisualStyleBackColor = false;
            this.Comodos.Click += new System.EventHandler(this.Comodos_Click);
            // 
            // Quarto1
            // 
            this.Quarto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Quarto1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quarto1.Image = ((System.Drawing.Image)(resources.GetObject("Quarto1.Image")));
            this.Quarto1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Quarto1.Location = new System.Drawing.Point(0, 32);
            this.Quarto1.Margin = new System.Windows.Forms.Padding(0);
            this.Quarto1.Name = "Quarto1";
            this.Quarto1.Size = new System.Drawing.Size(171, 33);
            this.Quarto1.TabIndex = 12;
            this.Quarto1.Text = "Quarto1";
            this.Quarto1.UseVisualStyleBackColor = false;
            this.Quarto1.Click += new System.EventHandler(this.Quarto1_Click);
            // 
            // Quarto2
            // 
            this.Quarto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Quarto2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quarto2.Image = ((System.Drawing.Image)(resources.GetObject("Quarto2.Image")));
            this.Quarto2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Quarto2.Location = new System.Drawing.Point(0, 65);
            this.Quarto2.Margin = new System.Windows.Forms.Padding(0);
            this.Quarto2.Name = "Quarto2";
            this.Quarto2.Size = new System.Drawing.Size(171, 33);
            this.Quarto2.TabIndex = 13;
            this.Quarto2.Text = "Quarto2";
            this.Quarto2.UseVisualStyleBackColor = false;
            this.Quarto2.Click += new System.EventHandler(this.Quarto2_Click);
            // 
            // Sala
            // 
            this.Sala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sala.Image = ((System.Drawing.Image)(resources.GetObject("Sala.Image")));
            this.Sala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sala.Location = new System.Drawing.Point(0, 98);
            this.Sala.Margin = new System.Windows.Forms.Padding(0);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(171, 33);
            this.Sala.TabIndex = 17;
            this.Sala.Text = "Sala";
            this.Sala.UseVisualStyleBackColor = false;
            this.Sala.Click += new System.EventHandler(this.Sala_Click);
            // 
            // Cozinha
            // 
            this.Cozinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Cozinha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cozinha.Image = ((System.Drawing.Image)(resources.GetObject("Cozinha.Image")));
            this.Cozinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cozinha.Location = new System.Drawing.Point(0, 131);
            this.Cozinha.Margin = new System.Windows.Forms.Padding(0);
            this.Cozinha.Name = "Cozinha";
            this.Cozinha.Size = new System.Drawing.Size(171, 33);
            this.Cozinha.TabIndex = 17;
            this.Cozinha.Text = "Cozinha";
            this.Cozinha.UseVisualStyleBackColor = false;
            this.Cozinha.Click += new System.EventHandler(this.Cozinha_Click);
            // 
            // Piscina
            // 
            this.Piscina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Piscina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Piscina.Image = ((System.Drawing.Image)(resources.GetObject("Piscina.Image")));
            this.Piscina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Piscina.Location = new System.Drawing.Point(0, 164);
            this.Piscina.Margin = new System.Windows.Forms.Padding(0);
            this.Piscina.Name = "Piscina";
            this.Piscina.Size = new System.Drawing.Size(171, 33);
            this.Piscina.TabIndex = 17;
            this.Piscina.Text = "Piscina";
            this.Piscina.UseVisualStyleBackColor = false;
            this.Piscina.Click += new System.EventHandler(this.Piscina_Click);
            // 
            // Menuflow
            // 
            this.Menuflow.Interval = 10;
            this.Menuflow.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sidebartransmition
            // 
            this.Sidebartransmition.Interval = 10;
            this.Sidebartransmition.Tick += new System.EventHandler(this.Sidebartransmition_Tick);
            // 
            // ComodosFlow
            // 
            this.ComodosFlow.Interval = 10;
            this.ComodosFlow.Tick += new System.EventHandler(this.ComodosFlow_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario_tick
            // 
            this.Usuario_tick.Interval = 10;
            this.Usuario_tick.Tick += new System.EventHandler(this.Usuario_tick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_expand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.panel_expand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Usuario_img)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ComodosPainel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer Menuflow;
        private System.Windows.Forms.Timer Sidebartransmition;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.FlowLayoutPanel ComodosPainel;
        private System.Windows.Forms.Button Quarto1;
        private System.Windows.Forms.Button Quarto2;
        private System.Windows.Forms.Button Sala;
        private System.Windows.Forms.Button Cozinha;
        private System.Windows.Forms.Button Piscina;
        private System.Windows.Forms.Timer ComodosFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Comodos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Usuario_img;
        private System.Windows.Forms.Panel panel_expand;
        private System.Windows.Forms.Button Usuario;
        private System.Windows.Forms.Button Ajuda;
        private System.Windows.Forms.Button Rank;
        private System.Windows.Forms.Timer Usuario_tick;
    }
}

