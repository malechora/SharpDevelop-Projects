/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 1/1/2024
 * Time: 23:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace circulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			var radio = 1.1;
			var resultado = 1.1;
			
			
			Console.WriteLine("BIENVENIDO, CALCULEMOS CIRCULOS");
			Console.WriteLine("Ingrese el valor del radio:");
			radio = Convert.ToDouble(Console.ReadLine());
		
			resultado = Math.PI * radio * radio;
			
			Console.WriteLine("el area de tu circulo es:" + resultado);
			
			if(resultado > 0)
			{	
				Console.WriteLine("es mayor");
			}
			else {  Console.WriteLine("es menor");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}