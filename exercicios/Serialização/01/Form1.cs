using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _01
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
            FileStream fs = new FileStream(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\dados.dat", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            MessageBox.Show("Serialização ocorrida com sucesso!!");
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Label vazia!!");
            }
            else
            {
                FileStream fs = new FileStream(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\dados.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                string msgDeserialize = bf.Deserialize(fs).ToString();
                MessageBox.Show(msgDeserialize);
                textBox1.Text = "";
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carro cr = new Carro();
            cr.lancamento = int.Parse(textBox3.Text);
            cr.modelo = textBox2.Text;
            cr.preco = double.Parse(textBox4.Text);

            FileStream fs = new FileStream(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\carro.xml", FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(typeof(Carro));

            xs.Serialize(fs, cr);
            MessageBox.Show("Serializado com sucesso");
            fs.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}