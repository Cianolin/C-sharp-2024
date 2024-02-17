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
            int x, y,choice;
            Punto point=new Punto();
            Console.WriteLine("Scegli come definire le coordinate");
            Console.WriteLine("[1]Inserire le coordinate\n[2]Utilizzare coordinate di default");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Inserisci le coordinate del punto");
                    Console.WriteLine("Punto X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Punto Y");
                    int.TryParse(Console.ReadLine(), out y);
                    point=DefinirePunto(x,y);
                    break;
                case 2:
                    Console.WriteLine("Coordinate di default inserite nel punto");
                    point = DefaultPunto();
                    break;
            }
            Console.WriteLine("[1]Rettangolo\n[2]Quadrato\n[3]Parallelogramma");
            int.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1:
                    Rettangolo rettangolo = new Rettangolo(point, 20, 20);

                    Console.WriteLine($"Il tuo rettangololo ha:\nArea => {rettangolo.Area()}\nPerimetro => {rettangolo.Perimetro()}");
                    break;

                case 2:
                    Quadrato quadrato = new Quadrato(point, 20, 20);

                    Console.WriteLine($"Il tuo quadrato ha:\nArea => {quadrato.Area()}\nPerimetro => {quadrato.Perimetro()}");
                    break;

                case 3:
                    Parallelogramma parallelogramma = new Parallelogramma(point, 20, 20, 2);

                    Console.WriteLine($"Il tuo parallelogramma ha:\nArea => {parallelogramma.Area()}\nPerimetro => {parallelogramma.Perimetro()}\nVolume => {parallelogramma.Volume()}");
                    break;
            }
            Console.ReadLine();
        }
        static Punto DefinirePunto(int x, int y)
        {
            Punto punto = new Punto(x, y);
            return punto;
        }
        static Punto DefaultPunto()
        {
            
            Punto punto=new Punto();
            return punto;
        }
    }
}
