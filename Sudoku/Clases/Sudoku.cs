using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Clases
{
    class Sudoku
    {
        private string fechaJuego;
        private string modalidadJuego;
        private bool estadoJuego;
        private string duracionJuego;

        public string GetfechaJuego()
        {
            return fechaJuego;
        }

        public string GetmodalidadJuego()
        {
            return modalidadJuego;
        }

        public bool GetestadoJuego()
        {
            return estadoJuego;
        }

        public string GetduracionJuego()
        {
            return duracionJuego;
        }

        public void SetfechaJuego(string newFechaJuego)
        {
            fechaJuego = newFechaJuego;
        }

        public void SetmodalidadJuego(string newModalidadJuego)
        {
            modalidadJuego = newModalidadJuego;
        }

        public void SetestadoJuego(bool newEstadoJuego)
        {
            estadoJuego = newEstadoJuego;
        }

        public void SetduracionJuego(string newDuracionJuego)
        {
            duracionJuego = newDuracionJuego;
        }

        public void elegirModalidad()
        {

        }

        public void consultarHistorial()
        {

        }

        public void jugar()
        {

        }
    }
}
