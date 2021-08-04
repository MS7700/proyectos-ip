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

namespace RRHH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDepartamentos();
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int id_departamento = comboBox1.SelectedIndex;
            string departamento = comboBox1.Text;
            addEmpleado(nombre, id_departamento,departamento);

            getData();
        }

        private void getDepartamentos()
        {
            string connetionString = @"Data Source=LAPTOP-6NR7NCCT;Initial Catalog=RRHH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string com = "select * from Departamentos;";
            SqlDataAdapter adpt = new SqlDataAdapter(com, cnn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nombre_departamento";
            comboBox1.ValueMember = "id_departamento";
            cnn.Close();

        }

        private void addEmpleado(string nombre, int id_departamento, string departamento)
        {
            //string selectCXC = "select id_departamento from Departamentos where id_departamento = " + departamento + ";";
            string connetionString;
            //string selectCXC = "insert into factura values ('" + cliente + "', GETDATE(), " + montoPagar + ", " + montoRecibido + ");";
            SqlConnection cnn;
            connetionString = @"Data Source=LAPTOP-6NR7NCCT;Initial Catalog=RRHH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //SqlCommand command = new SqlCommand(selectCXC, cnn);
            //SqlDataReader reader = command.ExecuteReader();
            //int id_departamento = 0;
            //while (reader.Read())
            //{
            //    id_departamento = int.Parse(reader.GetValue(0).ToString());
            //}

            string insertEmpleado = "insert into Empleados (nombre_empleado,id_departamento,estado_empleado) values ('" + nombre + "'," + id_departamento+ ",1);";
            string insertDWH = @"insert into [LAPTOP-6NR7NCCT\MSSQLSERVER01].[DWH].[dbo].[Empleados] (nombre_empleado,departamento_empleado,estado_empleado) values ('" + nombre + "','" + departamento + "',1);";
            SqlCommand command = new SqlCommand(insertEmpleado + insertDWH, cnn);
            command.ExecuteNonQuery();

            cnn.Close();
        }

        private void getData()
        {
            string connetionString;
            string selectCXC = @"select id_empleado as ID, nombre_empleado AS Nombre, departamento_empleado AS Departamento, estado_empleado AS Estado from [LAPTOP-6NR7NCCT\MSSQLSERVER01].[DWH].[dbo].[Empleados];";
            SqlConnection cnn;
            connetionString = @"Data Source=LAPTOP-6NR7NCCT;Initial Catalog=RRHH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
