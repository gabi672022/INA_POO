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
    public class AccesoDatosPaciente
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosPaciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para insertar Paciente
        public int Insertar(EntidadPacientes paciente)
        {
            int id = 0;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            string consultaInsertar = "Insert into Pacientes(Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado) Values (@Nombre, @PrimerApellido, @SegundoApellido, @Cedula, @FechaNacimiento, @Genero, @Telefono, @Correo, @FechaCreacion, @Estado) Select @@Identity";

            SqlCommand comando = new SqlCommand(consultaInsertar, conexion);

           

            comando.Parameters.AddWithValue("@Nombre", paciente.Nombre.ToUpper());
            comando.Parameters.AddWithValue("@PrimerApellido", paciente.PrimerApellido.ToUpper());
            comando.Parameters.AddWithValue("@SegundoApellido", paciente.SegundoApellido.ToUpper());
            comando.Parameters.AddWithValue("@Cedula", paciente.Cedula);
            comando.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(paciente.FechaNacimiento));
            comando.Parameters.AddWithValue("@Genero", paciente.Genero.ToUpper());
            comando.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            comando.Parameters.AddWithValue("@Correo", paciente.Correo.ToUpper());
            comando.Parameters.AddWithValue("@FechaCreacion", paciente.FechaCreacion);
            comando.Parameters.AddWithValue("@Estado", paciente.Estado);


            

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
        public DataSet ListarPacientes(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet(); //En datos se guardarán los resultados del Select

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            List<EntidadPacientes> pacientes;
            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();

            string consultaPaciente = "Select IdPaciente, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado,  from Paciente";

            //Si el parámetro condición no está vacío lo concatena a la consultaFuncioanrios
            if (!string.IsNullOrEmpty(condicion))
            {
                consultaPaciente = string.Format("{0} where {1}", consultaPaciente, condicion);
            }

            //Si el parámetro orden no está vacío lo concatena a la sentencia
            if (!string.IsNullOrEmpty(orden))
            {
                consultaPaciente = string.Format("{0} order by {1}", consultaPaciente, orden);
            }

            try
            {
                adapter = new SqlDataAdapter(consultaPaciente, conexion);
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


        public List<EntidadPacientes> ListarPacientesL(string condicion = "")
        {
            DataSet datos = new DataSet(); //En datos se guardarán los resultados del Select

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            List<EntidadPacientes> pacientes;
            

            string consultaPaciente = "Select IdPaciente, Nombre, PrimerApellido, SegundoApellido, Cedula, FechaNacimiento, Genero, Telefono, Correo, FechaCreacion, Estado from Funcionarios where Estado=1";

            //Si el parámetro condición no está vacío lo concatena a la consultaFuncioanrios
            if (!string.IsNullOrEmpty(condicion))
            {
                consultaPaciente = string.Format("{0} where {1}", consultaPaciente, condicion);
            }


            try
            {
                adapter = new SqlDataAdapter(consultaPaciente, conexion);
                //El adapter.Fill llena "adapter" con los datos que tiene el dataSet "datos" y le asigna el nombre "Clientes"

                adapter.Fill(datos, "Pacientes");
                //Agregar con lista

                pacientes = (from DataRow fila in datos.Tables["Pacientes"].Rows
                                select new EntidadPacientes()
                                {
                                    IdPaciente = (int)fila[0],
                                    Nombre = fila[1].ToString(),
                                    PrimerApellido = fila[2].ToString(),
                                    SegundoApellido = fila[3].ToString(),
                                    Cedula = fila[4].ToString(),
                                    FechaNacimiento = fila[5].ToString(),
                                    Genero = fila[6].ToString(),
                                    Telefono = fila[7].ToString(),
                                    Correo = fila[8].ToString(),
                                    FechaCreacion = fila[9].ToString(),
                                    Estado = (bool)fila[10]
                                }).ToList();

            }
            catch (Exception)
            {

                throw;
            }

            return pacientes;//Devuelve el dataSet
        }//Fin DataSet


        public bool EditarPaciente(EntidadPacientes paciente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEditarFuncionario", conexion);
                comando.Parameters.AddWithValue("IdFuncionario", paciente.IdPaciente);
                comando.Parameters.AddWithValue("Nombre", paciente.Nombre);
                comando.Parameters.AddWithValue("PrimerApellido", paciente.PrimerApellido);
                comando.Parameters.AddWithValue("SegundoApellido", paciente.SegundoApellido);
                comando.Parameters.AddWithValue("Cedula", paciente.Cedula);
                comando.Parameters.AddWithValue("FechaNacimiento", DateTime.Parse(paciente.FechaNacimiento));
                comando.Parameters.AddWithValue("Genero", paciente.Genero);
                comando.Parameters.AddWithValue("Telefono", paciente.Telefono);
                comando.Parameters.AddWithValue("Correo", paciente.Correo);
               
                comando.Parameters.AddWithValue("Estado", paciente.Estado);
                
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


        public bool EliminarPaciente(EntidadPacientes paciente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                SqlConnection conexion = new SqlConnection(_cadenaConexion);

                SqlCommand comando = new SqlCommand("spEliminarFuncionario", conexion);
                comando.Parameters.AddWithValue("IdFuncionario", paciente.IdPaciente);
                comando.Parameters.AddWithValue("Estado", paciente.Estado);

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




    }//Fin AccesoDatosPaciente
}
