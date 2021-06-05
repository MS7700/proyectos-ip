using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PracticaII
{
    /// <summary>
    /// Debe buscar los datos en la base de datos y escribirlos en un txt
    /// </summary>
    public class Escritura
    {
        string fileName = "NominaFerreteria.txt";
        private void writeFileLine(string folder, string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(Path.Combine(folder, fileName)))
            {
                w.WriteLine(pLine);
            }
        }
        private string getFolderPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return "";

        }
        public void CrearTXT(DateTime periodo)
        {
            string folder = getFolderPath();
            //Usar NominaDB.getNominaFerreteria(periodo) para coseguir listado de nomina de la base de datos
            NominaDB db = new NominaDB();
            List<Nomina> nomina = db.getNominaFerreteria(periodo);

            foreach (var registro in nomina)
            {
                string line = registro.RNC + "," +
                    registro.Periodo + "," +
                    registro.Sueldo + "," +
                    registro.Cedula + "," +
                    registro.Tipo_Moneda;

                try
                {
                    writeFileLine(folder,line);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Ha ocurrido un error en el proceso." + e);
                    throw;
                }
                
            }

            MessageBox.Show("El archivo txt fue creado exitosamente.");

        }
    }
}
