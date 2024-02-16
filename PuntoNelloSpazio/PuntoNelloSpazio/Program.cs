using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto(Console.WindowHeight, Console.WindowWidth, 12, 20);
            Rettangolo rettangolo=new Rettangolo(punto);
            Console.WriteLine(punto.ToString());
            Console.WriteLine(rettangolo.ToString());
            Console.ReadLine();
        }
    }
}
