using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gabi_Portafolio10;

namespace Gabi_Portafolio10
{
    class Program
    {
        static void Main(string[] args)
        {
            TourVacaciones tour = new TourVacaciones();

            tour.IngresarTour();
            tour.MostrarTours(tour.IngresarTour());

            Console.ReadKey();

            var vehiculos = new[]
            {
                 new { Placa = "ABC123", Tipo = "Automóvil", Color = "Rojo", Año = 2020, Fabricante = "Toyota", Modelo = "Corolla" },
                new { Placa = "DEF456", Tipo = "SUB 4x2", Color = "Gris", Año = 2019, Fabricante = "Ford", Modelo = "Escape" },
                new { Placa = "GHI789", Tipo = "SUB 4x4", Color = "Negro", Año = 2021, Fabricante = "Jeep", Modelo = "Wrangler" },
                new { Placa = "JKL012", Tipo = "Automóvil", Color = "Blanco", Año = 2018, Fabricante = "Honda", Modelo = "Civic" },
                new { Placa = "MNO345", Tipo = "SUB 4x2", Color = "Azul", Año = 2022, Fabricante = "Nissan", Modelo = "X-Trail" },
                new { Placa = "PQR678", Tipo = "Automóvil", Color = "Plata", Año = 2020, Fabricante = "Chevrolet", Modelo = "Cruze" }
            };
            // Ciclo foreach para mostrar los datos de los vehículos
            Console.WriteLine("Datos de los vehículos:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Placa\t\tTipo\t\tColor\tAño\tFabricante\tModelo");
            Console.WriteLine("--------------------------------------------------");

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"{vehiculo.Placa}\t{vehiculo.Tipo}\t{vehiculo.Color}\t{vehiculo.Año}\t{vehiculo.Fabricante}\t{vehiculo.Modelo}");
            }

            Console.WriteLine();

            //contadores
            TourVacaciones tour1 = new TourVacaciones(1, "Playa");
            TourVacaciones tour2 = new TourVacaciones(1, "Playa");

            Console.ReadKey();


        }
    }
}
