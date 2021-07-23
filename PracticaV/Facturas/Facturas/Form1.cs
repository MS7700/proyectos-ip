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

namespace Facturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nudBalance.Value = (decimal) getBalance(txtNombre.Text);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cliente = txtNombre.Text;
            decimal montoPagar = nudMontoPagar.Value;
            decimal montoRecibido = nudMontoRecibido.Value;
            addMontoFactura(cliente, montoPagar.ToString(), montoRecibido.ToString());
            nudBalance.Value = (decimal)getBalance(txtNombre.Text);
        }

        private double getBalance(string cliente)
        {
            string connetionString;
            string selectCXC = "select SALDO from CXC where NOMBRE_CLIENTE = '" + cliente + "';";
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Farmacia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command = new SqlCommand(selectCXC, cnn);
            SqlDataReader reader = command.ExecuteReader();
            double balance = 0;
            while (reader.Read())
            {
                balance = Double.Parse(reader.GetValue(0).ToString());
            }
            cnn.Close();
            return balance;
        }

        private void addMontoFactura(string cliente, string montoPagar, string montoRecibido)
        {
            
            string connetionString;
            string selectCXC = "insert into factura values ('"+ cliente +"', GETDATE(), "+ montoPagar +", "+ montoRecibido + ");";
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Farmacia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command = new SqlCommand(selectCXC, cnn);
            command.ExecuteNonQuery();
            
            cnn.Close();
        }
    }
}
