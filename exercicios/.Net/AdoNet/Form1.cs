using System.Data;

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregarDados_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            /*string sql = "select GCY_REGATE AS REGATE, LTRIM(GCY_NOME) AS NOME, GCY_REGGER AS CODPAC from GCY150 where GCY_FILIAL = '01' and D_E_L_E_T_ = '' order by LTRIM(GCY_REGATE) ";*/
            string sql = "select GCY_REGATE AS Regate, LTRIM(GCY_NOME) as Nome, GCY_REGGER as CodPaciente from GCY150 where GCY_FILIAL = '01' and D_E_L_E_T_ = '' and GCY_DATALT = '' order by LTRIM(GCY_NOME) ";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }
    }
}