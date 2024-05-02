/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 2/1/2024
 * Time: 00:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practifca
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			var manoJugador = 1;
			var dealear = 1;
			
			
			manoJugador = Convert.ToInt32(Console.ReadLine());
			dealear = Convert.ToInt32(Console.ReadLine());
			
			if(manoJugador > dealear){
				Console.WriteLine("ganaste");
			} else if ( manoJugador < dealear){
				Console.WriteLine("perdiste");
			} else if ( manoJugador <= 21){
				Console.WriteLine("perdiste");
			} else
				Console.WriteLine("perdiste");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}