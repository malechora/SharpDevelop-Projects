/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 4/7/2024
 * Time: 11:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace numero_mayor
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			int num1,num2,num3;
			
			Console.WriteLine("ingrese 3 numeros y veremos cual es el mayor: ");
				Console.WriteLine("1er num: ");
				num1 = int.Parse(Console.ReadLine());
				Console.WriteLine("2do num: ");
				num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("3er num: ");
				num3 = int.Parse(Console.ReadLine());
				
				if(num1 > num2 && num1 > num3){
					Console.WriteLine(num1 + " es mayor que todos ");
				} else if(num2 > num1 && num2 > num3){
					Console.WriteLine(num2 + " es mayor que todos ");
				} else {
					Console.WriteLine(num3 + " es mayor que todos ");
				}
				
				
				
				Console.ReadKey();
			
		
		}
	}
}