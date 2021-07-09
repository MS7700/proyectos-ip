using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CreacionXML
{
    class Conexion
    {
        public static SqlConnection getConnection() {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-11AN0PI\\SQLEXPRESS;Initial Catalog=practicaiii;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            return con;
        
        }
    }
}
