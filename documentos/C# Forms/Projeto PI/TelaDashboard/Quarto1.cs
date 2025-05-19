using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PI
{
    public partial class Quarto1 : Form
    {
        // Declare class-level variables to track state
        private bool luzPrincipalLigada = false;
        private Timer timerLuz = new Timer();

        public Quarto1()
        {
            InitializeComponent();
            ConfigurarEventHandlers();
            AtualizarInterfaceUsuario();
        }

        private void Quarto1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ConfigurarEventHandlers()
        {
            // Luz Principal
            BtnLuzQuarto1.Click += (sender, e) =>
            {
                luzPrincipalLigada = !luzPrincipalLigada;
                AtualizarBotaoDispositivo(BtnLuzQuarto1, luzPrincipalLigada);

                // Se desligar a luz, desabilitar o controle de intensidade
                TrkIntensidade.Enabled = luzPrincipalLigada;
                LblIntensidade.Enabled = luzPrincipalLigada;
                LblIntesidadeValor.Enabled = luzPrincipalLigada;
            };

            // Controle de intensidade
            TrkIntensidade.ValueChanged += (sender, e) =>
            {
                LblIntesidadeValor.Text = $"{TrkIntensidade.Value}%";
                // Aqui você poderia adicionar código para ajustar a intensidade real da luz
            };

            // Timer da luz
            BtnAtivarTimer.Click += (sender, e) =>
            {
                if (timerLuz.Enabled)
                {
                    // Desativar timer
                    timerLuz.Stop();
                    LblStatusTimer.Text = "Desativado";
                    BtnAtivarTimer.Text = "Ativar Timer";
                }
                else
                {
                    // Ativar timer
                    int minutos = (int)NudTimerMinutos.Value;
                    if (minutos > 0)
                    {
                        timerLuz.Interval = minutos * 60 * 1000; // Converter minutos para milissegundos
                        timerLuz.Tick += (s, args) =>
                        {
                            luzPrincipalLigada = false;
                            AtualizarBotaoDispositivo(BtnLuzQuarto1, luzPrincipalLigada);
                            TrkIntensidade.Enabled = false;
                            LblIntensidade.Enabled = false;
                            LblIntesidadeValor.Enabled = false;
                            timerLuz.Stop();
                            LblStatusTimer.Text = "Desativado";
                            BtnAtivarTimer.Text = "Ativar Timer";
                        };
                        timerLuz.Start();
                        LblStatusTimer.Text = $"Ativo: {minutos} min";
                        BtnAtivarTimer.Text = "Cancelar";
                    }
                }
            };
        }

        private void AtualizarInterfaceUsuario()
        {
            // Configurar o estado inicial do botão da luz
            AtualizarBotaoDispositivo(BtnLuzQuarto1, luzPrincipalLigada);

            // Configurar o controle de intensidade
            TrkIntensidade.Enabled = luzPrincipalLigada;
            LblIntesidadeValor.Enabled = luzPrincipalLigada;
            LblIntesidadeValor.Enabled = luzPrincipalLigada;
            LblIntesidadeValor.Text = $"{TrkIntensidade.Value}%";

            // Configurar o timer
            LblStatusTimer.Text = "Desativado";
        }

        private void AtualizarBotaoDispositivo(Button botao, bool ligado)
        {
            if (ligado)
            {
                botao.BackColor = Color.Green;
                botao.Text = "ON";
            }
            else
            {
                botao.BackColor = Color.Red;
                botao.Text = "OFF";
            }
        }

        // Eventos vazios gerados pelo designer
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Lbltitliluminicao_Click(object sender, EventArgs e)
        {
        }

        private void PnIluminacao_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnLuzQuarto1_Click(object sender, EventArgs e)
        {
            // Manipulação do evento de clique já implementada em ConfigurarEventHandlers
        }

        private void LblTimer_Click(object sender, EventArgs e)
        {
        }

        private void NudTimerMinutos_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LblMinutosTimer_Click(object sender, EventArgs e)
        {
        }

        private void BtnAtivarTimer_Click(object sender, EventArgs e)
        {
            // Manipulação do evento de clique já implementada em ConfigurarEventHandlers
        }

        private void LblStatusTimer_Click(object sender, EventArgs e)
        {
        }

        private void LblIntensidade_Click(object sender, EventArgs e)
        {
        }

        private void TrkIntensidade_Scroll(object sender, EventArgs e)
        {
            // A lógica do scroll já está implementada em ConfigurarEventHandlers
        }

        private void LblIntensidadeValor_Click(object sender, EventArgs e)
        {
        }

        private void LblIntensidadeZero_Click(object sender, EventArgs e)
        {
        }

        private void LblIntensidadeCem_Click(object sender, EventArgs e)
        {
        }
    }
}