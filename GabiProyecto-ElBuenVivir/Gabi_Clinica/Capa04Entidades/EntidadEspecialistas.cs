using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadEspecialistas
    {
        public int IdEspecialista { get; set; }
        public EntidadEspecialidades objEspecialidades { get; set; }
        public EntidadFuncionarios objFuncionarios { get; set; }
        public EntidadPuestoTrabajo objPuestoTrabajo { get; set; }
        public string HorarioDisponible { get; set; }
        public string FechaCreacion { get; set; }
        public bool Estado { get; set; }
    }
}
