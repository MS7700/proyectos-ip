using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static PracticaII.Nomina;
using static PracticaII.NominaDB;

namespace PracticaII
{
    class Lectura
    {

        public void LeerTXTaDB()
        {
            // InsertToNominaTSS(Nomina nomina);
            //Crear un while lopp con los datos que se lea del TXT, cada registro es una Nomina
            //Usar dentro del loop NominaDB.InsertToNominaTSS(Nomina nomina) con cada Nomina
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var linea = string.Empty;
            var nominaDB = new NominaDB();

            //Ventana para elegir archivo.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        Nomina nomina = new Nomina();
                        try
                        {
                            //Loop donde se leerá línea por línea los registros.
                            while ((linea = reader.ReadLine()) != null)
                            {
                                string[] registro = linea.Split(',');
                                nomina.RNC = registro[0];
                                nomina.Periodo = registro[1];
                                nomina.Sueldo = registro[2];
                                nomina.Cedula = registro[3];
                                nomina.Tipo_Moneda = registro[4];

                                nominaDB.InsertToNominaTSS(nomina);
                            }
                            MessageBox.Show("Los datos fueron leídos y cargados a la base de datos satisfactoriamente.");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ha ocurrido un error en el proceso." + e);
                            throw;
                        }
                      
                    }
                }
            }
            
        }
    }
}
