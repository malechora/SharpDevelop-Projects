/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 26/6/2024
 * Time: 23:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace area_y_perimetro_de_un_rectangulo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double largo;
			double ancho;
			double area;
			double perimetro;
			
			Console.WriteLine("ingrese el largo del rectangulo:");
			largo = double.Parse(Console.ReadLine());
			
			Console.WriteLine("ingrese el ancho del rectangulo:");
			ancho = double.Parse(Console.ReadLine());
			
			area = largo * ancho;
			
			Console.WriteLine("el area del rectangulo es:" + area);
			
			perimetro = 2 * (largo + ancho);
			
			Console.WriteLine("el perimetro del rectangulo es : " + perimetro);
			
			
			Console.ReadKey();
		}
	}
}