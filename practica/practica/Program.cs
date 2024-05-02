/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 6/1/2024
 * Time: 22:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio12_estructuras_simples_y_compuestas
{
	class Program
 {
		public static void Main(string[] args)
   {
			int num1,num2,suma,diferencia,producto,division;
			string linea;
			Console.Write("hola te voy a pedir que ingreses un valor: ");
			linea=Console.ReadLine();
			num1=int.Parse(linea);
			Console.Write("ingresa un segundo valor: ");
			linea=Console.ReadLine();
			num2=int.Parse(linea);
		
			if (num1>num2)
	  {
			
	        suma=num1+num2;
			diferencia=num1-num2;
			Console.Write("la suma de los valores es: ");
			Console.WriteLine(suma);
			Console.Write("la diferencia de los valores es : ");
			Console.WriteLine(diferencia);
	  }
			else
		{
			producto = num1 * num2;
division = (int)(num1 / (double)num2); // Realizar la división como double y luego convertir a int
Console.Write("El producto de los valores es: ");
Console.WriteLine(producto);
Console.Write("La división de los valores dados: ");
Console.WriteLine(division);
		}
			Console.ReadKey();
	}
 }
}