using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Clases
{
    class Archivos
    {
        private string fileName = "Usuarios.txt";
        private string fileNameP = "Partidas.txt";

        public string[] leerArchivoPartidas()
        {
            StreamReader reader = new StreamReader(fileNameP);
            string lineaActual = reader.ReadLine();
            string[] datos = lineaActual.Split('&');
            reader.Close();
            return datos;
        }

        public void escribirArchivoPartidas(Jugador jugador)
        {
            StreamWriter writer = File.AppendText(fileNameP);
            writer.WriteLine("{0}&{1}&{2}&{3}&{4}&{5}", jugador.Datos[0], jugador.Datos[1], jugador.Datos[2], jugador.Datos[3], jugador.Datos[4], jugador.Datos[5]);
            writer.Close();
        }

        public string leerArchivoUsuarios()
        {
            StreamReader reader = File.OpenText(fileName);

            string lineaActual = reader.ReadLine();

            string[] datos = lineaActual.Split('&');

            reader.Close();

            return datos[0];
        }

        public void escribirArchivoUsuarios(Jugador jugador)
        {
            StreamWriter writer = File.AppendText(fileName);
            writer.WriteLine("{0}", jugador.Usuario);
            writer.Close();
        }

        public void recorrerArchivoUsuarios(Jugador jugador)
        {
            StreamReader reader = File.OpenText(fileName);
            int finalizar = 0;
            while (finalizar == 0 && !reader.EndOfStream)
            {
                if (leerArchivoUsuarios() == jugador.Usuario)
                {
                    FormSudoku miforma = new FormSudoku();
                    miforma.ShowDialog();
                    finalizar++;
                    reader.Close();
                }
                else
                {
                    reader.Close();
                }
            }
        }

        public void leerArchivo(DataGridView tabla, char caracter)
        {
            StreamReader reader = new StreamReader(fileNameP);
            string lineaActual = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;
            do
            {
                lineaActual = reader.ReadLine();

                if (lineaActual != null)
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = lineaActual.Split(caracter).Length;
                        nombrarTitulos(tabla, lineaActual.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDataGridView(tabla, lineaActual, caracter, fila);
                        fila += 1;
                    }
                }
            } while (!(lineaActual == null));
            reader.Close();
        }

        public void agregarFilaDataGridView(DataGridView tabla, string lineaActual, char caracter, int fila)
        {
            string[] arreglo = lineaActual.Split(caracter);
            tabla.Rows.Add(arreglo);
        }

        public void nombrarTitulos(DataGridView tabla, string[] titulos)
        {
            int x = 0;

            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        public void cargarArchivos(DataGridView dataGridView1)
        {
            try
            {
                if (!string.IsNullOrEmpty(fileNameP))
                {
                    this.leerArchivo(dataGridView1, '&');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
