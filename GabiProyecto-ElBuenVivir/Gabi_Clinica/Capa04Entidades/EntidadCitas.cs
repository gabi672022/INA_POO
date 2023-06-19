using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadCitas
    {
        public int IdCitas { get; set; }
        public EntidadPacientes objPaciente { get; set; }
        public EntidadEspecialistas objEspecialista { get; set; }
        public string FechaCita { get; set; }
        public string FechaCreacion { get; set; }
    }
}
