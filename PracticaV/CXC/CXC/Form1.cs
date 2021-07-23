using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            string connetionString;
            string selectCXC = "SELECT NOMBRE_CLIENTE AS Cliente, MONTO as Monto, PAGADO as Pagado, SALDO as Saldo FROM CXC;";
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Farmacia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCXC, cnn);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }
    }
}
