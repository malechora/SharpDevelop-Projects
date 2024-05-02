/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 2/5/2024
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace while3
{
	class Program
	{
		public static void Main(string[] args)

		{
			int altas,bajas,x,nota;
			string linea;
			altas = 0;
			bajas = 0;
			x=1;
			
			
			while(x <= 10)
			{
			Console.WriteLine("ingrese las 10 notas de los alumnos: ");
			linea = Console.ReadLine();
			nota = int.Parse(linea);
			if(nota <= 7){
				altas = altas +1;
			}else{
				bajas = bajas +1;
			}
			x = x +1;
			}
			
			Console.Write("la cantidad de altas es:  " + altas);
			Console.Write("la cantidad de bajas es:  " + bajas);
			Console.ReadKey();
		}
	}
}