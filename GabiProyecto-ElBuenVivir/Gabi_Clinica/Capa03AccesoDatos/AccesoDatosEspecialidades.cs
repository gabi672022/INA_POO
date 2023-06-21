using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Capa04Entidades;

namespace Capa03AccesoDatos
{
    public class AccesoDatosEspecialidades
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosEspecialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método Insertar Puesto de Trabajo
        public int InsertarEspecialidades(EntidadEspecialidades objEspecialidades)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            string consultaInsertarEspecialidad = "Insert into Especialidades (NombreEsp, RequisitosAcademicos) values (@Nombre, @REquisitosAcademicos) Select @@Identity";

            SqlCommand comando = new SqlCommand(consultaInsertarEspecialidad, conexion);
            comando.Parameters.AddWithValue("@Nombre", objEspecialidades.NombreEsp);
            comando.Parameters.AddWithValue("@RequisitosAcademicos", objEspecialidades.RequisitosAcademicos);

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
        }//Fin InsertarEspecialidades


        public List<EntidadEspecialidades> listaEspecialidades()
        {
            List<EntidadEspecialidades> especialidades = new List<EntidadEspecialidades>();

            SqlConnection cnx = new SqlConnection(_cadenaConexion);

            string consultaListaEspecialidades = "select IdEspecialidad, NombreEsp, RequisitosAcademicos  from Especialidades";

            SqlCommand comando = new SqlCommand(consultaListaEspecialidades, cnx);

            try
            {
                cnx.Open();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    EntidadEspecialidades objEspecialidades = new EntidadEspecialidades();
                    objEspecialidades.IdEspecialidad = Convert.ToInt32(lectura["IdEspecialidad"]);
                    objEspecialidades.NombreEsp = lectura["NombreEsp"].ToString();
                    objEspecialidades.RequisitosAcademicos = lectura["RequisitosAcademicos"].ToString();

                    especialidades.Add(objEspecialidades);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener los puestos de trabajo desde la base de datos: " + ex.Message);
            }


            return especialidades;

        }//listaEspecialidades 

        public bool EditarEspecialidades(EntidadEspecialidades especialidades, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEditarEspecialidad", conexion);
                comando.Parameters.AddWithValue("IdEspecialidad", especialidades.IdEspecialidad);
                comando.Parameters.AddWithValue("NombreEsp", especialidades.NombreEsp);
                comando.Parameters.AddWithValue("RequisitosAcademicos", especialidades.RequisitosAcademicos);

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
    }
}
