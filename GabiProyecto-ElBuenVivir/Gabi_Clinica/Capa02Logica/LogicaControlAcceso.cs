using System;
using System.Collections.Generic;
using System.Text;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaControlAcceso
    {
        //Atributos
        private string _cadenaConexion;

        //Constructor
        public LogicaControlAcceso(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para llamar al método Insertar de la capa de datos
        public int InsertarAccesoSistema(EntidadAccesoSistema objAccesoSistema)
        {
            int id = 0;

            AccesoDatosControlAcceso accesoControlSistema = new AccesoDatosControlAcceso(_cadenaConexion);

            try
            {
                id = accesoControlSistema.InsertarAccesoSistema(objAccesoSistema);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return id;
        }//FinInsertarPuestoTrabajo



        //Método para listar acceso 
        public List<EntidadAccesoSistema> listaAccesoSistema()
        {
            List<EntidadAccesoSistema> accesoSistemas = new List<EntidadAccesoSistema>();

            AccesoDatosControlAcceso accesoControlSistema = new AccesoDatosControlAcceso(_cadenaConexion);

            try
            {
                accesoSistemas = accesoControlSistema.listaAccesoSistema();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return accesoSistemas;
        }//Fin ListaPuestoTrabajo

        public bool EditarControlAcceso(EntidadAccesoSistema objAccesoSistema, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosControlAcceso accesoDatos = new AccesoDatosControlAcceso(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EditarAccesoSistema(objAccesoSistema, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin EditarEditarControlAcceso



    }//Fin LogicaControlAcceso
}
