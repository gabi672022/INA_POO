using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadHorariosEspecialistas
    {
        public int IdHorarioEspecialista { get; set; }
        public EntidadEspecialistas objEspecialista { get; set; }
        public string Dia { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_fin { get; set; }
        public string FechaAgenda { get; set; }

        

        public EntidadHorariosEspecialistas(int idHorarioEspecialista, EntidadEspecialistas objEspecialista, string dia, string hora_inicio, string hora_fin, string fechaAgenda)
        {
            IdHorarioEspecialista = idHorarioEspecialista;
            this.objEspecialista = objEspecialista;
            Dia = dia;
            Hora_inicio = hora_inicio;
            Hora_fin = hora_fin;
            FechaAgenda = fechaAgenda;
        }

        public EntidadHorariosEspecialistas()
        {
            IdHorarioEspecialista = 0;
            this.objEspecialista = objEspecialista;
            Dia = string.Empty;
            Hora_inicio = string.Empty;
            Hora_fin = string.Empty;
            FechaAgenda = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", IdHorarioEspecialista, objEspecialista.objEspecialidades.NombreEsp);
        }

    }
}
