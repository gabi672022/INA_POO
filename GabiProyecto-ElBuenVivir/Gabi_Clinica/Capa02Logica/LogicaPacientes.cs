using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Capa03AccesoDatos;
using Capa04Entidades;

namespace Capa02Logica
{
    public class LogicaPacientes
    {
        //Atributos
        private string _cadenaConexion;


        //Constructor
        public LogicaPacientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Método para llamar al método Insertar de la capa AccesoDatos
        public int Insertar(EntidadPacientes paciente)
        {
            int id = 0;

            AccesoDatosPaciente accesoDatos = new AccesoDatosPaciente(_cadenaConexion);
            try
            {
                id = accesoDatos.Insertar(paciente);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return id;
        }//Fin Insertar

        public DataSet ListarPacientes(string condicion = "", string orden = "")
        {
            DataSet dsPacientes;
            AccesoDatosPaciente accesoDatosPaciente = new AccesoDatosPaciente(_cadenaConexion);

            try
            {
                dsPacientes = accesoDatosPaciente.ListarPacientes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return dsPacientes;

        }//FinDataSet ListarPacientes


        public List<EntidadPacientes> ListarPacientesLista(string condicion = "")
        {
            List<EntidadPacientes> ListaPacientesL;
            AccesoDatosPaciente AccesoDatosPacienteL = new AccesoDatosPaciente(_cadenaConexion);

            try
            {
                ListaPacientesL = AccesoDatosPacienteL.ListarPacientesL(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return ListaPacientesL;
        }//ListarFuncionariosLista

        public bool EditarListaPaciente(EntidadPacientes paciente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosPaciente accesoDatos = new AccesoDatosPaciente(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EditarPaciente(paciente, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin Insertar

        public bool EliminarPaciente(EntidadPacientes paciente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            AccesoDatosPaciente accesoDatos = new AccesoDatosPaciente(_cadenaConexion);
            try
            {
                respuesta = accesoDatos.EliminarPaciente(paciente, out Mensaje);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return respuesta;
        }//Fin Insertar



    }//FinLogica Pacientes
}
