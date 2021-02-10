using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Clases
{
    class Jugador
    {
        private string usuario;
        private string nombre;
        private double[] ranking = new double[6];

        public string Getusuario()
        {
            return usuario;
        }

        public string Getnombre()
        {
            return nombre;
        }

        public double[] Getranking()
        {
            return ranking;
        }

        public void Setusuario(string newUsuario)
        {
            usuario = newUsuario;
        }

        public void Setnombre(string newUsuario)
        {
            usuario = newUsuario;
        }
        public void consultarRanking()
        {

        }
    }
}
