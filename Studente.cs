using System;

namespace Interfacce1
{
	class Studente: Persona
	{
		public string classe;
		public Studente(string nome, string cognome, string classe) : base(nome, cognome)
		{
			this.classe = classe;
		}

		//override sovrascrive, new aggiunge e quindi non elimina la possibilità di usare saluta
		public override void Saluta()
		{
			Console.WriteLine($"Buongiorno professore, sono {nome} {cognome}");
		}
	}
}

