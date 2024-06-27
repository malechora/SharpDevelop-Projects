/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 27/6/2024
 * Time: 00:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace numeros_pares_e_impares
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			
			Console.WriteLine("ingrese un numero entero positivo: ");
			n = int.Parse(Console.ReadLine());
			
			for(int i= 1; i <= n; i++){
				
				if(i % 2 == 0){
					Console.WriteLine("es par");
				} else {
					Console.WriteLine("es impar");
				}
			}
			Console.ReadKey();
			
		
		}
	}
}