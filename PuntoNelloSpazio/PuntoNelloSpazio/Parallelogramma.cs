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

        public Parallelogramma(Punto point,int profontita, int larghezza, int altezza) : base(point, larghezza, altezza)
        {
            Profontita = profontita;
        }
        public int Profontita
        {
            get { return _profontita; }
            set { _profontita = value;}
        }
        public int Volume()
        {
            return Profontita*Altezza*Larghezza;
        }
    }
}
