using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Clases
{
    class SudokuCeldas : Button
    {
        public int valor { get; set; }
        public bool estado { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void limpiar()
        {
            this.Text = string.Empty;
            this.estado = false;
        }
    }
}
