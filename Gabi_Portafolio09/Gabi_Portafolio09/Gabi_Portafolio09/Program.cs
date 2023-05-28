using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabi_Portafolio09
{
    
        class Program
        {
            static void Main(string[] args)
            {
                // Crear objetos de prueba
                Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, "123456789", "Editorial XYZ", 400);
                Libro libro2 = new Libro("1984", "George Orwell", 1949, "987654321", "Editorial ABC", 320);

                Cliente cliente1 = new Cliente("John Doe", "john.doe@example.com", "1234567890", "Calle 123", "Ciudad ABC", "País XYZ");
                Cliente cliente2 = new Cliente("Jane Smith", "jane.smith@example.com", "0987654321", "Calle 456", "Ciudad DEF", "País UVW");

                // Utilizar métodos getter, setter y de funcionalidad
                Console.WriteLine("Libro 1: " + libro1.GetTitulo());
                Console.WriteLine("Autor Libro 2: " + libro2.GetAutor());

                cliente1.SetEmail("john.doe@gmail.com");
                Console.WriteLine("Email Cliente 1: " + cliente1.GetEmail());

                libro2.SetAnioPublicacion(1950);
                Console.WriteLine("Año de publicación Libro 2: " + libro2.GetAnioPublicacion());

                libro1.ImprimirInformacion();
                libro2.ImprimirInformacion();

                cliente1.RealizarCompra(libro1);
                cliente2.RealizarCompra(libro2, "Tarjeta de crédito");
            Console.ReadKey();
            }
        }

        class Libro
        {
            private string titulo;
            private string autor;
            private int anioPublicacion;
            private string isbn;
            private string editorial;
            private int cantidadPaginas;

            // Constructor con todos los atributos
            public Libro(string titulo, string autor, int anioPublicacion, string isbn, string editorial, int cantidadPaginas)
            {
                this.titulo = titulo;
                this.autor = autor;
                this.anioPublicacion = anioPublicacion;
                this.isbn = isbn;
                this.editorial = editorial;
                this.cantidadPaginas = cantidadPaginas;
            }

            // Constructor con atributos obligatorios
            public Libro(string titulo, string autor, int anioPublicacion, string isbn)
                : this(titulo, autor, anioPublicacion, isbn, "", 0)
            {
            }

            // Constructor sin parámetros
            public Libro()
            {
            }

            // Métodos getter
            public string GetTitulo()
            {
                return titulo;
            }

            public string GetAutor()
            {
                return autor;
            }

        public int GetAnioPublicacion()
        {
            return anioPublicacion;
        }

        // Métodos setter
        public void SetAnioPublicacion(int anio)
            {
                anioPublicacion = anio;
            }

            public void SetEditorial(string editorial)
            {
                this.editorial = editorial;
            }

            // Método de funcionalidad
            public void ImprimirInformacion()
            {
                Console.WriteLine("Título: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Año de publicación: " + anioPublicacion);
                Console.WriteLine("ISBN: " + isbn);
                Console.WriteLine("Editorial: " + editorial);
                Console.WriteLine("Cantidad de páginas: " + cantidadPaginas);
                Console.WriteLine();
            }
        }

        class Cliente
        {
            private string nombre;
            private string email;
            private string telefono;
            private string direccion;
            private string ciudad;
            private string pais;

            // Constructor con todos los atributos
            public Cliente(string nombre, string email, string telefono, string direccion, string ciudad, string pais)
            {
                this.nombre = nombre;
                this.email = email;
                this.telefono = telefono;
                this.direccion = direccion;
                this.ciudad = ciudad;
                this.pais = pais;
            }

            // Constructor con atributos obligatorios
            public Cliente(string nombre, string email, string telefono)
                : this(nombre, email, telefono, "", "", "")
            {
            }

            // Constructor sin parámetros
            public Cliente()
            {
            }

            // Métodos getter
            public string GetNombre()
            {
                return nombre;
            }

            public string GetEmail()
            {
                return email;
            }

            // Métodos setter
            public void SetEmail(string email)
            {
                this.email = email;
            }

            public void SetTelefono(string telefono)
            {
                this.telefono = telefono;
            }

            // Método de funcionalidad
            public void RealizarCompra(Libro libro)
            {
                Console.WriteLine(nombre + " ha realizado la compra del libro " + libro.GetTitulo());
            }

            // Método de funcionalidad con sobrecarga
            public void RealizarCompra(Libro libro, string metodoPago)
            {
                Console.WriteLine(nombre + " ha realizado la compra del libro " + libro.GetTitulo() + " con el método de pago " + metodoPago);
            }

       
        public void EnviarCorreo(string asunto, string mensaje)
        {
            Console.WriteLine("Enviando correo a " + email);
            Console.WriteLine("Asunto: " + asunto);
            Console.WriteLine("Mensaje: " + mensaje);
        }
    }
    }




