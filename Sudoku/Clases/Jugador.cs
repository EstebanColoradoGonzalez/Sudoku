using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Clases
{
    class Jugador
    {
        private static Jugador _instancia;

        public static Jugador Getinstancia()
        {
            if (_instancia == null)
            {
                return _instancia = new Jugador();
            }
            else
                return _instancia;
        }

        private string usuario;
        private double[] ranking = new double[6];

        public string Usuario
        {
            get { return usuario; }
            set
            {
                this.usuario = value;

            }
        }

        public double[] Ranking
        {
            get { return ranking; }
            set
            {
                this.ranking = value;

            }
        }

        public void consultarRanking()
        {

        }
    }
}
