using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadHorariosEspecialistas
    {
        public int IdHorarioEspecialista { get; set; }
        public EntidadEspecialistas objEspecialista { get; set; }
        public string Dia { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_fin { get; set; }
    }
}
