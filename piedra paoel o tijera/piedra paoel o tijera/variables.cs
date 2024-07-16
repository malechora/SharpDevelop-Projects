using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace piedra_paoel_o_tijera
{
	/// <summary>
	/// Description of variables.
	/// </summary>
	public class variables
	{
		
         private int eleccionComputadora;
         private string eleccionComp = "";
         private int eleccionHum;
         private string piedra = "piedra";
         private string papel = "papel";
         private string tijera = "tijera";
		
         public int EleccionComputadora {
			get { return eleccionComputadora; }
			set { eleccionComputadora = value; }
		}

		public string EleccionComp {
			get { return eleccionComp; }
			set { eleccionComp = value; }
		}

		public int EleccionHum {
			get { return eleccionHum; }
			set { eleccionHum = value; }
		}

		public string Piedra {
			get { return piedra; }
			set { piedra = value; }
		}

		public string Papel {
			get { return papel; }
			set { papel = value; }
		}

		public string Tijera {
			get { return tijera; }
			set { tijera = value; }
		}
		
	}
}
