using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una palabra");
            string palabra= Console.ReadLine();
            int contador=0;
          

            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];

                if (letra=='a' || letra=='e' || letra=='i' || letra == 'o' ||  letra == 'u')
                {
                    contador++;
                }
            }

            Console.WriteLine(contador);
            Console.ReadKey();
            
        }
    }
}