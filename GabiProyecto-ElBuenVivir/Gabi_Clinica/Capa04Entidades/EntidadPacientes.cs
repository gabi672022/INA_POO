using System;
using System.Collections.Generic;
using System.Text;

namespace Capa04Entidades
{
    public class EntidadPacientes
    {
        public int IdPaciente { get; set; }
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


        public EntidadPacientes(int idPaciente, string nombre, string primerApellido, string segundoApellido, string cedula, string fechaNacimiento, string genero, string telefono, string correo, string fechaCreacion, bool estado)
        {
            IdPaciente = idPaciente;
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
           
        }

        public EntidadPacientes()
        {
            IdPaciente = 0;
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
            
        }


        public override string ToString()
        {
            return string.Format("{0}-{1}", IdPaciente, Nombre);
        }
    }

}
