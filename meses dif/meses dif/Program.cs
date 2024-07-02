/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 2/7/2024
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace meses_dif
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int añoInicio;
			int añoFinal;
			int diferenciaEnMeses;
			
		
			
			Console.WriteLine("escoge un año para calcular: ");
				añoInicio = int.Parse(Console.ReadLine());
			
				Console.WriteLine("escoge un año para calcular: ");
				añoFinal = int.Parse(Console.ReadLine());
			
					diferenciaEnMeses = (añoFinal - añoInicio) * 12;
				
				Console.WriteLine("la diferencia en meses es: " + diferenciaEnMeses);
				Console.ReadKey();
		}
	}
}