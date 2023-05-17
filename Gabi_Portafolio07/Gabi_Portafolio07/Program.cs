using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabi_Portafolio07
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double ancho = 0.0;
            double fondo = 0.0;
            double areaM2= 0.0;

            Console.WriteLine("*************************************");
            Console.WriteLine("1.Área de un terreno rectangular (m2)");
            Console.WriteLine("*************************************");

            //Pedir datos al usuario
            Console.WriteLine("Ingrese el ancho del terreno en ft: ");
            ancho = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el fondo del terreno en ft: ");
            fondo = double.Parse(Console.ReadLine());

            areaM2 = ancho * fondo * (0.3048 * 0.3048);

            Console.WriteLine("El área del terreno es: " + areaM2 + "m2");

            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");


            //SalarioBruto del empleado
            double salarioBase = 0.0;
            double comision = 0.10;
            double ventasMensuales=0.0;
            double salarioBruto = 0.0;
            Console.WriteLine("*************************************");
            Console.WriteLine("2.Salario Bruto de un empleado de una tienda");
            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese las ventas mensuales del empleado:");
            ventasMensuales= double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el salario base del empleado:");
            salarioBase = double.Parse(Console.ReadLine());

            salarioBruto = salarioBase + ventasMensuales * comision;

            Console.WriteLine("El salario bruto por mes es de: " + salarioBruto);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");


            //Convertir horas, minutos, segundos a segundos
            int horas, min, seg, segundosTotales = 0;
            Console.WriteLine("*************************************");
            Console.WriteLine("3.Conversión de horas minutos y segundos a segundos");
            Console.WriteLine("*************************************");
            Console.WriteLine("Ingrese la cantidad de horas: ");
            horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de minutos: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de segundos: ");
            seg = Convert.ToInt32(Console.ReadLine());

            segundosTotales = horas * 3600 + min * 60 + seg;

            Console.WriteLine("La cantidad de segundos corresponde a: " + segundosTotales);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");


            //Convertir segundos y mostrarlos en hora, minutos y segundos
            Console.WriteLine("*************************************");
            Console.WriteLine("4.Conversión de segundos a horas minutos y segundos");
            Console.WriteLine("*************************************");
            int horas2, min2, seg2, segundosTotales2, residuo = 0;
            Console.WriteLine("Digite la cantidad de segundos: ");
            segundosTotales2 = Convert.ToInt32(Console.ReadLine());

            horas2 = segundosTotales2 / 3600;
            residuo= segundosTotales2 % 3600;

            min2 = residuo / 60;
            seg2 = residuo % 60;

            Console.WriteLine(horas2 +" Horas, " +min2 + " minutos, "+seg2+ " segundos");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");

            //Convertir MB y se muestre bits, byte, kilobyte, Gigabytes
            Console.WriteLine("*************************************");
            Console.WriteLine("5.Conversión de MB a bits, byte, kilobyte, Gigabytes");
            Console.WriteLine("*************************************");
            double mB, bit, byte1, kb, gb = 0.0;
            Console.WriteLine("Ingrse la cantidad de MB: ");
            mB = Convert.ToDouble(Console.ReadLine());

            bit = mB * 8;
            byte1 = mB * 1024 * 1024;
            kb = mB * 1024;
            gb = mB / 1024;
            Console.WriteLine("");
            Console.WriteLine("Bits: " + bit);
            Console.WriteLine("Byte: " + byte1);
            Console.WriteLine("KiloByte: " + kb);
            Console.WriteLine("GigaByte: " + gb);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
            
            //Calcular aguinaldo de trabajador por 12 meses laborados
            Console.WriteLine("*************************************");
            Console.WriteLine("6. Aguinaldo de trabajador por 12 meses laborados");
            Console.WriteLine("*************************************");
            double[] salarios = new double[12];
            double sumaSalarios = 0;
            double aguinaldo = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese el salario " + (i + 1) + ":");
                salarios[i] = Convert.ToDouble(Console.ReadLine());
                sumaSalarios += salarios[i];
            }

            aguinaldo = sumaSalarios / 12;

            Console.WriteLine("El aguinaldo es: " + aguinaldo);
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("");
         
            //Postes son necesarios para cercar el terreno
            Console.WriteLine("*************************************");
            Console.WriteLine("7. Postes son necesarios para cercar el terreno");
            Console.WriteLine("*************************************");

            double anchoT, perimetro = 0;
            int cantidadPostes = 0;

            Console.WriteLine("Ingrese el ancho del terreno (m):");
            anchoT = Convert.ToDouble(Console.ReadLine());
            perimetro = 6 * anchoT;
            cantidadPostes = (int)(perimetro / 2);

            Console.WriteLine("La cantidad de postes es de: " + cantidadPostes);
            Console.ReadKey();
            Console.WriteLine("");





        }
    }
}
