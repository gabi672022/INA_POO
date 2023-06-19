using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadSignosVitales
    {
        public int IdSignosVitales { get; set; }
        public string Descripcion { get; set; }
        public double Presion { get; set; }
        public double Temperatura { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }
        public string FechaCreacion { get; set; }
    }
}
