using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class ClsPromedio
    {
        private string condicion = string.Empty;
        private string color = string.Empty;
        private double promedio = 0.0;


        public ClsPromedio()
        {
            condicion = string.Empty; ;
            color = string.Empty; ;
            promedio = 0.0;
        }
        public ClsPromedio(string condicion, string color, double promedio)
        {
            this.condicion = condicion;
            this.color = color;
            this.promedio = promedio;
        }

        public string Condicion { get => condicion; set => condicion = value; }
        public string Color { get => color; set => color = value; }
        public double Promedio { get => promedio; set => promedio = value; }

        public double CalculoPromedio(double sumaNotas, int cantNotas)
        {
            double promedio = 0.0;

            promedio = sumaNotas / cantNotas;
            return promedio;
        }


        public Dictionary<string, string> calculoCondicion(double promedio)
        {

            Dictionary<string, string> diccionario = new Dictionary<string, string>();
           

            if (promedio >= 70)
            {
                diccionario.Add("Condicion", "APROBADO");
                diccionario.Add("Color", "Green");

            }
            else
            {
                diccionario.Add("Condicion", "REPROBADO");
                diccionario.Add("Color", "RED");
            }

            return diccionario;
        }


       


        


    }//Fin ClsPromedio
}
