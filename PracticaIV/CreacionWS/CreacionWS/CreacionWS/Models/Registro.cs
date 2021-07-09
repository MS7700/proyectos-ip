using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreacionWS.Models
{
    public class Registro
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public double Sueldo { get; set; }
        public string Periodo { get; set; }

        public Registro(int id, string cedula, double sueldo, string periodo)
        {
            ID = id;
            Cedula = cedula;
            Sueldo = sueldo;
            Periodo = periodo;
        }
        public Registro()
        {

        }
    }
}