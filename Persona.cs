﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce1
{ 
	public class Persona
	{
		public string nome;
		public string cognome;
		public Persona(string nome, string cognome)
		{
			this.nome = nome;
			this.cognome = cognome;
		}

		public virtual void Saluta()
		{
			Console.WriteLine($"Ciao sono {nome} {cognome}");
		}
	}
}

