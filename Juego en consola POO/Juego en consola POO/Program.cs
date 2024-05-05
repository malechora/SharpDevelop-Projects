/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 4/5/2024
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Juego_en_consola_POO
{
	class Jugador
	{
		public int puntosVida = 50;
		
		public enum tipoEleccion{
			Agua,
			Planta,
			Fuego
		};
		
		public tipoEleccion tipo;
		
		public void AtaqueNormal()
		{
			puntosVida -= 5;
		}
		
		public void AtaquePorTipo();
		{
			switch(tipo)
			{
				case tipoEleccion Agua:
					puntosVida -=10;
					break;
					case tipoEleccion.Planta;
					puntosVida -=8;
					break;
					case tipoEleccion.Fuego;
					puntosVida -=12;
					break;
			}
		}
			
	}
	
	class Program 
	{
		static void Main(string[] args)
		{
			Jugador jugador1= new Jugador();
			Console.WriteLine("el jugador 1 comienza con "+ jugador1.puntosVida + "puntos de vida");
			
			Console.WriteLine("elegi una clase para el jugador 1: 1 para agua, 2 para planta y 3 para fuego : ");
			string tipo1 = Console.ReadLine();
			int tipoEleccion = int.Parse(tipo1);
			
			switch(tipoEleccion1)
			{
				case 1: jugador1.tipo
			}
		}
	}
	
	
}