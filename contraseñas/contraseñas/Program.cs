/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 6/1/2024
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace contraseñas
{
    class registro
    {
        public static void Main(string[] args)
        {
        	
            string contraseñaGuardada = "";
            string contraseñaIngresada;
            int intentosPermitidos = 3;
            int flag = 0;
           
            do
            {
         
                
                 do{
                	Console.WriteLine("Escriba una contraseña:");
                contraseñaGuardada = Console.ReadLine(); 
				if (contraseñaGuardada != null) {
					
				}
                 
                	if (Regex.IsMatch(contraseñaGuardada, @"^(?=.*[a-zA-Z].*[a-zA-Z].*[a-zA-Z])(?=.*\d.*\d.*\d).{6,}$")) 
			 		   {
                		
                		Console.WriteLine("La contraseña es valida.");
                		flag = 1;
                		
			    } 
			    else
			    {
			     
			        Console.WriteLine("La contraseña debe contener al menos 3 números y 3 letras.");
			        flag = 0;
			    }
                }while(flag != 1);
                

                Console.WriteLine("Contraseña guardada, escríbala nuevamente:");
                contraseñaIngresada = Console.ReadLine();


                if (contraseñaIngresada == contraseñaGuardada)
                {
                    Console.WriteLine("Entrando al sistema...");
                    break; 
                }
                else if (intentosPermitidos > 1)
                {
                    intentosPermitidos--;
                    Console.WriteLine("Contraseña incorrecta, vuelva a intentar. Tiene " + intentosPermitidos + " intento/s restantes.");
                } 
                else
                {
                    Console.WriteLine("Intentos agotados. Acceso denegado.");
                    return;
                }
            } while (true); 
        }
    }
}