using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class TelaSombreada : Form
    {
        public TelaSombreada()
        {
            InitializeComponent();
        }

        private void TelaSombreada_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Opacity = 0.8; // Define transparência da sombra
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized; // Tamanho da tela toda
            this.ShowInTaskbar = false; // Esconde da barra de tarefas
        }
    }
}
