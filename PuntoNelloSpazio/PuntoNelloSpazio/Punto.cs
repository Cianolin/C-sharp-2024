using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Punto
    {
        int _maxAlt, _maxLargh, _x, _y;
        Punto(int maxAlt, int maxLargh, int x, int y)
        {
            MaxAlt = maxAlt;
            MaxLargh = maxLargh;
            X= x;
            Y = y;
        }
        public int MaxAlt {  get { return _maxAlt; } set { _maxAlt = value; } }
        public int MaxLargh {  get { return _maxLargh; } set { _maxLargh = value; } }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y;} set { _y = value; } }
        public void SetPoint()
        {
            
        }
    }
}
