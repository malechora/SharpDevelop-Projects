/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 5/1/2024
 * Time: 15:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dowhilee
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            string contraseña;
            int intentosPermitidos = 3;
            bool contraseñaCorrecta = false;       
            
            do
            {
            	  Console.WriteLine("Bienvenido al sistema... ");
                Console.WriteLine("Escriba su contraseña, tiene " + intentosPermitidos + " intento/s: ");
                contraseña = Console.ReadLine();

                if (contraseña == "abc123")
                {
                    Console.WriteLine("¡Bienvenido al sistema!");
                    contraseñaCorrecta = true;
                  
                }
                else
                { intentosPermitidos--;
                	if(intentosPermitidos == 0 ){
                		return;
                	}
                    Console.WriteLine("Ingrese correctamente su contraseña");
                }

            } while (contraseña != "abc123");
            
            if (contraseñaCorrecta)
            {
                MostrarMenu();
            }
                  Console.ReadLine();
        }
        
        public static void MostrarMenu()
        {
            bool salir = false;
            string opcion;
            string nombreApellido = "";
            string diaLibre= "";
            	
            while(!salir){
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Reservas");
            Console.WriteLine("2. Dias libres");
            Console.WriteLine("3. Ver información guardada");
            Console.WriteLine("4. Salir");
            
            Console.WriteLine("seleccione una opcion :");
            opcion = Console.ReadLine();
            
            switch(opcion)
            {
            	case "1" :
            		Console.WriteLine("eligió la opcion 1 reservas");
            		Console.WriteLine("Ponga el nombre y apellido del reservante:");
               nombreApellido = Console.ReadLine();
                Console.WriteLine("Reserva realizada para: " + nombreApellido);
            		break;
            		case "2" :
            		Console.WriteLine("eligio la opcion 2 dias libres");
            		Console.WriteLine("lunes y viernes libre , elija una");
            	 diaLibre = Console.ReadLine();
            		Console.WriteLine("el dia escogido  para " + nombreApellido + " fue " + diaLibre);
            		break;
            		case "3" :
            		if (!string.IsNullOrEmpty(nombreApellido) && !string.IsNullOrEmpty(diaLibre))
                        {Console.WriteLine("el dia " + diaLibre + " fué apartado correctamente para; " + nombreApellido);
            		} else {
            			Console.WriteLine("debe completar el dia y nombre apellido que quiera reservar");
            		}
            		break;
            		case "4" :
            		salir = true;
            		break;
            		default:
                    Console.WriteLine("Opcion invalida. Por favor, elija una opcion valida.");
                    break;
                               }
                       }
               } 
   }
}