using System;

class Jugador
{   

    public int pv = 60;


    public enum TipoEleccion
    {
        Agua,
        Planta,
        Fuego
    };

    public TipoEleccion tipo;

  
    public void AtaqueNormal()
    {
        pv -= 5;
    }


    public void AtaquePorTipo()
    {
        switch (tipo)
        {
            case TipoEleccion.Agua:
                pv -= 10; 
                break;
            case TipoEleccion.Planta:
                pv -= 8; 
                break;
            case TipoEleccion.Fuego:
                pv -= 12; 
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jugador jugador1 = new Jugador();
        Console.WriteLine("El jugador1 empieza con " + jugador1.pv + " puntos de vida.");

        Console.Write("Elige clase para jugador1: 1 para Agua, 2 para Planta y 3 para Fuego: ");
        string tipo1 = Console.ReadLine();
        int tipoEleccion1 = int.Parse(tipo1);

        switch (tipoEleccion1)
        {
            case 1:
                jugador1.tipo = Jugador.TipoEleccion.Agua;
                break;
            case 2:
                jugador1.tipo = Jugador.TipoEleccion.Planta;
                break;
            case 3:
                jugador1.tipo = Jugador.TipoEleccion.Fuego;
                break;
        }

        Console.WriteLine("Has elegido: " + jugador1.tipo);

        Jugador jugador2 = new Jugador();
        Console.WriteLine("El jugador2 empieza con " + jugador2.pv + " puntos de vida.");

        Console.Write("Elige clase para jugador2: 1 para Agua, 2 para Planta y 3 para Fuego: ");
        string tipo2 = Console.ReadLine();
        int tipoEleccion2 = int.Parse(tipo2);

        switch (tipoEleccion2)
        {
            case 1:
                jugador2.tipo = Jugador.TipoEleccion.Agua;
                break;
            case 2:
                jugador2.tipo = Jugador.TipoEleccion.Planta;
                break;
            case 3:
                jugador2.tipo = Jugador.TipoEleccion.Fuego;
                break;
        }

        Console.WriteLine("Has elegido: " + jugador2.tipo);

       
        jugador1.AtaqueNormal(); 
        jugador2.AtaquePorTipo(); 

        Console.WriteLine("Después de los ataques:");
        Console.WriteLine("Jugador1 tiene " + jugador1.pv + " puntos de vida.");
        Console.WriteLine("Jugador2 tiene " + jugador2.pv + " puntos de vida.");

        Console.ReadKey();
    }
}
