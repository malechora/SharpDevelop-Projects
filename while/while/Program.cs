using System;

namespace whilee
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 1, suma = 0, valores;
            string linea;

            while (x <= 10)
            {
                Console.Write("Ingrese su valor: ");
                linea = Console.ReadLine();
                valores = int.Parse(linea);
                suma += valores;
                x++;
            }

            double promedio = (double)suma / 10;
            Console.WriteLine("La suma de los valores es: " + suma);
            Console.WriteLine("El promedio de los valores es: " + promedio);
            Console.ReadKey();
        }
    }
}
