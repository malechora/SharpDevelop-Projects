using System;

namespace Juego_POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fuego fuego = new Fuego();
           fuego.Atacar();

            Agua agua = new Agua();
            agua.Atacar();

            Viento viento = new Viento();
            viento.Atacar();

            Console.ReadKey();
        }
    }

    class Ataque
    {
        public int fuerza = 1;
        public int daño = 20;
        public string tipo = " generico";

        public void Atacar()
        {
            Console.WriteLine("El ataque de tipo" + tipo + "fue de fuerza : " + fuerza + " y su daño fue de: " + daño);
        }
    }

    class Fuego : Ataque 
    {
        public Fuego()
        {
            fuerza = 1;
            daño = 25; 
            tipo = " fuego ";
        }
    }

    class Agua : Ataque 
    {
        public Agua()
        {
            fuerza = 2;
            daño = 15;
            tipo = " agua ";
        }
    }

    class Viento : Ataque 
    {
        public Viento()
        {
            fuerza = 3;
            daño = 10;
            tipo = " viento ";
        }
    }
}
