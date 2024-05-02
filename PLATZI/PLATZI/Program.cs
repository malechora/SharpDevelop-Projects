/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 1/1/2024
 * Time: 22:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PLATZI
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			var ladoA= 1.1;
			var ladoB= 1.1;
			var resultado= 1.1;
			
			Console.WriteLine("calcula el area de un rectangulo");
			Console.WriteLine("ingrese el valor de lado A");
			ladoA = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("ingrese el valor de lado b");
			ladoB = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("el resultado es : "); 
			resultado = ladoA * ladoB;
			Console.WriteLine("el resultado es" + resultado);
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}