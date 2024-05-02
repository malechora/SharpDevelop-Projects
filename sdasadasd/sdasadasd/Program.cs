/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 16/2/2024
 * Time: 23:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
	
namespace proyect_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, suma, producto;
			Console.Write(" ingrese el primer numero para poder realizar una cuenta:" );
			
			num1=int.Parse(Console.ReadLine());
			
			Console.Write("por favor ingrese el segundo numero");
			
			num2=int.Parse(Console.ReadLine());
					
			suma= num1+num2;
			
			producto=num1*num2;
			Console.Write("el resultado de la suma de los numeros es: ");
			Console.WriteLine(suma);
			Console.Write("el resultado de la multiplicacion de los numeros es: ");
			Console.WriteLine(producto);
			Console.ReadKey();
			
		}
	}
}