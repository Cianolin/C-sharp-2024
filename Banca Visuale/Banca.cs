using Banca;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca_Visuale
{
    internal class Banca
    {
        private static int id;
        private string name;
        List<Conto> conti;
        public static int ID
        {
            get=> id=0; 
            set => id = id++;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Banca(string name)
        {
            Name = name;
            List<Conto> contiCorrenti = new List<Conto>();
        }
        public void AggiuntiConti(Conto c)
        {
            conti.Add(c);
        }
        public Conto Ricerca(int id)
        {
            return conti.Find(c => c.Indetifica == id);
        }
        public void Prelieva(int codice, double quantita)
        {
            Conto c = Ricerca(codice);
            if (c != null)
            {
                if (c.Saldo >= quantita)
                {
                    c.Saldo -= quantita;
                }
                else
                {
                    Console.WriteLine("non disponibile la quantita");
                }
            }
        }
        public double SaldoTotale()
        {
            double saldoTot = 0;
            for (int i = 0; i < conti.Count; i++)
            {
                saldoTot += conti[i].Saldo * conti.Count;
            }
            return saldoTot;
        }
        public void Versa(int codice, double quantita)
        {
            Conto c = Ricerca(codice);
            if (c != null)
            {
                c.Saldo += quantita;
            }
        }
    }
}
