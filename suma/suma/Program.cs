/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 24/6/2024
 * Time: 22:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace suma
{
	class Program
		
	{
		public static void Main(string[] args)
		{
			int numero, numero2;
			string linea;
			int resultado;
				
		
			
			Console.Write("escribe un numero: ");
			linea = Console.ReadLine();
			
			numero = int.Parse(linea);
			
			
					Console.Write("escribe otro numero: ");
			linea = Console.ReadLine();
			numero2 = int.Parse(linea);
			
			resultado = numero + numero2;
			Console.Write("el resultado es: " + resultado );
	
		  
			
		for (resultado = 1; resultado <= 1; resultado++) {
Console.Write(resultado);
			
			}
			
			Console.ReadKey(true);
		}
	}
}