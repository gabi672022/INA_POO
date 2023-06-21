using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadAccesoSistema
    {
        //Propiedades
        public int IdAccesoSistema { get; set; }
        public string Clave { get; set; }
        public int NivelAcceso { get; set; }
        public string FechaCreacion { get; set; }
        public EntidadFuncionarios objFuncionario { get; set; }


        //Constructor
        public EntidadAccesoSistema(int idAccesoSistema, string clave, int nivelAcceso, string fechaCreacion, EntidadFuncionarios objFuncionario)
        {
            IdAccesoSistema = idAccesoSistema;
            Clave = clave;
            NivelAcceso = nivelAcceso;
            FechaCreacion = fechaCreacion;
            this.objFuncionario = objFuncionario;
        }


        public EntidadAccesoSistema()
        {
            IdAccesoSistema = 0;
            Clave = string.Empty;
            NivelAcceso = 0;
            FechaCreacion = string.Empty;
            this.objFuncionario = objFuncionario;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", IdAccesoSistema, NivelAcceso);
        }












    }//FinEntidadAccesoSistema
}
