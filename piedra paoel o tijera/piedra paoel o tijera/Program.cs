/* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	
namespace piedra_paoel_o_tijera
{
	class Program
	{
		public static void Main(string[] args)

		{
	
int eleccionComputadora;
string eleccionComp = "";
int eleccionHum;
string piedra = "piedra";
string papel = "papel";
string tijera = "tijera";

Console.WriteLine("Bienvenido a PIEDRA, PAPEL O TIJERA, escoge uno");
eleccionHum = Console.ReadLine();

if (eleccionHum == piedra)
{
    Console.WriteLine("escogiste piedra");
}
else if (eleccionHum == papel)
{
    Console.WriteLine("escogiste papel");
}
else if (eleccionHum == tijera)
{
    Console.WriteLine("escogiste tijera");
}
else
{
    Console.WriteLine("eleccion no valida");
}

Random random = new Random();
eleccionComputadora = random.Next(3);

if (eleccionComputadora == 0)
{
    eleccionComp = "piedra";
}
else if (eleccionComputadora == 1)
{
    eleccionComp = "papel";
}
else if (eleccionComputadora == 2)
{
    eleccionComp = "tijera";
}

Console.WriteLine("la computadora escogio :" + eleccionComp);

if (eleccionHum == piedra || eleccionHum == papel || eleccionHum == tijera)
{
    if (eleccionHum == eleccionComp)
    {
        Console.WriteLine("empate");
    }
    else if (eleccionHum == piedra && eleccionComp == tijera || eleccionHum == tijera && eleccionComp == papel || eleccionHum == papel && eleccionComp == piedra)
    {
        Console.WriteLine("gana el humano");
    }
    else
    {
        Console.WriteLine("perdiste");
    }
}
else
{
    Console.WriteLine("eleccion no valida");
}
Console.ReadKey();

		}
	}
}

*/