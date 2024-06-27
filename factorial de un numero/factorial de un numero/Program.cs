/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 27/6/2024
 * Time: 00:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace factorial_de_un_numero
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			int factorial= 1;
			bool repetir = true;
			do{
			Console.WriteLine("ingrese un numero");
			n = int.Parse(Console.ReadLine());
			
			for(int i = 1; i <= n; i++){
				factorial = factorial * i;
			
			}
			
			Console.WriteLine("el factorial de " +n+ " es : " + factorial);
			
			
			  Console.WriteLine("¿Desea calcular otro factorial? (S/N)");
        string resp = Console.ReadLine();

        if (resp != "s")
        {
            repetir = false;  
        }
        
			} while(repetir);
			
			Console.ReadKey();
	
		}
	}
}