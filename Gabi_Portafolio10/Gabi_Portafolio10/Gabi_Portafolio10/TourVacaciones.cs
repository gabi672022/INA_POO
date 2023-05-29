using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gabi_Portafolio10
{
    class TourVacaciones
    {
        static int contador = 0;
        private int IdTour { get; set; }
        private string Destino { get; set; }

        public double precio;
        private double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("El precio debe ser mayor que cero");
                }
            }
        }

        private DateTime Fecha_Salida { get; set; }
        private DateTime Fecha_Regreso { get; set; }
        private string Descripcion { get; set; }

        //método constructor con parámetros
        public TourVacaciones(int idTour, string destino, double precio, DateTime fechaSalida, DateTime fechaRegreso, string descripcion)
        {
            IdTour = idTour;
            Destino = destino;
            Precio = precio;
            Fecha_Salida = fechaSalida;
            Fecha_Regreso = fechaRegreso;
            Descripcion = descripcion;
            contador++;
        }
        //método constructor sin parámetros (valores por defecto)
        public TourVacaciones()
        {
            IdTour = 0;
            Destino = "";
            Precio = 0.0;
            Fecha_Salida = DateTime.MinValue;
            Fecha_Regreso = DateTime.MinValue;
            Descripcion = "";
            contador++;
        }
        public TourVacaciones(int idTour, string destino)
        {
            IdTour = idTour;
            Destino = destino;
            contador++;
        }

        //Métodos
        public TourVacaciones [] IngresarTour ()
        {
            TourVacaciones[] tours = new TourVacaciones[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese los datos para el tour {i+1}:");
                Console.Write("ID del Tour: ");
                int idTour = int.Parse(Console.ReadLine());

                Console.Write("Destino: ");
                string destino = Console.ReadLine();

                Console.Write("Precio: ");
                double precio = double.Parse(Console.ReadLine());

                Console.Write("Fecha de Salida (dd/mm/aaaa): ");
                DateTime fechaSalida = DateTime.Parse(Console.ReadLine());

                Console.Write("Fecha de Regreso (dd/mm/aaaa): ");
                DateTime fechaRegreso = DateTime.Parse(Console.ReadLine());

                Console.Write("Descripción: ");
                string descripcion = Console.ReadLine();

                //Crear el objeto tourVacaciones
                TourVacaciones tour = new TourVacaciones(idTour, destino, precio, fechaSalida, fechaRegreso, descripcion);

                tours[i] = tour;
                Console.WriteLine(); ;
            }
            return tours;
        }//Fin TourVacaciones

        public void MostrarTours(TourVacaciones[] tours)
        {
            Console.WriteLine("Datos de los tours:");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ID\tDestino\t\tPrecio\t\tFecha Salida\tFecha Regreso\tDescripción");
            Console.WriteLine("--------------------------------------------------");

            foreach (TourVacaciones tour in tours)
            {
                Console.WriteLine($"{tour.IdTour}\t{tour.Destino}\t\t{tour.Precio}\t\t{tour.Fecha_Salida.ToShortDateString()}\t{tour.Fecha_Regreso.ToShortDateString()}\t{tour.Descripcion}");
            }


        }
        public static void MostrarCantidadObjetos()
        {
            Console.WriteLine("Cantidad de objetos de la clase TourVacaciones: " + contador);
        }


    }//Fin class TourVacaciones
}//Fin namespace
