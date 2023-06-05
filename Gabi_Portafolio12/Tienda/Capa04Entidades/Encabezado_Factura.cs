using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class Encabezado_Factura
    {
        public int Id_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Cliente { get; set; }
        public double Sub_Total { get; set; }
        public double Impuesto { get; set; }
        public double Monto_Descuento { get; set; }
    }
}
