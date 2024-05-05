/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 4/5/2024
 * Time: 09:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clases2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Ventana calculadora = new Ventana();
		
			
			Console.ReadKey();
			
		
		}
	}
	
	class Ventana
	{
		//atributos
		private int ancho, altura;
		private string color;
		
		public Ventana()
		{
			ancho = 15;
			altura = 20;
			color = "rojo";
			Console.WriteLine("funciona");
		}
		
		public void Mostrar()
		{
		Console.WriteLine("la dimension de la ventana es: " + ancho + altura + "y su color es: " + color);
	}
}
}