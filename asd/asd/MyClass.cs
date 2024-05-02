using System;
using System.Data.SqlClient;

namespace CrearBaseDeDatosSiNoExiste
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión
            string databaseName = "NOTEBOOK";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                VerificarYCrearBaseDeDatos(connection, databaseName);
                CrearTablaSiNoExiste(connection);
                Console.WriteLine("Operación completada correctamente.");
            }

            Console.ReadLine();
        }

        static void VerificarYCrearBaseDeDatos(SqlConnection connection, string databaseName)
        {
            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS " + databaseName;
            using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        static void CrearTablaSiNoExiste(SqlConnection connection)
        {
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS `caracteristicas` (
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
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;";
            
            using (SqlCommand command = new SqlCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}