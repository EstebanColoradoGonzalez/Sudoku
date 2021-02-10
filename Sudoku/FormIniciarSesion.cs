﻿using Sudoku.Clases;
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

        Jugador jugador = new Jugador();

        private void Escribir(Jugador jugador, string fileName)
        {
            
            StreamWriter writer = File.AppendText(fileName);
            writer.WriteLine("{0}", jugador.Getusuario());
            writer.Close();
        }

        private void InciarSesion()
        {
            int contador = 0;
            if (textBoxUsuario.Text != "")
            {
                string fileName = "Usuarios.txt";
                jugador.Setusuario(textBoxUsuario.Text.ToLower());

                StreamReader reader = File.OpenText(fileName);
                string lineaActual = reader.ReadLine();

                string[] datos = lineaActual.Split('&');

                int finalizar = 0;

                if(jugador.Getusuario() != datos[0])
                {
                    reader.Close();
                    StreamWriter writer = File.AppendText(fileName);
                    writer.WriteLine("{0}", jugador.Getusuario());
                    FormSudoku miforma = new FormSudoku();
                    miforma.ShowDialog();
                    writer.Close();

                }
                else
                {
                    while (finalizar == 0 && !reader.EndOfStream)
                    {

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
                contador++;
                if (contador == 0)
                {
                    MessageBox.Show("Debe Escribir un Usuario", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
