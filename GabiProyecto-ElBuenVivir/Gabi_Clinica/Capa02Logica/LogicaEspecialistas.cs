using System;
using System.Collections.Generic;
using System.Text;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaEspecialistas
    {
        private string _cadenaConexion;

        //Constructor
        public LogicaEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public List<EntidadEspecialistas> listaEspecialistas()
        {
            List<EntidadEspecialistas> especialistas = new List<EntidadEspecialistas>();

            AccesoDatosEspecialistas accesoEspecialista = new AccesoDatosEspecialistas(_cadenaConexion);

            try
            {
                especialistas = accesoEspecialista.listaEspecialistas();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return especialistas;
        }//Fin ListaPuestoTrabajo


    }//Fin LogicaEspecialistas
}
