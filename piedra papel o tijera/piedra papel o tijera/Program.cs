/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 11/7/2024
 * Time: 22:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace piedra_papel_o_tijera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a PIEDRA, PAPEL O TIJERA, escoge uno: piedra, papel o tijera");
            string eleccionHum = Console.ReadLine();  

            if (eleccionHum == "piedra")
            {
                Console.WriteLine("Escogiste piedra");
            }
            else if (eleccionHum == "papel")
            {
                Console.WriteLine("Escogiste papel");
            }
            else if (eleccionHum == "tijera")
            {
                Console.WriteLine("Escogiste tijera");
            }
            else
            {
                Console.WriteLine("Elección no válida");
                return;
            }

            Random random = new Random();
            int eleccionComputadora = random.Next(3);
            string eleccionComp = "";

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

            Console.WriteLine("La computadora escogió: " + eleccionComp);

            if (eleccionHum == eleccionComp)
            {
                Console.WriteLine("Empate");
            }
            else if ((eleccionHum == "piedra" && eleccionComp == "tijera") || 
                     (eleccionHum == "tijera" && eleccionComp == "papel") || 
                     (eleccionHum == "papel" && eleccionComp == "piedra"))
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");
            }

            Console.ReadKey();
        }
    }
}
