/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 4/1/2024
 * Time: 01:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0; // Inicializamos la variable suma en 0 antes del bucle

        for (int i = 1; i <= 10; i++)
        {
            suma += i; // Acumulamos la suma en cada iteración
        }
        
        Console.WriteLine("La suma de los números del 1 al 10 es: " + suma);

        Console.ReadKey();
    }
}
