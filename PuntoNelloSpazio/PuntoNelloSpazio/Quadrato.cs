using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Quadrato : Rettangolo
    {
        public Quadrato(Punto p, int altezza, int larghezza) : base(p, larghezza, altezza)
        {
        }
    }
}
