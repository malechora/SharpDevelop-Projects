/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 15/7/2024
 * Time: 21:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p20
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			int porcentaje;
			Console.WriteLine("ingresa el porcentaje alcanzado en tu capacitacion: ");
			porcentaje=int.Parse(Console.ReadLine());
			if (porcentaje>=90)
			{
				Console.WriteLine("nivel alcanzado: Maximo");
			} else if(porcentaje>=75 && porcentaje<90)
		     {
				Console.WriteLine("nivel alcanzado medio ");
			} else if (porcentaje>=50 && porcentaje<75)
			{
				Console.WriteLine("nivel alcanzado regular");
			} else 
			{
				Console.WriteLine("fuera de nivel");
			}
			Console.ReadKey();
	}
}

}