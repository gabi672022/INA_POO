using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using Capa04Entidades;
using System.Globalization;

namespace Capa03AccesoDatos
{
    public class AccesoDatosFuncionario
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosFuncionario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para insertar Funcionario
        public int Insertar(EntidadFuncionarios funcionario)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            string consultaInsertar = "Insert into Funcionarios(Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo) Values (@Nombre, @PrimerApellido, @SegundoApellido, @Cedula, @FechaNacimiento, @Genero, @Telefono, @Correo, @FechaCreacion, @Estado, @IdPuestoTrabajo) Select @@Identity";

            SqlCommand comando = new SqlCommand(consultaInsertar, conexion);

            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();

            comando.Parameters.AddWithValue("@Nombre", funcionario.Nombre.ToUpper());
            comando.Parameters.AddWithValue("@PrimerApellido", funcionario.PrimerApellido.ToUpper());
            comando.Parameters.AddWithValue("@SegundoApellido", funcionario.SegundoApellido.ToUpper());
            comando.Parameters.AddWithValue("@Cedula", funcionario.Cedula);
            comando.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(funcionario.FechaNacimiento));
            comando.Parameters.AddWithValue("@Genero", funcionario.Genero.ToUpper());
            comando.Parameters.AddWithValue("@Telefono", funcionario.Telefono);
            comando.Parameters.AddWithValue("@Correo", funcionario.Correo.ToUpper());
            comando.Parameters.AddWithValue("@FechaCreacion", funcionario.FechaCreacion);
            comando.Parameters.AddWithValue("@Estado", funcionario.Estado);
          

            comando.Parameters.AddWithValue("@IdPuestoTrabajo", funcionario.objPuestoTrabajo.IdPuestoTrabajo);

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
        }//Fin Insertar



        //Metodo que devuelve un dataset con datos de los funcionarios, para ser mostrados en el DataGridView
        public DataSet ListarFuncionarios(string condicion="", string orden = "")
        {
            DataSet datos = new DataSet(); //En datos se guardarán los resultados del Select

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            List<EntidadFuncionarios> funcionarios;
            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();

            string consultaFuncionarios = "Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios";

            //Si el parámetro condición no está vacío lo concatena a la consultaFuncioanrios
            if (!string.IsNullOrEmpty(condicion))
            {
                consultaFuncionarios = string.Format("{0} where {1}", consultaFuncionarios, condicion);
            }

            //Si el parámetro orden no está vacío lo concatena a la sentencia
            if (!string.IsNullOrEmpty(orden))
            {
                consultaFuncionarios = string.Format("{0} order by {1}", consultaFuncionarios, orden);
            }

            try
            {
                adapter = new SqlDataAdapter(consultaFuncionarios, conexion);
                //El adapter.Fill llena "adapter" con los datos que tiene el dataSet "datos" y le asigna el nombre "Clientes"

                adapter.Fill(datos, "Funcionarios");
                //Agregar con lista

               
                 
            }
            catch (Exception)
            {

                throw;
            }

            return datos;//Devuelve el dataSet
        }//Fin DataSet


        public List<EntidadFuncionarios> ListarFuncionariosL(string condicion = "")
        {
            DataSet datos = new DataSet(); //En datos se guardarán los resultados del Select

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            List<EntidadFuncionarios> funcionarios;
            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();

            string consultaFuncionarios = "Select IdFuncionario, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado, IdPuestoTrabajo from Funcionarios where Estado=1";

            //Si el parámetro condición no está vacío lo concatena a la consultaFuncioanrios
            if (!string.IsNullOrEmpty(condicion))
            {
                consultaFuncionarios = string.Format("{0} where {1}", consultaFuncionarios, condicion);
            }

            
            try
            {
                adapter = new SqlDataAdapter(consultaFuncionarios, conexion);
                //El adapter.Fill llena "adapter" con los datos que tiene el dataSet "datos" y le asigna el nombre "Clientes"

                adapter.Fill(datos, "Funcionarios");
                //Agregar con lista
             
                funcionarios = (from DataRow fila in datos.Tables["Funcionarios"].Rows
                                select new EntidadFuncionarios()
                                {
                                    IdFuncionario = (int)fila[0],
                                    Nombre = fila[1].ToString(),
                                    PrimerApellido = fila[2].ToString(),
                                    SegundoApellido = fila[3].ToString(),
                                    Cedula = fila[4].ToString(),
                                    FechaNacimiento = fila[5].ToString(),
                                    Genero = fila[6].ToString(),
                                    Telefono = fila[7].ToString(),
                                    Correo = fila[8].ToString(),
                                    FechaCreacion = fila[9].ToString(),
                                    Estado = (bool)fila[10],
                                    objPuestoTrabajo = new EntidadPuestoTrabajo { IdPuestoTrabajo=(int)fila[11]}
                                }).ToList();

            }
            catch (Exception)
            {

                throw;
            }

            return funcionarios;//Devuelve el dataSet
        }//Fin DataSet


        public bool EditarFuncionario(EntidadFuncionarios funcionario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEditarFuncionario", conexion);
                comando.Parameters.AddWithValue("IdFuncionario", funcionario.IdFuncionario);
                comando.Parameters.AddWithValue("Nombre", funcionario.Nombre);
                comando.Parameters.AddWithValue("PrimerApellido", funcionario.PrimerApellido);
                comando.Parameters.AddWithValue("SegundoApellido", funcionario.SegundoApellido);
                comando.Parameters.AddWithValue("Cedula", funcionario.Cedula);
                comando.Parameters.AddWithValue("FechaNacimiento", DateTime.Parse(funcionario.FechaNacimiento));
                comando.Parameters.AddWithValue("Genero", funcionario.Genero);
                comando.Parameters.AddWithValue("Telefono", funcionario.Telefono);
                comando.Parameters.AddWithValue("Correo", funcionario.Correo);
                //comando.Parameters.AddWithValue("FechaCreacion", funcionario.FechaCreacion);
                comando.Parameters.AddWithValue("Estado", funcionario.Estado);
                comando.Parameters.AddWithValue("IdPuestoTrabajo", funcionario.objPuestoTrabajo.IdPuestoTrabajo);
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


        public bool EliminarFuncionario(EntidadFuncionarios funcionario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEliminarFuncionario", conexion);
                comando.Parameters.AddWithValue("IdFuncionario", funcionario.IdFuncionario);
                comando.Parameters.AddWithValue("Estado", funcionario.Estado);

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
        }//Fin EliminarFuncionario



    }//Fin AccesoDatosFuncionario
}//Fin Capa03 Acceso Datos