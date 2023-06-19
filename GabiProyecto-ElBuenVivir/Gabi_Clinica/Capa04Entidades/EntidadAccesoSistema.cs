using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadAccesoSistema
    {
        public int IdAccesoSistema { get; set; }
        public string Clave { get; set; }
        public int NivelAcceso { get; set; }
        public string FechaCreacion { get; set; }
        public EntidadFuncionarios objFuncionario { get; set; }
    }
}
