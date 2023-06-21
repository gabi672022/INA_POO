using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Capa04Entidades;


namespace Capa03AccesoDatos
{
    public class AccesoDatosControlAcceso
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosControlAcceso(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método Insertar Puesto de Trabajo
        public int InsertarAccesoSistema(EntidadAccesoSistema objAccesoSistema)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            string consultaInsertarAccesoSistema = "Insert into AccesoSistema( IdFuncionario, Clave, NivelAcceso) values (@IdFuncionario, @Clave, @NivelAcceso) Select @@Identity";

            SqlCommand comando = new SqlCommand(consultaInsertarAccesoSistema, conexion);
            comando.Parameters.AddWithValue("@IdFuncionario", objAccesoSistema.objFuncionario.IdFuncionario);
            comando.Parameters.AddWithValue("@Clave", objAccesoSistema.Clave);
            comando.Parameters.AddWithValue("@NivelAcceso", objAccesoSistema.NivelAcceso);


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


        public List<EntidadAccesoSistema> listaAccesoSistema()
        {
            List<EntidadAccesoSistema> accesoSistemas = new List<EntidadAccesoSistema>();

            SqlConnection cnx = new SqlConnection(_cadenaConexion);

            string consultaAccesoSistemas = "select IdAccesoSistema, IdFuncionario, Clave, NivelAcceso  from AccesoSistema";

            SqlCommand comando = new SqlCommand(consultaAccesoSistemas, cnx);

            try
            {
                cnx.Open();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    EntidadAccesoSistema accesoSistema = new EntidadAccesoSistema();
                    accesoSistema.IdAccesoSistema = Convert.ToInt32(lectura["IdAccesoSistema"]);
                    accesoSistema.objFuncionario = new EntidadFuncionarios();
                    accesoSistema.objFuncionario.IdFuncionario = Convert.ToInt32(lectura["IdFuncionario"]);
                    accesoSistema.Clave= lectura["Clave"].ToString();
                    accesoSistema.NivelAcceso= Convert.ToInt32(lectura["NivelAcceso"]);

                    accesoSistemas.Add(accesoSistema);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener los puestos de trabajo desde la base de datos: " + ex.Message);
            }


            return accesoSistemas;

        }//listaPuestoTrabajo 

        public bool EditarAccesoSistema(EntidadAccesoSistema objAccesoSistema, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);
                //EntidadFuncionarios objFuncionarios = new EntidadFuncionarios();

                SqlCommand comando = new SqlCommand("spEditarControlAcceso", conexion);
                comando.Parameters.AddWithValue("IdAccesoSistema", objAccesoSistema.IdAccesoSistema);
                comando.Parameters.AddWithValue("IdFuncionario", objAccesoSistema.objFuncionario.IdFuncionario);
                comando.Parameters.AddWithValue("Clave", objAccesoSistema.Clave);
                comando.Parameters.AddWithValue("NivelAcceso", objAccesoSistema.NivelAcceso);

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






    }//FinAccesoDatosControlAcceso
}
