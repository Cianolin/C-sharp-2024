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
        int  _x, _y;
        public Punto(int x, int y)
        {
            X= x;
            Y = y;
        }
        public Punto()//defualt
        {
            X = 0;
            Y = 0;
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y;} set { _y = value; } }
        public override string  ToString()
        {
            return string.Format($"Punto X: {X}\nPunto Y: {Y}");
        }
    }
}
