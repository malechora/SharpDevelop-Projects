using System;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método para mostrar información de la persona
    public void MostrarInformacion()
    {
       Console.WriteLine("Nombre: " + Persona.Nombre + ", Edad: " + Persona.Edad);

    }
}
