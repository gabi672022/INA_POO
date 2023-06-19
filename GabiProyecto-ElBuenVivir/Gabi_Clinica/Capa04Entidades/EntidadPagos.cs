using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadPagos
    {
        public int IdPagos { get; set; }
        public EntidadCitas objCitas { get; set; }
        public double Monto { get; set; }
        public string FechaPago { get; set; }
        public string FormaPago { get; set; }
        public double Descuento { get; set; }
        public double MontoFinal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
