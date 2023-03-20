using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello World!");
        

            var persone = new List<Persona>
            {
                new Studente("luca", "rossi", "4a"),
                new Insegnante("anna", "rossetto", "Arte"),
            };

            foreach(Persona persona in persone)
            {
                persona.Saluta();
            }
        }
    }
}
