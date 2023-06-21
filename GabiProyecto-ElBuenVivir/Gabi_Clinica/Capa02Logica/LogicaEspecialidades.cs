using System;
using System.Collections.Generic;
using System.Text;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaEspecialidades
    {
        //Atributos
        private string _cadenaConexion;

        //Constructor
        public LogicaEspecialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para llamar al método Insertar de la capa de datos
        public int InsertarEspecialidad(EntidadEspecialidades objEspecialidad)
        {
            int id = 0;

            AccesoDatosEspecialidades accesoDatosEspecialidades = new AccesoDatosEspecialidades(_cadenaConexion);

            try
            {
                id = accesoDatosEspecialidades.InsertarEspecialidades(objEspecialidad);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return id;
        }//FinInsertarEspecialidad

        //Método para listar Especialidades
        public List<EntidadEspecialidades> listaEspecialidades()
        {
            List<EntidadEspecialidades> especialidades = new List<EntidadEspecialidades>();

            AccesoDatosEspecialidades accesoEspecialidad = new AccesoDatosEspecialidades(_cadenaConexion);

            try
            {
                especialidades = accesoEspecialidad.listaEspecialidades();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return especialidades;
        }//Fin ListaPuestoTrabajo

        public bool EditarEspecialidades(EntidadEspecialidades especialidades, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosEspecialidades accesoDatos = new AccesoDatosEspecialidades(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EditarEspecialidades(especialidades, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin EditarEspecialidades


    }//Fin LogicaEspecialidades
}
