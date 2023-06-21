using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Capa04Entidades;

namespace Capa03AccesoDatos
{
    public class AccesoDatosEspecialistas
    {
        private string _cadenaConexion;


        //Constructor
        public AccesoDatosEspecialistas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public List<EntidadEspecialistas> listaEspecialistas()
        {
            List<EntidadEspecialistas> especialistas = new List<EntidadEspecialistas>();
            List<EntidadFuncionariosEspecialidades> funcionariosEspecialidades = new List<EntidadFuncionariosEspecialidades>();

            SqlConnection cnx = new SqlConnection(_cadenaConexion);

            string consultaListaEspecialistas = "select f.Nombre, f.PrimerApellido, f.SegundoApellido, e.NombreEsp"+
                "from Funcionarios f"+
                "inner join FuncionariosEspecialidades f1 on f.IdFuncionario = f1.IdFuncionario"+
                "inner join Especialidades e on f1.IdEspecialidad = e.IdEspecialidad"+
                "inner join Especialistas e2 on f1.IdEspecialidad = e2.IdEspecialidad"+
                "inner join PuestoTrabajo p on p.IdPuestoTrabajo = f.IdPuestoTrabajo"+
                "where p.Nombre = 'Médico'and NombreEsp = 'Medicina General' ";

            SqlCommand comando = new SqlCommand(consultaListaEspecialistas, cnx);

            try
            {
                cnx.Open();
                SqlDataReader lectura = comando.ExecuteReader();
                while (lectura.Read())
                {
                    EntidadFuncionarios objFuncionarios = new EntidadFuncionarios
                    {
                        Nombre = lectura["Nombre"].ToString(),
                        PrimerApellido = lectura["PrimerApellido"].ToString(),
                        SegundoApellido = lectura["SegundoApellido"].ToString()
                    };

                    EntidadEspecialidades objEspecialidades = new EntidadEspecialidades
                    {
                        NombreEsp = lectura["NombreEsp"].ToString()
                    };

                    EntidadEspecialistas objEntidadEspecialistas = new EntidadEspecialistas
                    {
                        objFuncionario = objFuncionarios,
                        objEspecialidades = objEspecialidades
                    };

                    especialistas.Add(objEntidadEspecialistas);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener los puestos de trabajo desde la base de datos: " + ex.Message);
            }


            return especialistas;

        }//listaEspecialista

    }//Fin AccesoDatosEspecialistas
}
