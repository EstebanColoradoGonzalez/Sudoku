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
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void FormIniciarSesion_Load(object sender, EventArgs e)
        {
            
        }

        Jugador jugador = Jugador.Getinstancia();

        Archivos archivo = new Archivos();

        private void InciarSesion()
        {
            int contador = 0;

            if (textBoxUsuario.Text != "")
            {
                jugador.Usuario = textBoxUsuario.Text.ToLower();

                if(jugador.Usuario != archivo.leerArchivoUsuarios())
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

        private void cargarDatos(string[] datos)
        {
            jugador.Usuario = datos[0];
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIniciarJuego_Click(object sender, EventArgs e)
        {
            InciarSesion();
        }
    }
}
