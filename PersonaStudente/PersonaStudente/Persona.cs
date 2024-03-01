using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaStudente
{
    internal class Persona
    {
        string _name;
        string _lastname;
        public Persona(string name, string lastname)
        {
            _name = name;
            _lastname = lastname;
        }
        public string Name { get { return _name; } }
        public string Lastname { get { return _lastname; } }
        public override string ToString()
        {
            return string.Format($"Nome: {Name}, Cognome: {Lastname}");
        }
    }
}
