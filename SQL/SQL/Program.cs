using System;
using System.Data;
using System.Data.SqlClient;

namespace EjemploSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "YourConnectionString"; // Reemplaza con tu cadena de conexión

            // Crear la conexión SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Comandos SQL
                string createTableQuery = @"
                    CREATE TABLE `caracteristicas` (
                      `id` int(11) PRIMARY KEY NOT NULL,
                      `Marca` varchar(20) NOT NULL,
                      `Modelo` varchar(20) NOT NULL,
                      `Cantidad_de_nucleos` int(2) NOT NULL,
                      `Memoria_ram` int(2) NOT NULL,
                      `Memoria_de_video` int(2) NOT NULL,
                      `HDD_SSD` char(3) NOT NULL,
                      `Puertos_usb` varchar(2) NOT NULL,
                      `Red_RJ45` char(2) NOT NULL,
                      `Wifi` varchar(12) NOT NULL,
                      `SO_base` varchar(10) NOT NULL,
                      `Precio_unitario` float(10,2) NOT NULL
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

                    INSERT INTO `caracteristicas` (`id`, `Marca`, `Modelo`, `Cantidad_de_nucleos`, `Memoria_ram`, `Memoria_de_video`, `HDD_SSD`, `Puertos_usb`, `Red_RJ45`, `Wifi`, `SO_base`, `Precio_unitario`) VALUES
                    (8, 'Lenovo', 'Leno-556', 4, 16, 8, 'hdd', '2', 'no', 'AN-41254N', 'Linux', 105000.00),
                    (9, 'Samsung', 'Sam-255', 8, 32, 8, 'ssd', '3', 'si', 'AG-4441g', 'Windows', 95000.00);

                    CREATE TABLE `valores` (
                      `Cantidad_Adquiridas` int(5) NOT NULL,
                      `Cantidad_Vendidas` int(5) NOT NULL,
                      `En_Stock` int(5) NOT NULL,
                      `Valor_total_del_Stock` double(15,4) NOT NULL,
                      `ID` int(11) PRIMARY KEY NOT NULL
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;";

                // Abrir la conexión
                connection.Open();

                // Ejecutar comandos SQL
                SqlCommand command = new SqlCommand(createTableQuery, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Comandos SQL ejecutados con éxito.");
            }
        }
    }
}