using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMes.Text = "*****";
            Lbl_Dia.Text = "*****";
            Lbl_ConsumoD.Text = "*****";
            Lbl_Mes.Text = "*****";

        }

        private void LblMes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Mensal_Click(object sender, EventArgs e)
        {
            LblMes.Text = "Luz: 160kWh";
            LblMesAgua.Text = "Água: 7,5m³";
            LblGastoMes.Text = "Luz: R$ 111,90";
            Lbl_AguaM.Text = "Água: R$41,25";
        }

        private void Btn_Dia_Click(object sender, EventArgs e)
        {
            Lbl_Dia.Text = "Luz: 5,3kWh";
            LblAguaD.Text = "Água: 0,25m³";
            LblGastoDL.Text = "Luz: R$ 3,73";
            LblGastoDA.Text = "Água: R$ 1,37";
        }

        private void Lbl_Dia_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Consumo_Click(object sender, EventArgs e)
        {
            Lbl_ConsumoD.Text = "Mês - Sala: 27kWh";
            Lbl_Mes.Text = "Dia - Piscina: 2kWh";
            Lbl_AguaD.Text = "Mês - Cozinha: 1,1m³";
            LblGastoA.Text = "Dia - Suíte: 0,6m³";
            Lbl_LG.Text = "Luz: R$ 18,90";
            Lbl_AG.Text = "Água: R$ 9,35";
        }

        private void Lbl_ConsumoD_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            LblMes.Text = "*****";
            LblMesAgua.Text = "*****";
            LblGastoMes.Text = "*****";
            Lbl_AguaM.Text = "*****";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Lbl_Dia.Text = "*****";
            LblAguaD.Text = "*****";
            LblGastoDL.Text = "*****";
            LblGastoDA.Text = "*****";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Lbl_ConsumoD.Text = "*****";
            Lbl_Mes.Text = "*****";
            Lbl_AguaD.Text = "*****";
            LblGastoA.Text = "*****";
            Lbl_LG.Text = "*****";
            Lbl_AG.Text = "*****";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
