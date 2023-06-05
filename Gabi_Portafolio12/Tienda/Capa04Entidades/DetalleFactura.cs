using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class DetalleFactura
    {
        public int Id_Factura { get; set; }
        public int Id_Producto { get; set; }
        public double Cantidad { get; set; }
    }
}
