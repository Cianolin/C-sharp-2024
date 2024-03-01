using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaStudente
{
    internal class Studente : Persona
    {
        int _matricola;
        public Studente(string nome, string cognome, int matricola) : base (nome, cognome)
        {
            _matricola = matricola;
        }
        public int Matricola {  get { return _matricola; } }
        public override string ToString()
        {
            return string.Format($"Matricola: {Matricola}, Nome: {Name}, Cognome: {Lastname}");
        }
    }
}
