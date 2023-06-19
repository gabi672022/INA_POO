using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaFuncionarios
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public LogicaFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para llamar al método Insertar de la capa AccesoDatos
        public int Insertar (EntidadFuncionarios funcionario)
        {
            int id = 0;

            AccesoDatosFuncionario accesoDatos = new AccesoDatosFuncionario(_cadenaConexion);
            try
            {
                id = accesoDatos.Insertar(funcionario);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return id;
        }//Fin Insertar

        public DataSet ListarFuncionarios(string condicion = "", string orden = "")
        {
            DataSet dsFuncionarios;
            AccesoDatosFuncionario accesoDatosFuncionario = new AccesoDatosFuncionario(_cadenaConexion);

            try
            {
                dsFuncionarios = accesoDatosFuncionario.ListarFuncionarios(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return dsFuncionarios;

        }//FinDataSet ListarFuncionarios


        public List<EntidadFuncionarios> ListarFuncionariosLista(string condicion = "")
        {
            List<EntidadFuncionarios> ListaFuncionariosL;
            AccesoDatosFuncionario  AccesoDatosFuncionarioL = new AccesoDatosFuncionario(_cadenaConexion);

            try
            {
                ListaFuncionariosL = AccesoDatosFuncionarioL.ListarFuncionariosL(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return ListaFuncionariosL;
        }//ListarFuncionariosLista

        public bool EditarFuncionario(EntidadFuncionarios funcionario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosFuncionario accesoDatos = new AccesoDatosFuncionario(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EditarFuncionario(funcionario, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin Insertar

        public bool EliminarFuncionario(EntidadFuncionarios funcionario, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosFuncionario accesoDatos = new AccesoDatosFuncionario(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EliminarFuncionario(funcionario, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin Insertar


    }//Fin LogicaFuncionarios
}
