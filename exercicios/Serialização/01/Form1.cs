using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
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
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            XmlSerializer xs = new XmlSerializer(typeof(Carro));
            FileStream fs = new FileStream(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\carro.xml", FileMode.Open);
            Carro car;
            car = (Carro)xs.Deserialize(fs);
            textBox2.Text = car.modelo;
            textBox3.Text = car.lancamento.ToString();
            textBox4.Text = car.preco.ToString();
        }

        private void serializarJSON_Click(object sender, EventArgs e)
        {
            Carro cr = new Carro();
            cr.lancamento = int.Parse(textBox3.Text);
            cr.modelo = textBox2.Text;
            cr.preco = double.Parse(textBox4.Text);

            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\carro.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, cr);
            MessageBox.Show("Serialização JSON ocorreu com sucesso!!");
            sw.Close();
            writer.Close();

        }

        private void deserializarJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\bpl_\source\repos\AcademiaAtos\exercicios\Serialização\01\carro.json");
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            Carro cr = JsonConvert.DeserializeObject<Carro>(json);
            label4.Text = cr.modelo;
            label5.Text = cr.lancamento.ToString();
            label6.Text = cr.preco.ToString();
            MessageBox.Show("Deserialização JSON ocorreu com sucesso!");

        }
    }
}