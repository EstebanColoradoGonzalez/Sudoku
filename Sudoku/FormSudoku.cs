using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sudoku.Clases;
using System.IO;

namespace Sudoku
{
    public partial class FormSudoku : Form
    {
        Stopwatch oSW = new Stopwatch();
        Jugador jugador = Jugador.Getinstancia();
        SudokuClass sudoku = SudokuClass.Getinstancia();

        public FormSudoku()
        {
            InitializeComponent();
            sudoku.crearCeldas(panel1);
            labelUsuario.Text = jugador.Usuario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oSW.Start();
            timer1.Enabled = true;
            sudoku.IniciarNuevoJuego(modoNormal, modoDificil, modoMuyDificil, modoExperto, modoFacil, modoMuyFacil);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            textBoxHora.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            textBoxMinuto.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            textBoxSegundo.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            sudoku.finalizoTiempo(textBoxHora, textBoxMinuto, textBoxSegundo, textBoxH, textBoxM, textBoxS, oSW, buttonFinalizar, buttonResultado);
        }

        private void FormSudoku_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonJugarSinT_Click(object sender, EventArgs e)
        {
            oSW.Start();
            timer2.Enabled = true;
            sudoku.IniciarNuevoJuego(modoNormal, modoDificil, modoMuyDificil, modoExperto, modoFacil, modoMuyFacil);
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();

            sudoku.finalizarJuego(modoNormal, modoDificil, modoMuyDificil, modoExperto, modoFacil, modoMuyFacil, fecha, oSW, textBoxHora, textBoxMinuto, textBoxSegundo);
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            sudoku.reiniciarJuego();
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            sudoku.mostrarValoresAleatorios(700);
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial miforma = new FormHistorial();
            miforma.ShowDialog();
        }

        private void menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modoMuyFacil_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = true;
            modoFacil.Checked = false;
            modoNormal.Checked = false;
            modoDificil.Checked = false;
            modoMuyDificil.Checked = false;
            modoExperto.Checked = false;
        }

        private void modoFacil_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = false;
            modoFacil.Checked = true;
            modoNormal.Checked = false;
            modoDificil.Checked = false;
            modoMuyDificil.Checked = false;
            modoExperto.Checked = false;
        }

        private void modoNormal_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = false;
            modoFacil.Checked = false;
            modoNormal.Checked = true;
            modoDificil.Checked = false;
            modoMuyDificil.Checked = false;
            modoExperto.Checked = false;
        }

        private void modoDificil_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = false;
            modoFacil.Checked = false;
            modoNormal.Checked = false;
            modoDificil.Checked = true;
            modoMuyDificil.Checked = false;
            modoExperto.Checked = false;
        }

        private void modoMuyDificil_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = false;
            modoFacil.Checked = false;
            modoNormal.Checked = false;
            modoDificil.Checked = false;
            modoMuyDificil.Checked = true;
            modoExperto.Checked = false;
        }

        private void modoExperto_Click(object sender, EventArgs e)
        {
            modoMuyFacil.Checked = false;
            modoFacil.Checked = false;
            modoNormal.Checked = false;
            modoDificil.Checked = false;
            modoMuyDificil.Checked = false;
            modoExperto.Checked = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            textBoxHora.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            textBoxMinuto.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            textBoxSegundo.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
