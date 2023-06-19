using System;
using System.Collections.Generic;
using System.Text;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaPuestoTrabajo
    {
        //Atributos
        private string _cadenaConexion;

        //Constructor
        public LogicaPuestoTrabajo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para llamar al método Insertar de la capa de datos
        public int InsertarPuestoTrabajo(EntidadPuestoTrabajo objPuestoTrabajo)
        {
            int id = 0;

            AccesoDatosPuestoTrabajo accesoDatosPuesto = new AccesoDatosPuestoTrabajo(_cadenaConexion);

            try
            {
                id = accesoDatosPuesto.InsertarPuestoTrabajo(objPuestoTrabajo);
            }
            catch (Exception ex)
            {

                throw ex;
            }





            return id;
        }//FinInsertarPuestoTrabajo

        //Método para listar puestos de trabajo
        public List<EntidadPuestoTrabajo> listaPuestoTrabajo()
        {
            List<EntidadPuestoTrabajo> puestosTrabajo = new List<EntidadPuestoTrabajo>();

            AccesoDatosPuestoTrabajo accesoPuestoTrabajo = new AccesoDatosPuestoTrabajo(_cadenaConexion);

            try
            {
                puestosTrabajo = accesoPuestoTrabajo.listaPuestoTrabajo();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return puestosTrabajo;
        }//Fin ListaPuestoTrabajo

    }
}
