using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadHistorialClinico
    {
        public int IdHistorialClinico { get; set; }
        public EntidadPacientes objPaciente { get; set; }
        public EntidadEspecialistas objEspecialistas { get; set; }
        public EntidadDiagnosticos objDiagnosticos { get; set; }
        public EntidadMedicamentos objMedicamentos { get; set; }
        public EntidadSignosVitales objSignosVitales { get; set; }
        public EntidadLaboratorios objLaboratorios { get; set; }
        public string FechaCreacion { get; set; }
    }
}
