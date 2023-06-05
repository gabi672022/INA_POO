using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class Productos
    {
        public int Id_Productos { get; set; }
        public string Descripcion { get; set; }
        public double Precio_Compra { get; set; }
        public double Precio_Venta { get; set; }
        public bool Gravado { get; set; }

    }
}
