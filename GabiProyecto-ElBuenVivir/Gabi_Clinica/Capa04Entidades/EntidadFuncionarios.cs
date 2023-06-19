using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadFuncionarios
    {
        //Propiedades
        public int IdFuncionario { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cedula { get; set; }
        public string FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public EntidadPuestoTrabajo objPuestoTrabajo { get; set; }



        public EntidadFuncionarios(int idFuncionario, string nombre, string primerApellido, string segundoApellido, string cedula, string fechaNacimiento, string genero, string telefono, string correo, string fechaCreacion, bool estado, EntidadPuestoTrabajo objPuestoTrabajo)
        {
            IdFuncionario = idFuncionario;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            FechaNacimiento = fechaNacimiento;
            Genero = genero;
            Telefono = telefono;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            this.objPuestoTrabajo = objPuestoTrabajo;
        }

        public EntidadFuncionarios()
        {
            IdFuncionario = 0;
            Nombre = string.Empty;
            PrimerApellido = string.Empty;
            SegundoApellido = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = string.Empty;
            Genero = string.Empty;
            Telefono = string.Empty;
            Correo = string.Empty;
            FechaCreacion = string.Empty;
            Estado = true;
            this.objPuestoTrabajo = objPuestoTrabajo;
        }


        public override string ToString()
        {
            return string.Format("{0}-{1}", IdFuncionario, Nombre);
        }

    }
}
