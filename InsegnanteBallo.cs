using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce1
{
	//sealed, vuol dire che la clasee non potrà essere modificata da sottoclasssi, no everride ecc...
	sealed class InsegnanteBallo: Insegnante
	{
		public string canzonePreferita;
		public InsegnanteBallo(string nome, string cognome, string materia, string canzonePreferita): base(nome, cognome, materia)
		{
			this.canzonePreferita = canzonePreferita;
		}
	}
}
