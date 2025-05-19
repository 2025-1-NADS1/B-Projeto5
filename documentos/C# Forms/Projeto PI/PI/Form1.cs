using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None; // Define a borda - none = Sem borda
            TituloLogin.Paint += new PaintEventHandler(TituloLogin_Paint);


            // Associa o evento de pintura do botão BtEntrar ao método personalizado BtEntrar_Paint
            BtEntrar.Paint += new PaintEventHandler(BtEntrar_Paint);

            // Estilo do botão para permitir pintura personalizada
            BtEntrar.FlatStyle = FlatStyle.Flat;
            BtEntrar.FlatAppearance.BorderSize = 0;
            BtEntrar.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Criar e exibir o fundo escurecido
            TelaSombreada sombra = new TelaSombreada();
            sombra.Show(); // Exibe o fundo escuro sem bloquear a execução

            // Garantir que a tela de login fique em destaque
            this.TopMost = true;
        }

        // BtSair_Click - Botton sair -> Application.Exit = Sair
        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TituloLogin_Click(object sender, EventArgs e)
        {
            TituloLogin.BackColor = Color.Transparent;

        }

        private void TituloLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, TituloLogin.Width, TituloLogin.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Empty, Color.Empty, LinearGradientMode.Horizontal))
            {
                // Definindo as cores do gradiente
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Colors = new Color[] { Color.DarkBlue, Color.CornflowerBlue, Color.MediumVioletRed };
                colorBlend.Positions = new float[] { 0.0f, 0.5f, 1.0f };

                brush.InterpolationColors = colorBlend;

                // Desenhando o texto com o gradiente
                g.DrawString(TituloLogin.Text, TituloLogin.Font, brush, new PointF(0, 0));
            }
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {

        }

        private void BtEntrar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, BtEntrar.Width, BtEntrar.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.AliceBlue, Color.PaleVioletRed, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, rect); // Pinta o fundo com gradiente horizontal
            }

            // Desenha o texto manualmente (centralizado e preto)
            TextRenderer.DrawText(g, BtEntrar.Text, BtEntrar.Font, rect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Desenha a borda preta
            using (Pen borderPen = new Pen(Color.Black, 3))
            {
                g.DrawRectangle(borderPen, 0, 0, BtEntrar.Width - 1, BtEntrar.Height - 1);

            }
        }


            private void BtEntrar_Click_1(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário "Sala".
            Sala novaSala = new Sala();

            // Exibe o novo formulário.
            novaSala.Show();

            // Opcionalmente, oculta o formulário atual para que o usuário não 
            // o veja mais. Se preferir fechar, use this.Close();
            this.Hide();
        }
    }


  




