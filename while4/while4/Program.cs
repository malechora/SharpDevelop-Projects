/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 2/5/2024
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace while4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int x, n,promedio;
			float altura;
			x= 1;
			int sumaAlturas=0;
		    string linea;
		    
		    
		    	Console.WriteLine("ingrese la cantidad de personas:  ");
		    	linea = Console.ReadLine();
		    	n = int.Parse(linea);
		    	
		    	while(x <=n)
		    	{
		    		Console.WriteLine("ingrese la altura" + x + " persona : ");
		    		linea = Console.ReadLine();
		    		altura = float.Parse(linea);
		    		sumaAlturas = sumaAlturas + (int)altura;
		    	  x = x + 1;   
		    	}
			
		    	
		         	promedio = sumaAlturas / n;
		    	
		         Console.WriteLine("el promedio es : " +  promedio );	
		         	
			Console.ReadKey(true);
		}
	}
}

