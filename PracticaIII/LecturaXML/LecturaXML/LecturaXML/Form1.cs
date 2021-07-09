using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecturaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Debe hacer aparecer la pantalla de seleccionar archivo, al escoger un archivo 
        //este debe guardarse en un listado de asientos
        //Luego se debe proyectar en pantalla los asientos uno a uno usando txtNumeroAsiento,
        //txtFecha, txtDescripcion y dgvMovimientos (aquí es donde se van a colocar los movimientos
        //los vas a tener que convertir en un DataTable y pasarselo a su DataSource)
        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            
        }

        //Al hacer clic cambia los valores en pantallas por los de los asientos anteriores y siguientes, respectivamente
        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
