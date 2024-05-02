/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 6/1/2024
 * Time: 22:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var poderVolar = new SuperPoder()
            {
                nombre = "volar",
                descripcion = "capacidad para volar y planear",
                nivel = NivelPoder.nivelDos
            };

            var superFuerza = new SuperPoder()
            {
                nombre = "super fuerza",
                descripcion = "capacidad de fuerza sobrehumana",
                nivel = NivelPoder.nivelTres
            };

            List<SuperPoder> poderesSuperman = new List<SuperPoder>();
            poderesSuperman.Add(poderVolar);
            poderesSuperman.Add(superFuerza);

            var superman = new SuperHeroe()
            {
                id = 1,
                nombre = "Superman",
                identidadSecreta = "Clark Kent",
                ciudad = "Metropolis",
                superPoderes = new List<SuperPoder>() { poderVolar, superFuerza },
                puedeVolar = true
            };

            superman.usarSuperPoderes();
        }
    }

    class SuperHeroe
    {
        public int id;
        public string nombre;
        public string identidadSecreta;
        public string ciudad;
        public List<SuperPoder> superPoderes;
        public bool puedeVolar;

        public SuperHeroe()
        {
            id = 1;
            superPoderes = new List<SuperPoder>();
            puedeVolar = false;
        }

        public void usarSuperPoderes()
        {
            
        }
    }

    class SuperPoder
    {
        public string nombre;
        public string descripcion;
        public NivelPoder nivel;

        public SuperPoder()
        {
            nivel = NivelPoder.nivelUno;
            
            
            Console.WriteLine(superman);
        }
    }

    enum NivelPoder
    {
        nivelUno,
        nivelDos,
        nivelTres
    }
}