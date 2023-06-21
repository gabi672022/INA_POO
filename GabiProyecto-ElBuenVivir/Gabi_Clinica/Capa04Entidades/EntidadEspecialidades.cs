using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadEspecialidades
    {
        public int IdEspecialidad { get; set; }
        public string NombreEsp { get; set; }
        public string RequisitosAcademicos { get; set; }
        public string FechaCreacion { get; set; }

        public EntidadEspecialidades(int idEspecialidad, string nombreEsp, string requisitosAcademicos, string fechaCreacion)
        {
            IdEspecialidad = idEspecialidad;
            NombreEsp = nombreEsp;
            RequisitosAcademicos = requisitosAcademicos;
            FechaCreacion = fechaCreacion;
        }
        public EntidadEspecialidades()
        {
            IdEspecialidad = 0;
            NombreEsp = string.Empty;
            RequisitosAcademicos = string.Empty;
            FechaCreacion = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", IdEspecialidad, NombreEsp);
        }
    }
}
