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
    public partial class dashboard : Form
    {
        // Classe para representar um dispositivo
        public class DispositivoInteligente
        {
            public string Nome { get; set; }
            public bool Estado { get; set; }
            public string Tipo { get; set; }
            public string Comodo { get; set; }
            public int ValorSensor { get; set; } // Para sensores (temperatura, umidade, etc.)
        }

        // Lista de dispositivos da casa
        private List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        // Variáveis para estatísticas
        private int dispositivosAtivos = 0;
        private double consumoEnergetico = 0;
        private double temperaturaMedia = 0;

        // Timer para simular atualização de dados em tempo real
        private Timer atualizacaoTimer = new Timer();

        public dashboard()
        {
            InitializeComponent();

            // Configurar a aparência da form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            // Inicializar dados simulados
            InicializarDispositivos();

            // Configurar timer para atualização
            atualizacaoTimer.Interval = 5000; // 5 segundos
            atualizacaoTimer.Tick += AtualizarDados;
            atualizacaoTimer.Start();

            // Carregar dados iniciais
            AtualizarDashboard();
        }

        private void InicializarDispositivos()
        {
            // Adicionar alguns dispositivos de exemplo
            dispositivos.Add(new DispositivoInteligente { Nome = "Ar Condicionado", Estado = true, Tipo = "Clima", Comodo = "Quarto 1", ValorSensor = 22 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Iluminação", Estado = true, Tipo = "Luz", Comodo = "Quarto 1", ValorSensor = 0 });
            dispositivos.Add(new DispositivoInteligente { Nome = "TV", Estado = false, Tipo = "Entretenimento", Comodo = "Sala", ValorSensor = 0 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Irrigação", Estado = false, Tipo = "Água", Comodo = "Jardim", ValorSensor = 0 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Sensor de Temperatura", Estado = true, Tipo = "Sensor", Comodo = "Cozinha", ValorSensor = 26 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Geladeira", Estado = true, Tipo = "Eletrodoméstico", Comodo = "Cozinha", ValorSensor = 0 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Iluminação", Estado = false, Tipo = "Luz", Comodo = "Piscina", ValorSensor = 0 });
            dispositivos.Add(new DispositivoInteligente { Nome = "Sistema de Filtragem", Estado = true, Tipo = "Água", Comodo = "Piscina", ValorSensor = 0 });
        }

        private void AtualizarDados(object sender, EventArgs e)
        {
            // Simular mudanças nos dispositivos para demonstração
            Random rnd = new Random();

            // Atualizar alguns dispositivos aleatoriamente
            foreach (var dispositivo in dispositivos)
            {
                if (dispositivo.Tipo == "Sensor")
                {
                    // Simular variação em sensores
                    dispositivo.ValorSensor += rnd.Next(-2, 3); // Variação de -2 a +2
                }

                // Aleatoriamente mudar estado de alguns dispositivos (1 em 10 chance)
                if (rnd.Next(0, 10) == 0)
                {
                    dispositivo.Estado = !dispositivo.Estado;
                }
            }

            AtualizarDashboard();
        }

        private void AtualizarDashboard()
        {
            // Calcular estatísticas
            dispositivosAtivos = dispositivos.Count(d => d.Estado);

            // Simular consumo baseado nos dispositivos ativos
            consumoEnergetico = dispositivosAtivos * 0.5; // kWh (simulação)

            // Calcular temperatura média dos sensores
            var sensoresTemperatura = dispositivos.Where(d => d.Tipo == "Sensor" || d.Tipo == "Clima").ToList();
            if (sensoresTemperatura.Any())
            {
                temperaturaMedia = sensoresTemperatura.Average(s => s.ValorSensor);
            }

            // Atualizar controles visuais
            AtualizarVisual();
        }

        private void AtualizarVisual()
        {
            // Nota: Aqui você atualizaria os controles visuais do seu dashboard
            // Este é um exemplo, você precisa substituir pelos nomes reais dos seus controles

            // Exemplo de atualização de labels
            //if // (lblDispositivosAtivos != null)
               // lblDispositivosAtivos.Text = dispositivosAtivos.ToString() + "/" + dispositivos.Count;

            //if //(lblConsumoEnergia != null)
                //lblConsumoEnergia.Text = consumoEnergetico.ToString("0.0") + " kWh";

            //if //(lblTemperaturaMedia != null)
                //lblTemperaturaMedia.Text = temperaturaMedia.ToString("0.0") + " °C";

            // Atualizar lista de dispositivos (se existir)
            AtualizarListaDispositivos();

            // Atualizar gráficos (se existirem)
            AtualizarGraficos();
        }

        private void AtualizarListaDispositivos()
        {
            // Exemplo: Atualizar um ListView com os dispositivos
            // Substitua pelo seu controle real
           // if //(lstDispositivos != null)
            {
                //lstDispositivos.Items.Clear();
                foreach (var dispositivo in dispositivos)
                {
                    var item = new ListViewItem(dispositivo.Nome);
                    item.SubItems.Add(dispositivo.Comodo);
                    item.SubItems.Add(dispositivo.Estado ? "Ligado" : "Desligado");

                    // Colorir baseado no estado
                    item.ForeColor = dispositivo.Estado ? Color.Green : Color.Gray;

                    //lstDispositivos.Items.Add(item);
                }
            }
        }

        private void AtualizarGraficos()
        {
            // Este método atualizaria quaisquer gráficos no dashboard
            // Você precisaria implementar isso de acordo com os controles de gráfico que estiver usando
        }

        // Método para alternar o estado de um dispositivo
        public void AlternarDispositivo(string nome, string comodo)
        {
            var dispositivo = dispositivos.FirstOrDefault(d => d.Nome == nome && d.Comodo == comodo);
            if (dispositivo != null)
            {
                dispositivo.Estado = !dispositivo.Estado;
                AtualizarDashboard();
            }
        }

        // Método para controlar temperatura de dispositivos de clima
        public void AjustarTemperatura(string nome, string comodo, int novaTemperatura)
        {
            var dispositivo = dispositivos.FirstOrDefault(d => d.Nome == nome && d.Comodo == comodo && d.Tipo == "Clima");
            if (dispositivo != null)
            {
                dispositivo.ValorSensor = novaTemperatura;
                AtualizarDashboard();
            }
        }

        // Métodos para criar alertas baseados em condições
        private void VerificarAlertas()
        {
            // Verificar temperaturas extremas
            foreach (var sensor in dispositivos.Where(d => d.Tipo == "Sensor"))
            {
                if (sensor.ValorSensor > 30)
                {
                    CriarAlerta($"Temperatura alta ({sensor.ValorSensor}°C) detectada em {sensor.Comodo}!");
                }
                else if (sensor.ValorSensor < 10)
                {
                    CriarAlerta($"Temperatura baixa ({sensor.ValorSensor}°C) detectada em {sensor.Comodo}!");
                }
            }

            // Outras verificações podem ser adicionadas aqui
        }

        private void CriarAlerta(string mensagem)
        {
            // Este método mostraria um alerta na interface
            // Poderia ser uma notificação, um item em uma lista, etc.
            MessageBox.Show(mensagem, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Evento de carregamento do formulário
        private void dashboard_Load(object sender, EventArgs e)
        {
            // Configurações iniciais ao carregar o formulário
        }

      
    }
}