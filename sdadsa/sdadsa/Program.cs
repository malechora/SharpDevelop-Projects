using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> ingresos = new Dictionary<string, double>();
        Dictionary<string, double> gastos = new Dictionary<string, double>();

        Console.WriteLine("Presupuesto Proyectado de Contabilidad");
        
        // Ingresar ingresos
        Console.WriteLine("Ingrese los ingresos (escriba 'fin' para terminar):");
        while (true)
        {
            Console.Write("Categoría de ingreso: ");
            string categoria = Console.ReadLine();
            if (categoria.ToLower() == "fin") break;

            Console.Write("Monto: ");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                if (ingresos.ContainsKey(categoria))
                {
                    ingresos[categoria] += monto;
                }
                else
                {
                    ingresos[categoria] = monto;
                }
            }
            else
            {
                Console.WriteLine("Monto no válido. Inténtalo de nuevo.");
            }
        }

        // Ingresar gastos
        Console.WriteLine("Ingrese los gastos (escriba 'fin' para terminar):");
        while (true)
        {
            Console.Write("Categoría de gasto: ");
            string categoria = Console.ReadLine();
            if (categoria.ToLower() == "fin") break;

            Console.Write("Monto: ");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                if (gastos.ContainsKey(categoria))
                {
                    gastos[categoria] += monto;
                }
                else
                {
                    gastos[categoria] = monto;
                }
            }
            else
            {
                Console.WriteLine("Monto no válido. Inténtalo de nuevo.");
            }
        }

        // Calcular y mostrar el presupuesto proyectado
        double totalIngresos = 0;
        foreach (var ingreso in ingresos.Values)
        {
            totalIngresos += ingreso;
        }

        double totalGastos = 0;
        foreach (var gasto in gastos.Values)
        {
            totalGastos += gasto;
        }

        double balanceFinal = totalIngresos - totalGastos;

        Console.WriteLine("\n--- Presupuesto Proyectado ---");
        Console.WriteLine($"Total Ingresos: {totalIngresos:C}");
        Console.WriteLine($"Total Gastos: {totalGastos:C}");
        Console.WriteLine($"Balance Final: {balanceFinal:C}");
    }
}
