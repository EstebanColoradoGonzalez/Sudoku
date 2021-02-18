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
        SudokuClass sudoku = SudokuClass.Getinstancia();
        Jugador jugador = Jugador.Getinstancia();
        Archivos archivo = new Archivos();

        private string file = "";

        public FormHistorial()
        {
            InitializeComponent();
            labelUsuario.Text = jugador.Usuario;
            archivo.cargarArchivos(dataGridView1);
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
