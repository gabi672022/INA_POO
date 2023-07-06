using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;






using Capa04Entidades;
using System.Globalization;

namespace Capa03AccesoDatos
{
    public class AccesoDatosHorariosEspecialistas
    {
        private string _cadenaConexion;

        public AccesoDatosHorariosEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public int InsertarHorarioEspecialista(EntidadHorariosEspecialistas objHorariosEspecialistas)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            

            try
            {
                conexion.Open();

                //if (ExisteChoqueHorario(objHorariosEspecialistas))
                //{
                //    throw new Exception("Error: Existe choque de horario.");
                //}

                //Insertar el nuevo horario

                string consultaInsertarHorario = "insert into HorariosEspecialistas(IdEspecialista, Hora_inicio, Hora_fin, FechaAgenda) values (@IdEspecialista, @Hora_inicio, @Hora_fin, @FechaAgenda) select @@Identity";

                SqlCommand comando = new SqlCommand(consultaInsertarHorario, conexion);
                comando.Parameters.AddWithValue("@IdEspecialista", objHorariosEspecialistas.objEspecialista.IdEspecialista);
                comando.Parameters.AddWithValue("@Hora_inicio",objHorariosEspecialistas.Hora_inicio);
                comando.Parameters.AddWithValue("@Hora_fin", TimeSpan.Parse(objHorariosEspecialistas.Hora_fin));
                comando.Parameters.AddWithValue("@FechaAgenda", DateTime.Parse(objHorariosEspecialistas.FechaAgenda));

                id= Convert.ToInt32(comando.ExecuteScalar());

                conexion.Close();
            }
            catch (Exception)
            {

                throw new Exception("Error: a la hora de insertar el horario");
            }

            return id;
        }//FinInsertarHorarioEspecialista


        private bool ExisteChoqueHorario(EntidadHorariosEspecialistas objHorariosEspecialistas)
        {
            //EntidadHorariosEspecialistas objHorariosEspecialistas = new EntidadHorariosEspecialistas();


            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //string consultaChoque = "select  1 from HorariosEspecialistas h where h.IdEspecialista= @IdEspecialista and h.Dia= @Dia and ( (@Hora_inicio >= h.Hora_inicio and @Hora_inicio < h.Hora_fin) or (@Hora_fin > h.Hora_inicio and @Hora_fin<= h.Hora_fin) or (@Hora_inicio<= h.Hora_inicio and @Hora_fin>=h.Hora_fin))";

             
            string consultaChoque = "SELECT 1 FROM HorariosEspecialistas h WHERE h.IdEspecialista = @IdEspecialista1 AND h.FechaAgenda = @FechaAgenda1 AND((@Hora_inicio1 >= h.Hora_inicio AND @Hora_inicio1 < h.Hora_fin) OR(@Hora_fin1 > h.Hora_inicio AND @Hora_fin1 <= h.Hora_fin) OR(@Hora_inicio1 <= h.Hora_inicio AND @Hora_fin1 >= h.Hora_fin))";


            SqlCommand comando = new SqlCommand(consultaChoque, conexion);

            comando.Parameters.AddWithValue("@IdEspecialista1", objHorariosEspecialistas.objEspecialista.IdEspecialista);
            //comando.Parameters.AddWithValue("@Dia", objHorariosEspecialistas.Dia);
            comando.Parameters.AddWithValue("@Hora_inicio1", objHorariosEspecialistas.Hora_inicio);
            comando.Parameters.AddWithValue("@Hora_fin1", objHorariosEspecialistas.Hora_fin);
            comando.Parameters.AddWithValue("@FechaAgenda1", objHorariosEspecialistas.FechaAgenda);


            
                SqlDataReader lectura = comando.ExecuteReader();
                return lectura.HasRows;

        } 


    }//Fin AccesoDatosHorariosEspecialistas
}
