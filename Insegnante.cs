using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce1
{
	class Insegnante: Persona
	{
		public string materia;
		public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
		{
			this.materia = materia;
		}

		public override void Saluta()
		{
			Console.WriteLine($"Ciao Ragazzi sono l'insegnante {nome} {cognome}");
		}
	}
}

