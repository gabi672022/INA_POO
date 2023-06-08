using System;
using System.Collections.Generic;
using System.Text;

namespace Capa02Logica
{
    class BLCliente
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        //Constructor
        public BLCliente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Método para llamar al método Insertar de la capaAccesoDatos
        public int Insertar(EntidadCliente cliente)
        {
            int id_cliente = 0;
            DACliente accesoDatos = new DACliente(_cadenaConexion);
            try
            {
                id_cliente = accesoDatos.Insertar(cliente);
            }
            catch (Exception)
            {

                throw;
            }
            return id_cliente;
        }//Fin de la clase insertar

        //
        public DataSet ListarClientes(string condicion = "", string orden = "")
        {
            DataSet DS;
            DACliente accesoDatos = new DACliente(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarClientes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }//Fin Listar Clientes
    }
}
