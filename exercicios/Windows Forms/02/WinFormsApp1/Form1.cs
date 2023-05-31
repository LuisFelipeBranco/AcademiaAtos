using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serializar = textBox1.Text;
            FileStream fs = new FileStream(@"C:\Users\luis.felipe\Documents\dados.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            fs.Close();
            MessageBox.Show("Serializado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\luis.felipe\Documents\dados.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDeserializar = "";
            msgDeserializar = bf.Deserialize(fs).ToString();
            MessageBox.Show($"Mensagem deserializada com sucesso!!");
            label1.Text = msgDeserializar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox2.Text;
            p.idade = int.Parse(textBox3.Text);
            p.salario = double.Parse(textBox4.Text);

            FileStream fs = new FileStream(@"C:\Users\luis.felipe\Documents\pessoa.dat", FileMode.Create);
            //34:18


        }
    }
}