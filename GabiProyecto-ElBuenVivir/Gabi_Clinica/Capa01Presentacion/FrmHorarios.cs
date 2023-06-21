using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa04Entidades;
using Capa02Logica;

namespace Capa01Presentacion
{
    public partial class FrmHorarios : Form
    {
        public FrmHorarios()
        {
            InitializeComponent();
            CargarEspecialidades();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {

        }//FinFrmHorarios_Load

        private void CargarEspecialidades()
        {
            LogicaEspecialidades logicaEspecialidades = new LogicaEspecialidades(Configuracion.getCadenaConexion);
            List<EntidadEspecialidades> objListaEspecialidades = logicaEspecialidades.listaEspecialidades();
            cbbEspecialidades.DataSource = objListaEspecialidades;
            cbbEspecialidades.DisplayMember = "NombreEsp";
            cbbEspecialidades.ValueMember = "IdEspecialidad";


        }//FinCargarEspecialidades

        public void CargarListaGrid(string condicion = "")
        {
            //LogicaEspecialistas logEspecialista = new LogicaEspecialistas(Configuracion.getCadenaConexion);

            //List<EntidadEspecialistas> listaEspecialistas;

            //listaEspecialistas = logEspecialista.listaEspecialistas();

            //foreach (EntidadEspecialistas item in listaEspecialistas)
            //{
            //    //dgvEspecialistas.Rows.Add(new object[] { "", item.objEspecialidades.NombreEsp, item., item.PrimerApellido, item.SegundoApellido, item.Cedula, item.FechaNacimiento, item.Genero, item.Telefono, item.Correo, item.objPuestoTrabajo.IdPuestoTrabajo });

            //}
        }//FinCargarListaGrid


    }
}
