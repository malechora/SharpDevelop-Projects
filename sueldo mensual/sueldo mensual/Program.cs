/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 13/2/2024
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sueldo_mensual
{
	class Program
	{
		public static void Main(string[] args)
		{
			// calcular el sueldo mensual  de un empleado conociendo la cantidad de horas trabajadas y el pago por hora
			int horasTrabajadas;
			float pagoHora;
			float sueldo;
			string linea;
			
			Console.WriteLine("ingrese las horas que trabaja el pendejo :");
			linea = Console.ReadLine();
			horasTrabajadas = int.Parse(linea);
			
			Console.WriteLine("ingrese el pago x hora del pendejo :");
			linea = Console.ReadLine();
			pagoHora = float.Parse(linea);
			
			sueldo = horasTrabajadas * pagoHora;
			
				Console.WriteLine("el pago de sueldo del pendejo es: " + sueldo);
		
				Console.ReadKey();
			
			
		}
	}
}