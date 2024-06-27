/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 26/6/2024
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace de_millas_a_kilometros
{
	class Program
	{
		public static void Main(string[] args)
		{
			double millas, km , millas2 ,km2;
			int opcion;
			
			Console.WriteLine("elige que quiere convertir : 1 para milla a km o 2 para km a milla: ");
			opcion = int.Parse(Console.ReadLine());
			
			switch(opcion){
				case 1: Console.WriteLine("de milla a km ");
				Console.WriteLine("cantidad de millas a convertir: ");
					
				millas = double.Parse(Console.ReadLine());
					km = millas * 1.60934;
					Console.WriteLine("la conversion seria: " + km);
					
					
				break;
			case 2: Console.WriteLine("de km a milla");
				Console.WriteLine("cantidad de km a convertir: ");
					km2 = double.Parse(Console.ReadLine());
					millas2 = km2 / 1.60934;
					Console.WriteLine("la conversion seria: " + millas2);
			
			
			break;
		default: Console.WriteLine("opcion invalida");
		break;
			}
			Console.ReadKey();
		}
	}
}