using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Capa04Entidades;

namespace Capa03AccesoDatos
{
    public class AccesoDatosPuestoTrabajo
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosPuestoTrabajo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método Insertar Puesto de Trabajo
        public int InsertarPuestoTrabajo(EntidadPuestoTrabajo objPuestoTrabajo)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            string consultaInsertarPuesto = "Insert into PuestoTrabajo(Nombre) values (@Nombre) Select @@Identity";

            SqlCommand comando = new SqlCommand(consultaInsertarPuesto, conexion);
            comando.Parameters.AddWithValue("@Nombre", objPuestoTrabajo.Nombre);

            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

            return id;
        }//Fin InsertarPuestoTrabajo


        public List<EntidadPuestoTrabajo> listaPuestoTrabajo()
        {
            List<EntidadPuestoTrabajo> puestosTrabajo = new List<EntidadPuestoTrabajo>();

            SqlConnection cnx = new SqlConnection(_cadenaConexion);

            string consultaListaPuestos = "select IdPuestoTrabajo, Nombre, Fecha_creacion  from PuestoTrabajo";

            SqlCommand comando = new SqlCommand(consultaListaPuestos, cnx);

            try
            {
                cnx.Open();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    EntidadPuestoTrabajo puestoTrabajo = new EntidadPuestoTrabajo();
                    puestoTrabajo.IdPuestoTrabajo = Convert.ToInt32(lectura["IdPuestoTrabajo"]);
                    puestoTrabajo.Nombre = lectura["Nombre"].ToString();
                    puestoTrabajo.Fecha_creacion = lectura["Fecha_creacion"].ToString();

                    puestosTrabajo.Add(puestoTrabajo);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener los puestos de trabajo desde la base de datos: " + ex.Message); 
            }


            return puestosTrabajo;

        }//listaPuestoTrabajo 

        public bool EditarPuestoTrabajo(EntidadPuestoTrabajo puestoTrabajo, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEditarPuestoTrabajo", conexion);
                comando.Parameters.AddWithValue("IdPuestoTrabajo", puestoTrabajo.IdPuestoTrabajo);
                comando.Parameters.AddWithValue("Nombre", puestoTrabajo.Nombre);
               
                comando.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                comando.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = Convert.ToBoolean(comando.Parameters["Respuesta"].Value);
                Mensaje = comando.Parameters["Mensaje"].Value.ToString();


            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }//Fin EditarFuncionario



    }//AccesoDatosPuestoTrabajo
}
