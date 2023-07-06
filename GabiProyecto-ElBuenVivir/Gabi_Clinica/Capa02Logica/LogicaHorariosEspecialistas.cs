using System;
using System.Collections.Generic;
using System.Text;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaHorariosEspecialistas
    {
        private string _cadenaConexion;

        public LogicaHorariosEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public int InsertarHorarioEspecialista(EntidadHorariosEspecialistas objHorariosEspecialistas)
        {
            int id = 0;

            AccesoDatosHorariosEspecialistas accesoDatosHorariosEspecialistas = new AccesoDatosHorariosEspecialistas(_cadenaConexion);

            try
            {
                id = accesoDatosHorariosEspecialistas.InsertarHorarioEspecialista(objHorariosEspecialistas);
            }
            catch (Exception)
            {

                throw new Exception("Error en la Lógica de HorariosEspecialistas");
            }


            return id;
        }//FinInsertarHorarioEspecialista

    }//Fin LogicaHorariosEspecialistas
}
