using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PI
{
    public partial class Form1 : Form
    {
        private Form _activeForm = null;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            T newForm = new T();
            newForm.MdiParent = this;
            newForm.StartPosition = FormStartPosition.Manual; // Define o StartPosition como Manual
            newForm.Location = new Point(0, 0); // Define a localização para o canto superior esquerdo da área MDI
            // Ou, para centralizar dentro da área MDI:
            // newForm.Location = new Point((this.ClientSize.Width - newForm.Width) / 2, (this.ClientSize.Height - newForm.Height) / 2);
            newForm.FormClosed += (s, e) => _activeForm = null;
            newForm.Show();
            _activeForm = newForm;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Sem alterações
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartransmition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Sem alterações
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sem alterações
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sem alterações
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menuflow.Start();
        }

        bool MenuExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MenuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 100)
                {
                    Menuflow.Stop();
                    MenuExpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 33)
                {
                    Menuflow.Stop();
                    MenuExpand = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Sem alterações
        }

        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {
            // Sem alterações
        }

        bool sidebarExpand = true;
        private void Sidebartransmition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 33)
                {
                    sidebarExpand = false;
                    Sidebartransmition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 171)
                {
                    sidebarExpand = true;
                    Sidebartransmition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                }
            }
        }

        private void sidebar_Paint(object sender, EventArgs e)
        {
            // Sem alterações
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnDashboard.Width = sidebar.Width;
            MenuContainer.Width = sidebar.Width;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm<dashboard>();
        }

        private void Comodos_Click(object sender, EventArgs e)
        {
            ComodosFlow.Start();
        }

        bool ComodosExpand = false;
        private void ComodosFlow_Tick(object sender, EventArgs e)
        {
            if (ComodosExpand == false)
            {
                ComodosPainel.Height += 10;
                if (ComodosPainel.Height >= 200)
                {
                    ComodosFlow.Stop();
                    ComodosExpand = true;
                }
            }
            else
            {
                ComodosPainel.Height -= 10;
                if (ComodosPainel.Height <= 33)
                {
                    ComodosFlow.Stop();
                    ComodosExpand = false;
                }
            }
        }

        private void Quarto1_Click(object sender, EventArgs e)
        {
            OpenChildForm<Quarto1>();
        }

        private void Quarto2_Click(object sender, EventArgs e)
        {
            OpenChildForm<Quarto2>();

        }

        private void Cozinha_Click(object sender, EventArgs e)
        {
            OpenChildForm<Cozinha>();
        }

        private void Piscina_Click(object sender, EventArgs e)
        {
            OpenChildForm<Piscina>();
        }

        private void Sala_Click(object sender, EventArgs e)
        {
            OpenChildForm<Sala>();
        }

        private void panel_usuario_Paint(object sender, PaintEventArgs e)
        {

        }
        bool usuarioExpand = false;
        private void Usuario_tick_Tick(object sender, EventArgs e)
        {
            if (usuarioExpand == false)
            {
                panel_expand.Height += 10;
                if (panel_expand.Height >= 125) // Se expandiu até a altura desejada
                {
                    Usuario_tick.Stop();
                    usuarioExpand = true;
                }
            }
            else
            {
                panel_expand.Height -= 10;
                if (panel_expand.Height <= 35) // Se retraiu até a altura desejada
                {
                    Usuario_tick.Stop();
                    usuarioExpand = false;
                }
            }
        }

        private void Usuario_img_Click(object sender, EventArgs e)
        {
            Usuario_tick.Start();
        }
    }
}
