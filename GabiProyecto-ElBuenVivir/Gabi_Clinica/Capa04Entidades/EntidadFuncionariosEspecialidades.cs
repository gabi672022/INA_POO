using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    class EntidadFuncionariosEspecialidades
    {
        public int IdFuncionarioEspecialidad { get; set; }
        public EntidadFuncionarios objFuncionario { get; set; }
        public EntidadEspecialidades objEspecialidades { get; set; }
    }
}
