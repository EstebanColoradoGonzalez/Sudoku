using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Clases
{
    class SudokuClass
    {
        private static SudokuClass _instancia;
        private Jugador jugador = Jugador.Getinstancia();
        private Archivos archivo = new Archivos();
        private string fechaJuego;
        private string modalidadJuego;
        private string estadoJuego;
        private string duracionJuego;
        private double puntajeJuego;
        Random random = new Random();
        SudokuCeldas[,] celdas = new SudokuCeldas[9, 9];

        public static SudokuClass Getinstancia()
        {
            if (_instancia == null)
            {
                return _instancia = new SudokuClass();
            }
            else
                return _instancia;
        }

        public string FechaJuego
        {
            get { return fechaJuego; }
            set
            {
                this.fechaJuego = value;

            }
        }

        public double PuntajeJuego
        {
            get { return puntajeJuego; }
            set
            {
                this.puntajeJuego = value;

            }
        }

        public string EstadoJuego
        {
            get { return estadoJuego; }
            set
            {
                this.estadoJuego = value;

            }
        }

        public string DuracionJuego
        {
            get { return duracionJuego; }
            set
            {
                this.duracionJuego = value;

            }
        }

        public string ModalidadJuego
        {
            get { return modalidadJuego; }
            set
            {
                this.modalidadJuego = value;
            }
        }

        public void inciarSesion(TextBox textBoxUsuario)
        {
            int contador = 0;

            if (textBoxUsuario.Text != "")
            {
                jugador.Usuario = textBoxUsuario.Text.ToLower();

                if (jugador.Usuario != archivo.leerArchivoUsuarios())
                {
                    archivo.escribirArchivoUsuarios(jugador);
                    FormSudoku miforma = new FormSudoku();
                    miforma.ShowDialog();
                }
                else
                {
                    archivo.recorrerArchivoUsuarios(jugador);
                }
            }
            else
            {
                contador++;
                if (contador == 0)
                {
                    MessageBox.Show("Debe Escribir un Usuario", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void crearCeldas(Panel panel1)
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

        public void marcarCasillasMalas()
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

        public void celdaPresionada(object sender, KeyPressEventArgs e)
        {
            var celda = sender as SudokuCeldas;

            if (celda.estado)
            {
                return;
            }
                
            int value;

            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                {
                    celda.limpiar();
                }   
                else
                {
                    celda.Text = value.ToString();
                }

                celda.ForeColor = SystemColors.ControlDarkDark;
                marcarCasillasMalas();
            }
        }

        public void IniciarNuevoJuego(ToolStripMenuItem modoNormal, ToolStripMenuItem modoDificil, ToolStripMenuItem modoMuyDificil, ToolStripMenuItem modoExperto, ToolStripMenuItem modoFacil, ToolStripMenuItem modoMuyFacil)
        {
            cargarValores();

            int contador = 0;

            if (modoNormal.Checked)
            {
                contador = 45;
            }
            else if (modoDificil.Checked)
            {
                contador = 30;
            }  
            else if (modoMuyDificil.Checked)
            {
                contador = 15;
            }
            else if (modoFacil.Checked)
            {
                contador = 60;
            }
            else if (modoMuyFacil.Checked)
            {
                contador = 70;
            } 
            else if (modoExperto.Checked)
            {
                contador = 5;
            }

            mostrarValoresAleatorios(contador);
        }

        public void mostrarValoresAleatorios(int contador)
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

        public void cargarValores()
        {
            foreach (var celda in celdas)
            {
                celda.valor = 0;
                celda.limpiar();
            }

            encontrarProximoValor(0, -1);
        }

        public bool encontrarProximoValor(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                {
                    return true;
                } 
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

        public bool numeroValido(int valor, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && celdas[x, i].valor == valor)
                {
                    return false;
                }

                if (i != x && celdas[i, y].valor == valor)
                {
                    return false;
                } 
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && celdas[i, j].valor == valor)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void reiniciarJuego()
        {
            foreach (var cell in celdas)
            {
                if (cell.estado == false)
                {
                    cell.limpiar();
                }
            }
        }

        private string sacarPuntaje()
        {
            var celdasIncorrectas = new List<SudokuCeldas>();
            int incrementador = 0;

            foreach (var celda in celdas)
            {
                if (!string.Equals(celda.valor.ToString(), celda.Text))
                {
                    celdasIncorrectas.Add(celda);

                    if (celdasIncorrectas.Any())
                    {
                        incrementador++;
                    }
                }
            }

            PuntajeJuego = (incrementador * 100) / 81;
            return PuntajeJuego.ToString();
        }

        private void EscribirDatos(bool estado, ToolStripMenuItem modoNormal, ToolStripMenuItem modoDificil, ToolStripMenuItem modoMuyDificil, ToolStripMenuItem modoExperto, ToolStripMenuItem modoFacil, ToolStripMenuItem modoMuyFacil, string fecha, Stopwatch oSW, TextBox textBoxHora, TextBox textBoxMinuto, TextBox textBoxSegundo)
        {
            FechaJuego = fecha;

            if (modoNormal.Checked)
            {
                ModalidadJuego = "Modo Normal";
            }
            else if (modoDificil.Checked)
            {
                ModalidadJuego = "Modo Difil";
            }
            else if (modoMuyDificil.Checked)
            {
                ModalidadJuego = "Modo Muy Dificil";
            }  
            else if (modoFacil.Checked)
            {
                ModalidadJuego = "Modo Facil";
            }  
            else if (modoMuyFacil.Checked)
            {
                ModalidadJuego = "Modo Muy Facil";
            }  
            else if (modoExperto.Checked)
            {
                ModalidadJuego = "Modo Experto";
            }

            if (estado == true)
            {
                EstadoJuego = "Ganado";
            }
            else
            {
                EstadoJuego = "Perdido";
            }

            oSW.Reset();

            DuracionJuego = textBoxHora.Text + ":" + textBoxMinuto.Text + ":" + textBoxSegundo.Text;

            jugador.Datos[0] = FechaJuego;
            jugador.Datos[1] = ModalidadJuego;
            jugador.Datos[2] = EstadoJuego;
            jugador.Datos[3] = DuracionJuego;
            jugador.Datos[4] = sacarPuntaje();
            jugador.Datos[5] = jugador.Usuario;

            archivo.escribirArchivoPartidas(jugador);
        }

        public void finalizarJuego(ToolStripMenuItem modoNormal, ToolStripMenuItem modoDificil, ToolStripMenuItem modoMuyDificil, ToolStripMenuItem modoExperto, ToolStripMenuItem modoFacil, ToolStripMenuItem modoMuyFacil, string fecha, Stopwatch oSW, TextBox textBoxHora, TextBox textBoxMinuto, TextBox textBoxSegundo)
        {
            var celdasIncorrectas = new List<SudokuCeldas>();
            bool estado;

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
                estado = false;
            }
            else
            {
                MessageBox.Show("Has Ganado Socio");
                estado = true;
            }

            EscribirDatos(estado, modoNormal, modoDificil, modoMuyDificil, modoExperto, modoFacil, modoMuyFacil, fecha, oSW, textBoxHora, textBoxMinuto, textBoxSegundo);
        }

        public void finalizoTiempo(TextBox textBoxHora, TextBox textBoxMinuto, TextBox textBoxSegundo, TextBox textBoxH, TextBox textBoxM, TextBox textBoxS, Stopwatch oSW, Button buttonFinalizar, Button buttonResultado)
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
    }
}
