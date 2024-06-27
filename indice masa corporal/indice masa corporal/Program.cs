/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 27/6/2024
 * Time: 00:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace indice_masa_corporal
{
	class Program
	{
		public static void Main(string[] args)
		{
			double peso, altura, imc;
			
			Console.WriteLine("ingrese su peso: ");
			peso = double.Parse(Console.ReadLine());
			
				Console.WriteLine("ingrese su altura: ");
			altura = double.Parse(Console.ReadLine());
			
			imc = peso / (altura * altura);
			Console.WriteLine("su IMC es: "+ imc);
			
			Console.ReadKey();
			
		}
	}
}