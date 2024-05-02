/*
 * Created by SharpDevelop.
 * User: Agustin
 * Date: 8/1/2024
 * Time: 23:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace gimnasio
{
    class Program
    {
        class Cliente
        {
            public string Nombre { get; set; }
            public bool PagoEsteMes { get; set; }
        }

        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            int opcion;
            string nombreCliente;
            bool salir = false;

            do
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Registrar nuevo cliente");
                Console.WriteLine("2. Ver clientes que pagaron este mes");
                Console.WriteLine("3. Eliminar cliente");
                Console.WriteLine("4. Salir");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el nombre del cliente que pagó el mes:");
                        nombreCliente = Console.ReadLine();
                        clientes.Add(new Cliente { Nombre = nombreCliente, PagoEsteMes = true });
                        Console.WriteLine("Cliente registrado correctamente.");
                        break;
                    case 2:
                        Console.WriteLine("Clientes que pagaron este mes:");
                        MostrarClientesPagadosEsteMes(clientes);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre del cliente que desea eliminar:");
                        nombreCliente = Console.ReadLine();
                        EliminarCliente(clientes, nombreCliente);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 4.");
                        break;
                }
            } while (!salir);

            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
        }

        static void MostrarClientesPagadosEsteMes(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.PagoEsteMes)
                {
                    Console.WriteLine(cliente.Nombre);
                }
            }
        }

        static void EliminarCliente(List<Cliente> clientes, string nombreCliente)
        {
            var clienteAEliminar = clientes.Find(c => c.Nombre.Equals(nombreCliente, StringComparison.OrdinalIgnoreCase));
            if (clienteAEliminar != null)
            {
                clientes.Remove(clienteAEliminar);
                Console.WriteLine("Cliente eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el cliente con ese nombre.");
            }
        }
    }
}
