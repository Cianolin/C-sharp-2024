using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        int _larghezza, _altezza, _x, _y;

        public Rettangolo(int larghezza, int altezza,int x,int y)
        {
            
            Larghezza = larghezza;
            Altezza = altezza;
        }
        public int Larghezza {  get { return _larghezza; } set { _larghezza = value;}}
        public int Altezza { get { return _altezza; } set { _altezza = value;}}

        public int Area()
        {
            int area = Larghezza * Altezza;
            return area;
        }
    }
}
