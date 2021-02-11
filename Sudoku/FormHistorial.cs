using Sudoku.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
            historialUsuarios(dataGridView1, '&');
        }

        SudokuClass sudoku = SudokuClass.Getinstancia();

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }

        private void historialUsuarios(DataGridView tabla, char caracter)
        {
            string fileName = "Usuarios.txt";
            StreamReader reader = new StreamReader(fileName);
            string lineaActual = "";
            string[] datos = lineaActual.Split('&');
            bool booleano = true;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                lineaActual = reader.ReadLine();
                if(lineaActual != null)
                {
                    string[] arreglo = lineaActual.Split(caracter);
                    tabla.Rows.Add(arreglo);
                }
                else
                {
                    tabla.ColumnCount = lineaActual.Split(caracter).Length;
                    nombrarTitulos(tabla, lineaActual.Split(caracter));
                    booleano = false;
                }
            }
            while (!(lineaActual == null));

            reader.Close();
        }

        private void nombrarTitulos(DataGridView tabla, string[] titulos)
        {
            int x = 0;

            for(x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
