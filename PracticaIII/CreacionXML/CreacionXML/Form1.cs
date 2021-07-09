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
            oTb.WriteXml(@"X:\Cuentas.xml", true);
            con.Close();
        }
    }
}
