using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Campoemail.Leave += new System.EventHandler(this.Campoemail_Leave);
            this.Camposenha.Leave += new System.EventHandler(this.Camposenha_Leave);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxNome_Click(object sender, EventArgs e)
        {

        }

        private void Camponome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxEmail_Click(object sender, EventArgs e)
        {

        }

        private void Campoemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Campoemail_Leave(object sender, EventArgs e)
        {
            string email = Campoemail.Text;
            if (!ValidarEmail(email))
            {
                TxValidarEmail.Text = "Email inválido.";
                TxValidarEmail.ForeColor = System.Drawing.Color.Red;
                TxValidarEmail.Visible = true;
            }
            else
            {
                TxValidarEmail.Text = "";
                TxValidarEmail.Visible = false;
            }
        }

        private bool ValidarEmail(string email)
        {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        private void TxValidarEmail_Click(object sender, EventArgs e)
        {

        }

        private void TxSenha_Click(object sender, EventArgs e)
        {

        }

        private void Camposenha_TextChanged(object sender, EventArgs e)
        {
            string senha = Camposenha.Text;
            if (!ValidarSenhauser(senha))
            {

            }
        }

        private void Camposenha_Leave(object sender, EventArgs e)
        {
            string senha = Camposenha.Text;
            if (!ValidarSenhauser(senha))
            {
                TxAvisodaSenha.Text = "A senha deve conter entre 8 e 20 caracteres, incluindo pelo menos um número, uma letra e um caractere especial.";
                TxAvisodaSenha.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                TxAvisodaSenha.Text = "";
            }
        }
        // Método para validar a senha
        private bool ValidarSenhauser(string senha)
        {
            string padrao = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,20}$";
            return Regex.IsMatch(senha, padrao);
        }

        private void TxConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void Campoconfirmarsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxDtNasc_Click(object sender, EventArgs e)
        {

        }

        private void DtPnascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btsalvar_Click(object sender, EventArgs e)
        {
            // Verificação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(Camponome.Text) || string.IsNullOrWhiteSpace(Campoemail.Text) || string.IsNullOrWhiteSpace(Camposenha.Text) || string.IsNullOrWhiteSpace(Campoconfirmarsenha.Text))
            {
                MessageBox.Show("Todos os campos são obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de Nome
            if (!Regex.IsMatch(Camponome.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("O nome deve conter apenas letras e espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataNascimento = DtPnascimento.Value;
            DateTime hoje = DateTime.Today;

            int idade = hoje.Year - dataNascimento.Year;

            if (dataNascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }

            if (idade < 18)
            {
                MessageBox.Show("O cadastro só pode ser realizado por usuários com 18 anos ou mais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = Campoemail.Text;
            if (!ValidarEmail(email))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string senha = Camposenha.Text;
            if (!ValidarSenha(senha))
            {
                MessageBox.Show("A senha deve conter entre 8 e 20 caracteres, incluindo pelo menos um número, uma letra e um caractere especial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Camposenha.Text != Campoconfirmarsenha.Text)
            {
                MessageBox.Show("As senhas não coincidem! Corrija antes de prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Cadastro realizado com sucesso!\nNome: {Camponome.Text}\nE-mail: {Campoemail.Text}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para validar a senha com expressão regular
        private bool ValidarSenha(string senha)
        {
            string padrao = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,20}$";
            return Regex.IsMatch(senha, padrao);
        }

        private void Btlimpar_Click(object sender, EventArgs e)
        {
            Camponome.Clear();
            Campoemail.Clear();
            Camposenha.Clear();
            Campoconfirmarsenha.Clear();
            DtPnascimento.Value = DateTime.Today;
        }

        private void TxAvisodaSenha_Click(object sender, EventArgs e)
        {

        }
    }
}