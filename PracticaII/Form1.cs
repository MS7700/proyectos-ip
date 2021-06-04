using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaII
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearTXT_Click(object sender, EventArgs e)
        {
            Escritura escritura = new Escritura();
            //Coge la fecha que se selecciona para hallar el periodo
            DateTime periodo = dateTimePicker1.Value;
            escritura.CrearTXT(periodo);
            NominaDB db = new NominaDB();
            List<Nomina> myNomina = db.getNominaFerreteria(dateTimePicker1.Value);
            label2.Text = myNomina.Count().ToString() + " " + myNomina.First().Sueldo;

            db.InsertToNominaTSS(myNomina.First());

        }

        private void btnLeerTXT_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
