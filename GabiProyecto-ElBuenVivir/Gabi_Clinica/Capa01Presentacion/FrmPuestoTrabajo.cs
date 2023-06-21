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

        }//btnInsertar_Click


        public void CargarListaGrid(string condicion = "")
        {
            LogicaPuestoTrabajo logicaPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);

            List<EntidadPuestoTrabajo> listaPuestosTrabajo;

            listaPuestosTrabajo = logicaPuestoTrabajo.listaPuestoTrabajo();

            foreach (EntidadPuestoTrabajo item in listaPuestosTrabajo)
            {
                dgvPuestoTrabajo.Rows.Add(new object[] { "", item.IdPuestoTrabajo, item.Nombre});

            }
        }//FinCargarListaGrid

        private void FrmPuestoTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//FinFrmPuestoTrabajo_Load

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Evento que permite selecionar el contenido de una fila del datagridview


            if (dgvPuestoTrabajo.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvPuestoTrabajo.Rows[indice].Cells["IdPuestoTrabajo"].Value.ToString();
                    txtNombre.Text = dgvPuestoTrabajo.Rows[indice].Cells["Nombre"].Value.ToString();                   
                }
            }

        }//Fin dgvFuncionarios_CellContentClick

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LogicaPuestoTrabajo logicaPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);
            EntidadPuestoTrabajo puestoTrabajo = GenerarEntidadPuestoTrabajo();

            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    puestoTrabajo = GenerarEntidadPuestoTrabajo();
                    puestoTrabajo.IdPuestoTrabajo = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool resultado = logicaPuestoTrabajo.EditarPuestoTrabajo(puestoTrabajo, out Mensaje);

                    if (resultado)
                    {
                       
                        DataGridViewRow fila = dgvPuestoTrabajo.Rows[Convert.ToInt32(btnSeleccionar.Text)];
                        fila.Cells["IdPuestoTrabajo"].Value = txtIdSeleccionado.Text;
                        fila.Cells["Nombre"].Value = txtNombre.Text;
                        
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
        }//btnEditar_Click

        private void dgvPuestoTrabajo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPuestoTrabajo.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvPuestoTrabajo.Rows[indice].Cells["IdPuestoTrabajo"].Value.ToString();
                    txtNombre.Text = dgvPuestoTrabajo.Rows[indice].Cells["Nombre"].Value.ToString();                  
                }
            }
        }
    }//FinFrmPuestoTrabajo
}//NameSpace
