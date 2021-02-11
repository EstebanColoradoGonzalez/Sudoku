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
            crearCeldas();
            labelUsuario.Text = jugador.Usuario;
        }

        SudokuCeldas[,] celdas = new SudokuCeldas[9, 9];

        private void cargarDatos(string[] datos)
        {
            jugador.Usuario = datos[0];
            jugador.Datos[0] = datos[1];
        }



        private void crearCeldas()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    celdas[i, j] = new SudokuCeldas();
                    celdas[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    celdas[i, j].Size = new Size(40, 40);
                    celdas[i, j].ForeColor = SystemColors.ControlDarkDark;
                    celdas[i, j].Location = new Point(i * 40, j * 40);
                    celdas[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.AntiqueWhite;
                    celdas[i, j].FlatStyle = FlatStyle.Flat;
                    celdas[i, j].FlatAppearance.BorderColor = Color.Black;
                    celdas[i, j].x = i;
                    celdas[i, j].y = j;

                    celdas[i, j].KeyPress += celdaPresionada;

                    panel1.Controls.Add(celdas[i, j]);
                }
            }
        }

        private void celdaPresionada(object sender, KeyPressEventArgs e)
        {
            var celda = sender as SudokuCeldas;

            if (celda.estado)
                return;

            int value;

            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                    celda.limpiar();
                else
                    celda.Text = value.ToString();

                celda.ForeColor = SystemColors.ControlDarkDark;
                marcarCasillasMalas();
            }
        }

        private void IniciarNuevoJuego()
        {
            cargarValores();

            int contador = 0;

            if (modoNormal.Checked)
                contador = 45;
            else if (modoDificil.Checked)
                contador = 30;
            else if (modoMuyDificil.Checked)
                contador = 15;
            else if (modoFacil.Checked)
                contador = 60;
            else if (modoMuyFacil.Checked)
                contador = 70;
            else if (modoExperto.Checked)
                contador = 5;

            mostrarValoresAleatorios(contador);
        }

        private void mostrarValoresAleatorios(int contador)
        {
            for (int i = 0; i < contador; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                celdas[rX, rY].Text = celdas[rX, rY].valor.ToString();
                celdas[rX, rY].ForeColor = Color.Black;
                celdas[rX, rY].estado = true;
            }
        }

        private void cargarValores()
        {
            foreach (var celda in celdas)
            {
                celda.valor = 0;
                celda.limpiar();
            }

            encontrarProximoValor(0, -1);
        }

        Random random = new Random();

        private bool encontrarProximoValor(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            var valor = 0;
            var numerosIzquierda = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (numerosIzquierda.Count < 1)
                {
                    celdas[i, j].valor = 0;
                    return false;
                }

                valor = numerosIzquierda[random.Next(0, numerosIzquierda.Count)];
                celdas[i, j].valor = valor;

                numerosIzquierda.Remove(valor);
            }
            while (!numeroValido(valor, i, j) || !encontrarProximoValor(i, j));

            return true;
        }

        private bool numeroValido(int valor, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && celdas[x, i].valor == valor)
                    return false;

                if (i != x && celdas[i, y].valor == valor)
                    return false;
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && celdas[i, j].valor == valor)
                        return false;
                }
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oSW.Start();
            timer1.Enabled = true;
            IniciarNuevoJuego();
        }

        public void FinalizoTiempo()
        {
            string hora, minuto, segundo;

            hora = textBoxH.Text;
            minuto = textBoxM.Text;
            segundo = textBoxS.Text;
            if (hora == textBoxHora.Text && minuto == textBoxMinuto.Text && segundo == textBoxSegundo.Text)
            {
                oSW.Reset();
                buttonFinalizar.PerformClick();
                buttonResultado.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            textBoxHora.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            textBoxMinuto.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            textBoxSegundo.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            FinalizoTiempo();
        }

        private void FormSudoku_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonJugarSinT_Click(object sender, EventArgs e)
        {
            IniciarNuevoJuego();
            escrbirFecha();
        }

        private void escrbirFecha()
        {
            sudoku.FechaJuego = dateTimePicker1.Value.ToString();
            jugador.Datos[0] = sudoku.FechaJuego;
            string fileName = "Usuarios.txt";
            string fileCopia = "CopiaUsuarios.txt";
            StreamReader reader = new StreamReader(fileName);
            StreamWriter writer = File.AppendText(fileCopia);

            while (!reader.EndOfStream)
            {
                string lineaActual = reader.ReadLine();
                string[] datos = lineaActual.Split('&');

                if(datos[0] == jugador.Usuario)
                {
                    writer.WriteLine("{0}&{1}", jugador.Usuario, jugador.Datos[0]);
                    datos[0] = jugador.Usuario;
                    //datos[1] = jugador.Datos[0];
                    //cargarDatos(datos);
                }
                else
                {
                    writer.WriteLine(lineaActual);
                }
                
            }

            reader.Close();
            writer.Close();

            File.Replace(fileCopia, fileName, null, true);
        }

        private void marcarCasillasMalas()
        {
            var celdasIncorrectas = new List<SudokuCeldas>();

            foreach (var celda in celdas)
            {
                if (!string.Equals(celda.valor.ToString(), celda.Text))
                {
                    celdasIncorrectas.Add(celda);
                }
            }

            if (celdasIncorrectas.Any())
            {
                celdasIncorrectas.ForEach(x => x.ForeColor = Color.Red);
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            var celdasIncorrectas = new List<SudokuCeldas>();

            foreach (var celda in celdas)
            {
                if (!string.Equals(celda.valor.ToString(), celda.Text))
                {
                    celdasIncorrectas.Add(celda);
                }
            }

            if (celdasIncorrectas.Any())
            {
                celdasIncorrectas.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Has Perdido Socio");
            }
            else
            {
                MessageBox.Show("Has Ganado Socio");
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            foreach (var cell in celdas)
            {
                if (cell.estado == false)
                    cell.limpiar();
            }
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            mostrarValoresAleatorios(700);
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
    }
}
