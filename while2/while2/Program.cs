/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 1/5/2024
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace while2
{
	class Program
	{
		public static void Main(string[] args)
		{
		int x;
		int cantidad;
		int n;
		float largo;
		string linea;
		x=1;
		cantidad=0;
		
		Console.WriteLine("ingrese cuantas piezas procesara: ");
		linea = Console.ReadLine();
		n = int.Parse(linea);
		while(x<=n)
		{
				Console.WriteLine("ingrese la medida: ");
				linea = Console.ReadLine();
		largo = float.Parse(linea);
			if(largo>=1.20 && largo <= 1.30)
			{
				cantidad = cantidad + 1;
			}
				x = x + 1;
		} 
		Console.WriteLine("cantidad de peizas aptas" + cantidad);
		
			Console.ReadKey();
		}
	}
}