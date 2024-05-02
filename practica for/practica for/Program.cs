/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 5/1/2024
 * Time: 01:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class Program
{
    static void Main()
    {
        string respuesta;
        
        do{
        	Console.WriteLine("quieres continuar? S/N");
        	respuesta = Console.ReadLine();
        
        	                  if(respuesta.ToLower() == "s"){
         
        	                  	Console.WriteLine("continuando...");
        	                  	}
        	                  
        	                  else if(respuesta.ToLower() == "n"){
        	                  	Console.WriteLine("saliendo....");
        	                  	} else {
        	                  	Console.WriteLine("respuesta invalida");
        	                  }
        	                  	                  
        	                  	                  
        	}while (respuesta.ToLower() != "n");
    }
}