

namespace fahrenheit y celcius
{
	class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Ingrese 1 para Celsius o 2 para Fahrenheit: ");

    
        int opcion = int.Parse(Console.ReadLine());
       

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ha elegido Celsius.");
                
                     Console.WriteLine("Ingrese la temperatura en CELCIUS a convertir en Fahrenheit:");
                      double temperaturaCelcius = double.Parse(Console.ReadLine());
                      double temperaturaFahrenheit = (temperaturaCelcius * 9 / 5) + 32;
                        Console.WriteLine("la temperatura en fahrenheit es: " + temperaturaFahrenheit );

                break;
            case 2:
                Console.WriteLine("Ha elegido Fahrenheit.");
    Console.WriteLine("Ingrese la temperatura en Fahrenheit a convertir en CELCIUS:");
                      double temperaturaFahrenheit2 = double.Parse(Console.ReadLine());
                      double temperaturaCelcius2 = (temperaturaFahrenheit2 - 32) * 5 / 9;
                        Console.WriteLine("la temperatura en Celcius es: " + temperaturaCelcius2 );
                
                
                break;
            default:
                Console.WriteLine("Opción inválida. Ingrese 1 o 2.");
                        break;
                        
                    
        }
          Console.ReadKey();
    }
}
	}
