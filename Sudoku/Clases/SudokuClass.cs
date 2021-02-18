using System;
using System.Collections;
using System.Collections.Generic;
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

        public static SudokuClass Getinstancia()
        {
            if (_instancia == null)
            {
                return _instancia = new SudokuClass();
            }
            else
                return _instancia;
        }
        private string fechaJuego;
        private string modalidadJuego;
        private string estadoJuego;
        private string duracionJuego;
        private double puntajeJuego;
        private Jugador jugador;

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
    }
}
