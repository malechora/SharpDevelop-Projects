/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 4/5/2024
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clases
{
	class Program
	{
		public static void Main(string[] args)
		{
			ventana calculadora = new ventana();
			calculadora.Cerrar();
			
			Console.ReadKey();
		}
	}
	
	class ventana
	{
		//atributos
		public int ancho=15;
		public int alto=20;
		public string color = "rojo";
		
		//metodos
		public void Cerrar()
		{
			Console.WriteLine("la ventana se cerro");
		}
		
		public void Minimizar()
		{
			Console.WriteLine("la ventana se minimizo");
		}
		
		public void Maximizar()
		{
			Console.WriteLine("la ventana se agrando");
		}
	}
	
}