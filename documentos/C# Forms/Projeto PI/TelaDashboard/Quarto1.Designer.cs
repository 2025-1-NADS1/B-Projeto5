namespace Projeto_PI
{
    partial class Quarto1
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblInativoTV = new System.Windows.Forms.Label();
            this.BtnAtivarTimerTV = new System.Windows.Forms.Button();
            this.LblMinutosTV = new System.Windows.Forms.Label();
            this.NumTimerTV = new System.Windows.Forms.NumericUpDown();
            this.LblTimerTV = new System.Windows.Forms.Label();
            this.BtnTV = new System.Windows.Forms.Button();
            this.LblTV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblModoAR = new System.Windows.Forms.Label();
            this.CmbModoAr = new System.Windows.Forms.ComboBox();
            this.LblGraus = new System.Windows.Forms.Label();
            this.NudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnArCondicionado = new System.Windows.Forms.Button();
            this.LblClima = new System.Windows.Forms.Label();
            this.PnIluminacao = new System.Windows.Forms.Panel();
            this.LblStatusTimer = new System.Windows.Forms.Label();
            this.BtnAtivarTimer = new System.Windows.Forms.Button();
            this.LblMinutosTimer = new System.Windows.Forms.Label();
            this.NudTimerMinutos = new System.Windows.Forms.NumericUpDown();
            this.LblTimer = new System.Windows.Forms.Label();
            this.LblIntesidadeValor = new System.Windows.Forms.Label();
            this.LblIntensidadeCem = new System.Windows.Forms.Label();
            this.LblIntensidadeZero = new System.Windows.Forms.Label();
            this.TrkIntensidade = new System.Windows.Forms.TrackBar();
            this.LblIntensidade = new System.Windows.Forms.Label();
            this.BtnLuzQuarto1 = new System.Windows.Forms.Button();
            this.Lbltitliluminicao = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimerTV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTemperatura)).BeginInit();
            this.PnIluminacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimerMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkIntensidade)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(99)))));
            this.LblTitulo.Location = new System.Drawing.Point(297, 1);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(209, 37);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Quarto Principal";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnIluminacao, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 412);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(408, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 200);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LblInativoTV);
            this.panel2.Controls.Add(this.BtnAtivarTimerTV);
            this.panel2.Controls.Add(this.LblMinutosTV);
            this.panel2.Controls.Add(this.NumTimerTV);
            this.panel2.Controls.Add(this.LblTimerTV);
            this.panel2.Controls.Add(this.BtnTV);
            this.panel2.Controls.Add(this.LblTV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 200);
            this.panel2.TabIndex = 11;
            // 
            // LblInativoTV
            // 
            this.LblInativoTV.AutoSize = true;
            this.LblInativoTV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInativoTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.LblInativoTV.Location = new System.Drawing.Point(237, 105);
            this.LblInativoTV.Name = "LblInativoTV";
            this.LblInativoTV.Size = new System.Drawing.Size(43, 15);
            this.LblInativoTV.TabIndex = 20;
            this.LblInativoTV.Text = "Inativo";
            // 
            // BtnAtivarTimerTV
            // 
            this.BtnAtivarTimerTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnAtivarTimerTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtivarTimerTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtivarTimerTV.ForeColor = System.Drawing.Color.White;
            this.BtnAtivarTimerTV.Location = new System.Drawing.Point(205, 81);
            this.BtnAtivarTimerTV.Name = "BtnAtivarTimerTV";
            this.BtnAtivarTimerTV.Size = new System.Drawing.Size(103, 21);
            this.BtnAtivarTimerTV.TabIndex = 19;
            this.BtnAtivarTimerTV.Text = "Ativar Timer";
            this.BtnAtivarTimerTV.UseVisualStyleBackColor = false;
            // 
            // LblMinutosTV
            // 
            this.LblMinutosTV.AutoSize = true;
            this.LblMinutosTV.Location = new System.Drawing.Point(324, 59);
            this.LblMinutosTV.Name = "LblMinutosTV";
            this.LblMinutosTV.Size = new System.Drawing.Size(44, 13);
            this.LblMinutosTV.TabIndex = 16;
            this.LblMinutosTV.Text = "Minutos";
            // 
            // NumTimerTV
            // 
            this.NumTimerTV.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumTimerTV.Location = new System.Drawing.Point(198, 55);
            this.NumTimerTV.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.NumTimerTV.Name = "NumTimerTV";
            this.NumTimerTV.Size = new System.Drawing.Size(120, 20);
            this.NumTimerTV.TabIndex = 18;
            // 
            // LblTimerTV
            // 
            this.LblTimerTV.AutoSize = true;
            this.LblTimerTV.Location = new System.Drawing.Point(195, 39);
            this.LblTimerTV.Name = "LblTimerTV";
            this.LblTimerTV.Size = new System.Drawing.Size(113, 13);
            this.LblTimerTV.TabIndex = 17;
            this.LblTimerTV.Text = "Timer de desligamento";
            // 
            // BtnTV
            // 
            this.BtnTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BtnTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTV.ForeColor = System.Drawing.Color.White;
            this.BtnTV.Location = new System.Drawing.Point(43, 39);
            this.BtnTV.Name = "BtnTV";
            this.BtnTV.Size = new System.Drawing.Size(108, 132);
            this.BtnTV.TabIndex = 14;
            this.BtnTV.Text = "TV ";
            this.BtnTV.UseVisualStyleBackColor = false;
            // 
            // LblTV
            // 
            this.LblTV.AutoSize = true;
            this.LblTV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblTV.Location = new System.Drawing.Point(169, 0);
            this.LblTV.Name = "LblTV";
            this.LblTV.Size = new System.Drawing.Size(30, 21);
            this.LblTV.TabIndex = 15;
            this.LblTV.Text = "TV";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LblModoAR);
            this.panel1.Controls.Add(this.CmbModoAr);
            this.panel1.Controls.Add(this.LblGraus);
            this.panel1.Controls.Add(this.NudTemperatura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnArCondicionado);
            this.panel1.Controls.Add(this.LblClima);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(408, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 200);
            this.panel1.TabIndex = 10;
            // 
            // LblModoAR
            // 
            this.LblModoAR.AutoSize = true;
            this.LblModoAR.Location = new System.Drawing.Point(212, 98);
            this.LblModoAR.Name = "LblModoAR";
            this.LblModoAR.Size = new System.Drawing.Size(115, 13);
            this.LblModoAR.TabIndex = 22;
            this.LblModoAR.Text = "Modo Ar Condicionado";
            // 
            // CmbModoAr
            // 
            this.CmbModoAr.FormattingEnabled = true;
            this.CmbModoAr.Items.AddRange(new object[] {
            "Resfriar ❄️",
            "Aquecer 🔥",
            "Automático 🔄"});
            this.CmbModoAr.Location = new System.Drawing.Point(209, 114);
            this.CmbModoAr.Name = "CmbModoAr";
            this.CmbModoAr.Size = new System.Drawing.Size(120, 21);
            this.CmbModoAr.TabIndex = 21;
            this.CmbModoAr.Text = "Controle ";
            // 
            // LblGraus
            // 
            this.LblGraus.AutoSize = true;
            this.LblGraus.Location = new System.Drawing.Point(333, 57);
            this.LblGraus.Name = "LblGraus";
            this.LblGraus.Size = new System.Drawing.Size(18, 13);
            this.LblGraus.TabIndex = 10;
            this.LblGraus.Text = "°C";
            // 
            // NudTemperatura
            // 
            this.NudTemperatura.Location = new System.Drawing.Point(207, 55);
            this.NudTemperatura.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NudTemperatura.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NudTemperatura.Name = "NudTemperatura";
            this.NudTemperatura.Size = new System.Drawing.Size(120, 20);
            this.NudTemperatura.TabIndex = 11;
            this.NudTemperatura.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temperatura";
            // 
            // BtnArCondicionado
            // 
            this.BtnArCondicionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BtnArCondicionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArCondicionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArCondicionado.ForeColor = System.Drawing.Color.White;
            this.BtnArCondicionado.Location = new System.Drawing.Point(47, 48);
            this.BtnArCondicionado.Name = "BtnArCondicionado";
            this.BtnArCondicionado.Size = new System.Drawing.Size(108, 132);
            this.BtnArCondicionado.TabIndex = 10;
            this.BtnArCondicionado.Text = "Ar Condicionado";
            this.BtnArCondicionado.UseVisualStyleBackColor = false;
            // 
            // LblClima
            // 
            this.LblClima.AutoSize = true;
            this.LblClima.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClima.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LblClima.Location = new System.Drawing.Point(138, 0);
            this.LblClima.Name = "LblClima";
            this.LblClima.Size = new System.Drawing.Size(54, 21);
            this.LblClima.TabIndex = 10;
            this.LblClima.Text = "Clima";
            // 
            // PnIluminacao
            // 
            this.PnIluminacao.BackColor = System.Drawing.Color.White;
            this.PnIluminacao.Controls.Add(this.LblStatusTimer);
            this.PnIluminacao.Controls.Add(this.BtnAtivarTimer);
            this.PnIluminacao.Controls.Add(this.LblMinutosTimer);
            this.PnIluminacao.Controls.Add(this.NudTimerMinutos);
            this.PnIluminacao.Controls.Add(this.LblTimer);
            this.PnIluminacao.Controls.Add(this.LblIntesidadeValor);
            this.PnIluminacao.Controls.Add(this.LblIntensidadeCem);
            this.PnIluminacao.Controls.Add(this.LblIntensidadeZero);
            this.PnIluminacao.Controls.Add(this.TrkIntensidade);
            this.PnIluminacao.Controls.Add(this.LblIntensidade);
            this.PnIluminacao.Controls.Add(this.BtnLuzQuarto1);
            this.PnIluminacao.Controls.Add(this.Lbltitliluminicao);
            this.PnIluminacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnIluminacao.Location = new System.Drawing.Point(3, 3);
            this.PnIluminacao.Name = "PnIluminacao";
            this.PnIluminacao.Size = new System.Drawing.Size(399, 200);
            this.PnIluminacao.TabIndex = 0;
            this.PnIluminacao.Paint += new System.Windows.Forms.PaintEventHandler(this.PnIluminacao_Paint);
            // 
            // LblStatusTimer
            // 
            this.LblStatusTimer.AutoSize = true;
            this.LblStatusTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.LblStatusTimer.Location = new System.Drawing.Point(237, 114);
            this.LblStatusTimer.Name = "LblStatusTimer";
            this.LblStatusTimer.Size = new System.Drawing.Size(43, 15);
            this.LblStatusTimer.TabIndex = 9;
            this.LblStatusTimer.Text = "Inativo";
            this.LblStatusTimer.Click += new System.EventHandler(this.LblStatusTimer_Click);
            // 
            // BtnAtivarTimer
            // 
            this.BtnAtivarTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnAtivarTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtivarTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtivarTimer.ForeColor = System.Drawing.Color.White;
            this.BtnAtivarTimer.Location = new System.Drawing.Point(205, 90);
            this.BtnAtivarTimer.Name = "BtnAtivarTimer";
            this.BtnAtivarTimer.Size = new System.Drawing.Size(103, 21);
            this.BtnAtivarTimer.TabIndex = 8;
            this.BtnAtivarTimer.Text = "Ativar Timer";
            this.BtnAtivarTimer.UseVisualStyleBackColor = false;
            this.BtnAtivarTimer.Click += new System.EventHandler(this.BtnAtivarTimer_Click);
            // 
            // LblMinutosTimer
            // 
            this.LblMinutosTimer.AutoSize = true;
            this.LblMinutosTimer.Location = new System.Drawing.Point(324, 68);
            this.LblMinutosTimer.Name = "LblMinutosTimer";
            this.LblMinutosTimer.Size = new System.Drawing.Size(44, 13);
            this.LblMinutosTimer.TabIndex = 2;
            this.LblMinutosTimer.Text = "Minutos";
            this.LblMinutosTimer.Click += new System.EventHandler(this.LblMinutosTimer_Click);
            // 
            // NudTimerMinutos
            // 
            this.NudTimerMinutos.Location = new System.Drawing.Point(198, 64);
            this.NudTimerMinutos.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NudTimerMinutos.Name = "NudTimerMinutos";
            this.NudTimerMinutos.Size = new System.Drawing.Size(120, 20);
            this.NudTimerMinutos.TabIndex = 7;
            this.NudTimerMinutos.ValueChanged += new System.EventHandler(this.NudTimerMinutos_ValueChanged);
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(195, 48);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(113, 13);
            this.LblTimer.TabIndex = 2;
            this.LblTimer.Text = "Timer de desligamento";
            this.LblTimer.Click += new System.EventHandler(this.LblTimer_Click);
            // 
            // LblIntesidadeValor
            // 
            this.LblIntesidadeValor.AutoSize = true;
            this.LblIntesidadeValor.Location = new System.Drawing.Point(245, 184);
            this.LblIntesidadeValor.Name = "LblIntesidadeValor";
            this.LblIntesidadeValor.Size = new System.Drawing.Size(27, 13);
            this.LblIntesidadeValor.TabIndex = 6;
            this.LblIntesidadeValor.Text = "50%";
            // 
            // LblIntensidadeCem
            // 
            this.LblIntensidadeCem.AutoSize = true;
            this.LblIntensidadeCem.Location = new System.Drawing.Point(331, 167);
            this.LblIntensidadeCem.Name = "LblIntensidadeCem";
            this.LblIntensidadeCem.Size = new System.Drawing.Size(33, 13);
            this.LblIntensidadeCem.TabIndex = 5;
            this.LblIntensidadeCem.Text = "100%";
            this.LblIntensidadeCem.Click += new System.EventHandler(this.LblIntensidadeCem_Click);
            // 
            // LblIntensidadeZero
            // 
            this.LblIntensidadeZero.AutoSize = true;
            this.LblIntensidadeZero.Location = new System.Drawing.Point(170, 167);
            this.LblIntensidadeZero.Name = "LblIntensidadeZero";
            this.LblIntensidadeZero.Size = new System.Drawing.Size(21, 13);
            this.LblIntensidadeZero.TabIndex = 2;
            this.LblIntensidadeZero.Text = "0%";
            this.LblIntensidadeZero.Click += new System.EventHandler(this.LblIntensidadeZero_Click);
            // 
            // TrkIntensidade
            // 
            this.TrkIntensidade.Location = new System.Drawing.Point(188, 152);
            this.TrkIntensidade.Maximum = 100;
            this.TrkIntensidade.Name = "TrkIntensidade";
            this.TrkIntensidade.Size = new System.Drawing.Size(137, 45);
            this.TrkIntensidade.TabIndex = 4;
            this.TrkIntensidade.Value = 50;
            this.TrkIntensidade.Scroll += new System.EventHandler(this.TrkIntensidade_Scroll);
            // 
            // LblIntensidade
            // 
            this.LblIntensidade.AutoSize = true;
            this.LblIntensidade.Location = new System.Drawing.Point(226, 136);
            this.LblIntensidade.Name = "LblIntensidade";
            this.LblIntensidade.Size = new System.Drawing.Size(62, 13);
            this.LblIntensidade.TabIndex = 2;
            this.LblIntensidade.Text = "Intensidade";
            this.LblIntensidade.Click += new System.EventHandler(this.LblIntensidade_Click);
            // 
            // BtnLuzQuarto1
            // 
            this.BtnLuzQuarto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.BtnLuzQuarto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLuzQuarto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLuzQuarto1.ForeColor = System.Drawing.Color.White;
            this.BtnLuzQuarto1.Location = new System.Drawing.Point(43, 48);
            this.BtnLuzQuarto1.Name = "BtnLuzQuarto1";
            this.BtnLuzQuarto1.Size = new System.Drawing.Size(108, 132);
            this.BtnLuzQuarto1.TabIndex = 3;
            this.BtnLuzQuarto1.Text = "Luz Principal";
            this.BtnLuzQuarto1.UseVisualStyleBackColor = false;
            this.BtnLuzQuarto1.Click += new System.EventHandler(this.BtnLuzQuarto1_Click);
            // 
            // Lbltitliluminicao
            // 
            this.Lbltitliluminicao.AutoSize = true;
            this.Lbltitliluminicao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitliluminicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Lbltitliluminicao.Location = new System.Drawing.Point(137, 0);
            this.Lbltitliluminicao.Name = "Lbltitliluminicao";
            this.Lbltitliluminicao.Size = new System.Drawing.Size(96, 21);
            this.Lbltitliluminicao.TabIndex = 2;
            this.Lbltitliluminicao.Text = "Iluminação";
            this.Lbltitliluminicao.Click += new System.EventHandler(this.Lbltitliluminicao_Click);
            // 
            // Quarto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quarto1";
            this.Text = "Quarto1";
            this.Load += new System.EventHandler(this.Quarto1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimerTV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTemperatura)).EndInit();
            this.PnIluminacao.ResumeLayout(false);
            this.PnIluminacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimerMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkIntensidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnIluminacao;
        private System.Windows.Forms.Label Lbltitliluminicao;
        private System.Windows.Forms.Button BtnLuzQuarto1;
        private System.Windows.Forms.TrackBar TrkIntensidade;
        private System.Windows.Forms.Label LblIntensidade;
        private System.Windows.Forms.Label LblIntensidadeCem;
        private System.Windows.Forms.Label LblIntensidadeZero;
        private System.Windows.Forms.Label LblIntesidadeValor;
        private System.Windows.Forms.NumericUpDown NudTimerMinutos;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblMinutosTimer;
        private System.Windows.Forms.Button BtnAtivarTimer;
        private System.Windows.Forms.Label LblStatusTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NudTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnArCondicionado;
        private System.Windows.Forms.Label LblClima;
        private System.Windows.Forms.Button BtnTV;
        private System.Windows.Forms.Label LblTV;
        private System.Windows.Forms.Label LblGraus;
        private System.Windows.Forms.Label LblInativoTV;
        private System.Windows.Forms.Button BtnAtivarTimerTV;
        private System.Windows.Forms.Label LblMinutosTV;
        private System.Windows.Forms.NumericUpDown NumTimerTV;
        private System.Windows.Forms.Label LblTimerTV;
        private System.Windows.Forms.ComboBox CmbModoAr;
        private System.Windows.Forms.Label LblModoAR;
    }
}