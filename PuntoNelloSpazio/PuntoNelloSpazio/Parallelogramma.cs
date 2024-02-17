using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Parallelogramma: Rettangolo
    {
        int _profontita;

        public Parallelogramma(int profontita, Punto point) : base(point)
        {
            Profontita = profontita;
        }
        public int Profontita
        {
            get { return _profontita; }
            set { _profontita = value;}
        }
    }
}
