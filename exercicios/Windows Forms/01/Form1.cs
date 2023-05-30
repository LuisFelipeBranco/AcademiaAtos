using System;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 milissegundos = 1 segundo
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void onLoadForm(object sender, EventArgs e)
        {
            DateTime horaAtual = DateTime.Now;

            DateTime horaAbertura = new DateTime(horaAtual.Year, horaAtual.Month, horaAtual.Day, 7, 0, 0);// Define a hora limite para 7:00 AM
            DateTime horaFechamento = new DateTime(horaAtual.Year, horaAtual.Month, horaAtual.Day, 20, 0, 0);// Define a hora limite para 08:00 PM

            if (horaAtual <= horaAbertura && horaAtual >= horaFechamento)
            {
                MessageBox.Show("Estacionamento ainda não aberto!!");
                this.Close();
                return;
            }

        }
        private void TimerTick(object sender, EventArgs e)
        {
            // Atualizar a label de data e hora
            label1.Text = DateTime.Now.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 7)
            {//tamanho da placa menor que 8 caracteres;
                MessageBox.Show("Placa do veiculo com 7 caracteres!");
                textBox1.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string placa = "";
            DateTime entrada = DateTime.Now;


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {//campo da placa vazio
                MessageBox.Show("Entrada de veiculo não realizada! Revise o campo da placa.");
            }
            else if (textBox1.Text.Length < 7)
            {
                MessageBox.Show("Placa não pode ter menos que 7 caracteres!");
            }
            else
            {
                placa = textBox1.Text.ToString().ToUpper();

            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}