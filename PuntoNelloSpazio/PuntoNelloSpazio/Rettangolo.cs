using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        int _larghezza, _altezza;

        public Rettangolo(Punto point)
        {
            Larghezza= point.MaxLargh-point.X; 
            Altezza=point.MaxLargh-point.Y;
        }
        public int Larghezza {  get { return _larghezza; } set { _larghezza = value;}}
        public int Altezza { get { return _altezza; } set { _altezza = value;}}

        public int Area()
        {
            int area = Larghezza * Altezza;
            return area;
        }
        public override string ToString()
        {
            return string.Format($"Larghezza: {Larghezza}\nAltezza: {Altezza}\nArea: {Area()}");
        }
    }
}
