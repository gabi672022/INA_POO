using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//POrtafolio08
//Estudiante: Gabriela Guiérrez Hernández
namespace Gabi_Portafolio08
{
    class Program
    {

        static void Main(string[] args)
        {
            bool salir = false;
            string respuesta = String.Empty;
            int opcion = 0;
            bool esNumero = true;

            while (!salir)
            {
                Console.WriteLine("***MENU***");
                Console.WriteLine("1.Contar números positivos, negativos y ceros");
                Console.WriteLine("2. Contar números mayores o iguales a 100 y menores a 100 de forma variable");
                Console.WriteLine("3. Contar alumnos que aprobaron y reprobaron");
                Console.WriteLine("4. Contar Pares e Impares");
                Console.WriteLine("5. Contar hasta el ingreso de 5 negativos ");
                Console.WriteLine("6. Sumatoria de 10 numeros");
                Console.WriteLine("7. Sumatoria de 10 numeros pares");
                Console.WriteLine("8. SumatoriaPromedioNumeros");
                Console.WriteLine("9. CuentaHastaMultiploCinco");
                Console.WriteLine("10. CuentaEdadPorRango");
                Console.WriteLine("11. CuentaNumPositivosHastaDiezPares");
                Console.WriteLine("12. Salir");
                Console.WriteLine();

                Console.WriteLine("Seleccione una opción: ");

                respuesta = Console.ReadLine();

                esNumero = int.TryParse(respuesta, out opcion);

                if (esNumero)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Contar números positivos, negativos y ceros ");
                            CuentaNumeros();

                            break;
                        case 2:
                            Console.WriteLine("Contar números mayores o iguales a 100 y menores a 100 de forma variable");
                            CuentaNumerosVariable();

                            break;
                        case 3:
                            Console.WriteLine("Contar alumnos que aprobaron y reprobaron ");
                            CuentaAproRepro();

                            break;
                        case 4:
                            Console.WriteLine("Contar Pares e Impares");
                            ContarParesImpares();

                            break;
                        case 5:
                            Console.WriteLine("Contar hasta el ingreso de 5 negativos  ");
                            CuentaHastaCincoNeg();


                            break;
                        case 6:
                            Console.WriteLine("Sumatoria de 10 numeros ");
                            SumatorioDiezNum();

                            break;
                        case 7:
                            Console.WriteLine("Sumatoria de 10 numeros pares ");
                            SumatoriaNumerosPares();

                            break;
                        case 8:
                            Console.WriteLine("SumatoriaPromedioNumeros ");
                            SumatoriaPromedioNumeros();

                            break;
                        case 9:
                            Console.WriteLine("Cuenta numeros hasta multiplo de cinco ");
                            CuentaHastaMultiploCinco();



                            break;
                        case 10:
                            Console.WriteLine("CuentaEdadPorRango ");
                            CuentaEdadPorRango();



                            break;
                        case 11:
                            Console.WriteLine("CuentaNumPositivosHastaDiezPares ");
                            CuentaNumPositivosHastaDiezPares();

                            break;


                        case 12:
                            Console.WriteLine("Salir ");
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Opción incorrecta. Intente nuevamente.");

                            break;


                    }

                }
                else
                {
                    Console.WriteLine("Opción incorrecta. Intente nuevamente.");
                }
                Console.WriteLine();
            }
        }//Fin del main
         //***********1***************************************************
         //Contar números positivos, negativos y ceros
        static void CuentaNumeros()
        {
            int numPos = 0;
            int numNeg = 0;
            int numCero = 0;
            int numero = 0;

            Console.WriteLine("Ingresa 20 números: ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Número #{i + 1}: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    numPos++;
                }
                else if (numero < 0)
                {
                    numNeg++;
                }
                else
                {
                    numCero++;

                }
            }

            Console.WriteLine($"Cantidad de números positivos: {numPos}");
            Console.WriteLine($"Cantidad de números negativos: {numNeg}");
            Console.WriteLine($"Cantidad de números ceros: {numCero}");
        }//fin

        //***********2***************************************************
        static void CuentaNumerosVariable()
        {
            int mayorIgualCien = 0;
            int menorCien = 0;
            int numero = 0;
            string respuesta = String.Empty;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 100)
                {
                    mayorIgualCien++;
                }
                else
                {
                    menorCien++;
                }

                Console.WriteLine("¿Desea ingresar otro número ? (s / n): ");
                respuesta = Console.ReadLine();

            } while (respuesta.ToLower() == "s");

            Console.WriteLine($"Cantidad de números mayores o iguales  a 100: {mayorIgualCien}");
            Console.WriteLine($"Cantidad de menores  a 100: {menorCien}");

        }//Fin
        //***********3********************
        static void CuentaAproRepro()
        {
            int aprobados = 0;
            int reprobados = 0;
            int nota = 0;

            Console.WriteLine("Ingrese las notas de 10 alumnos:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nota del alumno #{i + 1}: ");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 70)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            Console.WriteLine($"Cantidad de alumnos que aprobaron: {aprobados}");
            Console.WriteLine($"Cantidad de alumnos que reprobaron: {reprobados}");

            Console.ReadLine();

        }//Fin

        //**********4******************
        static void ContarParesImpares()
        {
            int par = 0;
            int impar = 0;
            int multiploTres = 0;
            string respuesta;
            int numero = 0;

            do
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if (numero % 3 == 0)
                {
                    multiploTres++;
                }

                Console.Write("¿Desea ingresar otro número? (s/n): ");
                respuesta = Console.ReadLine();
            }
            while (respuesta.ToLower() == "s");

            Console.WriteLine($"Cantidad de números pares: {par}");
            Console.WriteLine($"Cantidad de números impares: {impar}");
            Console.WriteLine($"Cantidad de números múltiplos de tres: {multiploTres}");

            Console.ReadLine();

        }//Fin
        //*********5**********************
        static void CuentaHastaCincoNeg()
        {
            int contador = 0; // Contador para el número total de números leídos
            int numero = 0;

            Console.WriteLine("Ingrese números. Ingrese 5 números negativos para finalizar.");

            while (contador < 5)
            {
                Console.Write("Ingrese un número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                    contador++;

                // Puedes agregar aquí alguna lógica adicional si deseas hacer algo con los números leídos

            }

            Console.WriteLine("Cantidad total de números leídos: " + contador);
            Console.ReadLine();

        }//Fin
        //*********6**********************
        static void SumatorioDiezNum()
        {
            int suma = 0; // Variable para almacenar la suma de los números

            Console.WriteLine("Ingrese 10 números:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Número " + i + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());

                suma += numero; // Sumar el número ingresado a la suma total
            }

            Console.WriteLine("La suma de los 10 números ingresados es: " + suma);
            Console.ReadLine();

        }//Fin

        //********7***********************************
        static void SumatoriaNumerosPares(){
            int suma = 0; // Variable para almacenar la suma de los números

            Console.WriteLine("Ingrese 10 números:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Número {i}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                suma += numero; // Sumar el número ingresado a la suma total
            }

            Console.WriteLine("La suma de los 10 números ingresados es: " + suma);
            Console.ReadLine();


        }//Fin

        //********8**************************
        static void SumatoriaPromedioNumeros()
        {
            int suma = 0; // Variable para almacenar la suma de los números
            int contador = 0; // Variable para contar la cantidad de números ingresados

            Console.WriteLine("Ingrese números. Ingrese un número negativo para finalizar.");

            while (true)
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                    break; // Salir del bucle si se ingresa un número negativo

                suma += numero; // Sumar el número ingresado a la suma total
                contador++; // Incrementar el contador de números ingresados
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador; // Calcular el promedio

                Console.WriteLine("La suma de los números es: " + suma);
                Console.WriteLine("El promedio de los números es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
            }

            Console.ReadLine();
        }//Fin
    
        //**************9********************
        static void CuentaHastaMultiploCinco()
        {
            int contador = 0; // Variable para contar la cantidad de números ingresados

            Console.WriteLine("Ingrese números. Ingrese un número múltiplo de 5 para finalizar.");

            while (true)
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 5 == 0)
                    break; // Salir del bucle si se ingresa un número múltiplo de 5

                contador++; // Incrementar el contador de números ingresados
            }

            Console.WriteLine("La cantidad de números ingresados, sin contar el múltiplo de 5, es: " + contador);
            Console.ReadLine();


        }//Fin

        //**************10********************
        static void CuentaEdadPorRango()
        {
            int contadorNinos = 0; // Contador de niños
            int contadorAdolescentes = 0; // Contador de adolescentes
            int contadorJovenes = 0; // Contador de jóvenes
            int contadorAdultos = 0; // Contador de adultos
            int contadorAdultosMayores = 0; // Contador de adultos mayores

            bool leerOtroAsistente = true;

            while (leerOtroAsistente)
            {
                Console.Write("Ingrese la edad del asistente: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 1 && edad <= 10)
                {
                    contadorNinos++;
                }
                else if (edad >= 11 && edad <= 15)
                {
                    contadorAdolescentes++;
                }
                else if (edad >= 16 && edad <= 22)
                {
                    contadorJovenes++;
                }
                else if (edad >= 23 && edad <= 65)
                {
                    contadorAdultos++;
                }
                else if (edad > 65)
                {
                    contadorAdultosMayores++;
                }

                Console.Write("¿Desea leer otro asistente? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    leerOtroAsistente = false;
                }
            }

            Console.WriteLine("Cantidad de niños: " + contadorNinos);
            Console.WriteLine("Cantidad de adolescentes: " + contadorAdolescentes);
            Console.WriteLine("Cantidad de jóvenes: " + contadorJovenes);
            Console.WriteLine("Cantidad de adultos: " + contadorAdultos);
            Console.WriteLine("Cantidad de adultos mayores: " + contadorAdultosMayores);
            Console.ReadLine();

        }//Fin

        //**************11********************
        static void CuentaNumPositivosHastaDiezPares()
        {

            int contadorPares = 0; // Contador para números pares
            int contadorCinco = 0; // Contador para número 5
            int contadorTotal = 0; // Contador para la totalidad de números leídos

            Console.WriteLine("Ingrese números positivos. Debe reunir 10 números pares o el número 5 cuatro veces.");

            while (contadorPares < 10 && contadorCinco < 4)
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    contadorPares++;
                }

                if (numero == 5)
                {
                    contadorCinco++;
                }

                contadorTotal++;
            }

            Console.WriteLine("Total de números leídos: " + contadorTotal);
            Console.ReadLine();

        }//Fin

    }//Fin class
}//Fin namespace
