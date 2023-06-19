using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadPuestoTrabajo
    {
        //Propiedades
        public int IdPuestoTrabajo { get; set; }
        public string Nombre { get; set; }
        public string Fecha_creacion { get; set; }



        //Constructor
        public EntidadPuestoTrabajo(int idPuestoTrabajo, string nombre, string fechaCreacion)
        {
            IdPuestoTrabajo = idPuestoTrabajo;
            Nombre = nombre;
            Fecha_creacion = fechaCreacion;


        }

        public EntidadPuestoTrabajo()
        {
            IdPuestoTrabajo = 0;
            Nombre = string.Empty;
            Fecha_creacion = string.Empty;
           
        }




        public override string ToString()
        {
            return string.Format("{0}-{1}", IdPuestoTrabajo, Nombre);
        }

    }
}
