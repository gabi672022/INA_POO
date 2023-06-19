using System;
using System.Collections.Generic;
using System.Text;
using Capa04Entidades;
using System.Data.SqlClient;
using System.Data;


namespace Capa03AccesoDatos
{
    public class DACliente
    {
        private string _cadenaConexion;
        private string _mensaje;

       

        //Propiedades
        //public string Mensaje { get => _mensaje; }

        //Constructor
        public DACliente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int Insertar(Clientes cliente)
        {
            int id = 0;

            //Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);

string sentencia = " INSERT INTO CLIENTES(NOMBRE, TELEFONO, DIRECCION) VALUES (@NOMBRE, @TELEFONO, @DIRECCION) SELECT @@IDENTITY";


            //Establecer los camandos SQL
            SqlCommand comando = new SqlCommand(sentencia, cnx);
  
            comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
            comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);

            comando.CommandType = CommandType.Text;

            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Dispose();
                comando.Dispose();
            }

            return id;

        }//Fin Insertar

        //Devuelve un DataSet con datos de clientes, para ser mostrados en el DataGridView
        public DataSet ListarClientes(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet(); //En "datos" se guardarán los resultados del Select
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            string sentencia = "SELECT ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION FROM CLIENTES";

            //Si el parámetro condición no está vacío lo concatena a la sentencia
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            //Si el parámetro orden no está vacío lo concatena a la sentencia
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} order by {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                //El adapter.Fill llena "adapter" con los datos que tiene el DataSet "datos" y le asigna el nombre "Clientes"
                adapter.Fill(datos, "Clientes");
            }
            catch (Exception)
            {

                throw;
            }
            return datos; //devuelve el dataset

        }//Fin de ListarClientes


    }
}
