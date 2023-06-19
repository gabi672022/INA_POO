using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadLaboratorios
    {
        public int IdHistorialClinico { get; set; }
        public EntidadPacientes objPaciente { get; set; }
        public EntidadEspecialistas objEspecialista { get; set; }
        public EntidadMedicamentos objMedicamento { get; set; }
        public EntidadSignosVitales objSignosVitales { get; set; }
        public EntidadLaboratorios objLaboratorio { get; set; }
        public string FechaCreacion { get; set; }
        
    }
}
