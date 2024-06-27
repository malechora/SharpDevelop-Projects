/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 27/6/2024
 * Time: 00:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Suma_de_los_Primeros_N_Números_Naturales
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			int suma= 0;
			
			Console.WriteLine("escoge un numero:");
			n = int.Parse(Console.ReadLine());
			
			for(int i = 0 ; i <= n ; i++){
				suma += i;
			}
			
			Console.WriteLine("La suma de los primeros " + n + "números naturales es: " + suma);
			Console.ReadKey();
		}
	}
}