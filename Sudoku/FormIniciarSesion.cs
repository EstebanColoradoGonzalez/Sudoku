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
            InciarSesion();
        }

        Jugador jugador = new Jugador();

        private void InciarSesion()
        {
            if (textBoxUsuario.Text != "")
            {
                string fileName = "Usuarios.txt";
                StreamReader reader = File.OpenText(fileName);
                int finalizar = 0;

                while (finalizar == 0 && !reader.EndOfStream)
                {
                    string lineaActual = reader.ReadLine();

                    string[] datos = lineaActual.Split('&');

                    if (textBoxUsuario.Text != datos[0])
                    {
                        jugador.Setusuario(textBoxUsuario.Text);

                        StreamWriter writer = File.AppendText(fileName);

                        writer.WriteLine("{0}", jugador.Getusuario());
                        writer.Close();
                    }
                    else
                    {
                        jugador.Setusuario(textBoxUsuario.Text.ToLower());
                        int contador = 0;

                        if (datos[0] == jugador.Getusuario())
                        {
                            reader.Close();
                            FormSudoku miforma = new FormSudoku();
                            miforma.ShowDialog();
                            finalizar++;
                        }

                        reader.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe Escribir un Usuario", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
