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

namespace CreacionXML
{

    public partial class Form1 : Form
    {
        BDPrueba BD = new BDPrueba();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeXML();
            MessageBox.Show("El archivo fue generado");
        }
        private void writeXML() {
            SqlConnection con = Conexion.getConnection();
            string sSQL = "select Asientos.noasiento, descripcion, fecha, Cuenta.nocuenta, DescripcionC, TipoMovimiento, Monto from movimiento\n" +
            "inner join Asientos on movimiento.noasiento = Asientos.noasiento\n" +
            "inner join Cuenta on movimiento.nocuenta = Cuenta.nocuenta";
            SqlDataAdapter oda = new SqlDataAdapter(sSQL, con);
            DataTable oTb = new DataTable();
            oTb.TableName = "Asientos";
            oda.Fill(oTb);
            oTb.WriteXml(@"X:\Cuentas.xml", XmlWriteMode.WriteSchema);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.ReadXml("X:\\Cuentas.xml");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Remove("DescripcionC");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[1, e.RowIndex].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
