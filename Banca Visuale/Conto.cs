using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    internal class Conto
    {
        int _id;
        string _name,_lastname;
        double saldo;
        public Conto(int id,string name,string lastname)
        {
            _name = name;
            _id = id;
            _lastname = lastname;
            Saldo = 10;
        }
        public Conto( ):this (1000, "Nessuno","Nessuno")
        {

        }
        public int Indetifica
        {
            get { return _id; }
        }
        public string Name { 
            get { return _lastname; }
        }
        public string LastName
        {
            get { return _lastname; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public override string ToString()
        {
            return string.Format($"ID conto: {Indetifica}\nNome: {Name}\nCognome: {LastName}\nConto: {Saldo}");
        }
        public bool Movimento(double mov)
        {
            if (Saldo + mov < 0)
            {
                return false;
            }
            else
            {
                Saldo += mov;
                return true;
            }

        }
    }
}
