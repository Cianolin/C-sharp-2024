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

        public Rettangolo(Punto point,int larghezza,int altezza)
        {
            Larghezza= larghezza; 
            Altezza=altezza;
        }
        public int Larghezza {  get { return _larghezza; } set { _larghezza = value;}}
        public int Altezza { get { return _altezza; } set { _altezza = value;}}

        public int Area()
        {
                return Larghezza * Altezza;
        }
        public int Perimetro()
        {
            return (Larghezza + Altezza) * 2;
        }
        public override string ToString()
        {
            return string.Format($"Larghezza: {Larghezza}\nAltezza: {Altezza}\nArea: {Area()}");
        }
    }
}
