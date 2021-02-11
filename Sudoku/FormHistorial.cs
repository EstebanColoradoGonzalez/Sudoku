using Sudoku.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        SudokuClass sudoku = SudokuClass.Getinstancia();

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
