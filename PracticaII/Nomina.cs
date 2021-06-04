using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaII
{
    public class Nomina
    {
        public Nomina()
        {
        }

        public Nomina(string rNC, string periodo, string sueldo, string cedula, string tipo_Moneda)
        {
            RNC = rNC;
            Periodo = periodo;
            Sueldo = sueldo;
            Cedula = cedula;
            Tipo_Moneda = tipo_Moneda;
        }

        public string RNC { get; set; }
        public string Periodo { get; set; }
        public string Sueldo { get; set; }
        public string Cedula { get; set; }
        public string Tipo_Moneda { get; set; }
    }
}
