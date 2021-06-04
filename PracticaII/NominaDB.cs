using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity;

namespace PracticaII
{
    class NominaDB
    {
        //Cambiar connectionString dependiendo de su base de datos
        private string connectionString = "Data Source=LAPTOP-6NR7NCCT;Initial Catalog=PRACTICA_2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public NominaDB()
        {
            
        }
        
        public List<Nomina> getNominaFerreteria(DateTime periodo)
        {
            string periodoString = periodo.ToString("MMyyyy");
            

            List<Nomina> nominas = new List<Nomina>();
            try
            {
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    string select = "Select sueldo_bruto, cedula from nominaFerreteria where periodo='" + periodoString + "';";
                       
                    SqlCommand cmd = new SqlCommand(select, connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nomina nomina = new Nomina();
                            nomina.RNC = "101009918";
                            nomina.Periodo = periodoString;
                            nomina.Tipo_Moneda = "DOP";
                            nomina.Sueldo = reader[0].ToString();
                            nomina.Cedula = reader[1].ToString();

                            nominas.Add(nomina);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return nominas;
        }

        public void InsertToNominaTSS(Nomina nomina)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
               connectionString))
                {
                    
                    string insert = "INSERT INTO nominaTSS (RNC, periodo, sueldo_bruto, cedula, tipo_moneda) values('" +
                        nomina.RNC + "','" + nomina.Periodo + "'," + nomina.Sueldo + ",'" + nomina.Cedula + "','" + nomina.Tipo_Moneda
                        + "')";
                    SqlCommand cmd = new SqlCommand(insert, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
