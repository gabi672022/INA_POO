using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadFuncionariosEspecialidades
    {   
        public int IdFuncionarioEspecialidad { get; set; }
        public EntidadFuncionarios objFuncionario { get; set; }
        public EntidadEspecialidades objEspecialidades { get; set; }


        public EntidadFuncionariosEspecialidades(int idFuncionarioEspecialidad, EntidadFuncionarios objFuncionario, EntidadEspecialidades objEspecialidades)
        {
            IdFuncionarioEspecialidad = idFuncionarioEspecialidad;
            this.objFuncionario = objFuncionario;
            this.objEspecialidades = objEspecialidades;
        }

        public EntidadFuncionariosEspecialidades()
        {
            IdFuncionarioEspecialidad = 0;
            this.objFuncionario = objFuncionario;
            this.objEspecialidades = objEspecialidades;
        }





    }//Fin EntidadFuncionariosEspecialidades



}
