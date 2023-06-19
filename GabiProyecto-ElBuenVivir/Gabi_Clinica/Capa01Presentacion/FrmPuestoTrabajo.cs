using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa04Entidades;
using Capa02Logica;


namespace Capa01Presentacion
{
    public partial class FrmPuestoTrabajo : Form
    {
        public FrmPuestoTrabajo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public EntidadPuestoTrabajo GenerarEntidadPuestoTrabajo()
        {
            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();
            objPuestoTrabajo.Nombre = txtNombre.Text;

            return objPuestoTrabajo;
        }
       

        private void Limpiar()
        {
            txtIdPuestoTrabajo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EntidadPuestoTrabajo objPuestoTrabajo = new EntidadPuestoTrabajo();
            LogicaPuestoTrabajo logicaPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("No se permiten espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objPuestoTrabajo = GenerarEntidadPuestoTrabajo();
                    resultado = logicaPuestoTrabajo.InsertarPuestoTrabajo(objPuestoTrabajo);
                    Limpiar();
                    MessageBox.Show("Puesto de trabajo insertado correctamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
