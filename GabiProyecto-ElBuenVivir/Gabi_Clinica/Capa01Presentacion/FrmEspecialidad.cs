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
    public partial class FrmEspecialidad : Form
    {
        public FrmEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmEspecialidad_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public EntidadEspecialidades GenerarEntidadPuestoTrabajo()
        {
            EntidadEspecialidades objEspecialidades = new EntidadEspecialidades();
            objEspecialidades.NombreEsp = txtNombre.Text;
            objEspecialidades.RequisitosAcademicos = txtRequisitos.Text;

            return objEspecialidades;
        }

        private void Limpiar()
        {
            txtIdEspecialidad.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRequisitos.Text = string.Empty;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EntidadEspecialidades objEspecialidades = new EntidadEspecialidades();
            LogicaEspecialidades logicaEspecialidad = new LogicaEspecialidades(Configuracion.getCadenaConexion);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtRequisitos.Text))
                {
                    MessageBox.Show("No se permiten espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objEspecialidades = GenerarEntidadPuestoTrabajo();
                    resultado = logicaEspecialidad.InsertarEspecialidad(objEspecialidades);
                    Limpiar();
                    MessageBox.Show("Espacialidad insertada correctamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//FinbtnInsertar_Click

        public void CargarListaGrid(string condicion = "")
        {
            LogicaEspecialidades logicaEspecialidad = new LogicaEspecialidades(Configuracion.getCadenaConexion);

            List<EntidadEspecialidades> listaEspecialidades;

            listaEspecialidades = logicaEspecialidad.listaEspecialidades();

            foreach (EntidadEspecialidades item in listaEspecialidades)
            {
                dgvEspecialidad.Rows.Add(new object[] { "", item.IdEspecialidad, item.NombreEsp, item.RequisitosAcademicos });

            }
        }//FinCargarListaGrid

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEspecialidad.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvEspecialidad.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombre.Text = dgvEspecialidad.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtRequisitos.Text = dgvEspecialidad.Rows[indice].Cells["Requisitos"].Value.ToString();
                }
            }
        }//FindgvEspecialidad_CellContentClick

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LogicaEspecialidades logicaEspecialidad = new LogicaEspecialidades(Configuracion.getCadenaConexion);
            EntidadEspecialidades especialidades = GenerarEntidadPuestoTrabajo();

            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtRequisitos.Text))
                {
                    MessageBox.Show("Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    especialidades = GenerarEntidadPuestoTrabajo();
                    especialidades.IdEspecialidad = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool resultado = logicaEspecialidad.EditarEspecialidades(especialidades, out Mensaje);

                    if (resultado)
                    {

                        DataGridViewRow fila = dgvEspecialidad.Rows[Convert.ToInt32(btnSeleccionar.Text)];
                        fila.Cells["Codigo"].Value = txtIdSeleccionado.Text;
                        fila.Cells["Nombre"].Value = txtNombre.Text;
                        fila.Cells["Requisitos"].Value = txtRequisitos.Text;

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }


                    MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//FinbtnEditar_Click


    }//FinFrmEspecialidad
}
