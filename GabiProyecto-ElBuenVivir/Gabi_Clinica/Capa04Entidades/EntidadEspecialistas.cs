using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadEspecialistas
    {
        public int IdEspecialista { get; set; }
        public EntidadEspecialidades objEspecialidades { get; set; }
        public string HorarioDisponible { get; set; }
        public string FechaCreacion { get; set; }
        public bool Estado { get; set; }


        public EntidadEspecialistas(int idEspecialista, EntidadEspecialidades objEspecialidades, string horarioDisponible, string fechaCreacion, bool estado)
        {
            IdEspecialista = idEspecialista;
            this.objEspecialidades = objEspecialidades;
            HorarioDisponible = horarioDisponible;
            FechaCreacion = fechaCreacion;
            Estado = estado;
        }


        public EntidadEspecialistas()
        {
            IdEspecialista = 0;
            this.objEspecialidades = objEspecialidades;
            HorarioDisponible = string.Empty;
            FechaCreacion = string.Empty;
            Estado = true;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", IdEspecialista, objEspecialidades.NombreEsp);
        }


    }//FinClassEntidadEspecialistas
}
