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
    public partial class FrmPacientes : Form
    {
        EntidadPacientes pacienteRegistrado;
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private EntidadPacientes generarEntidadPaciente()
        {

            EntidadPacientes paciente = new EntidadPacientes();

            paciente.Nombre = txtNombre.Text;
            paciente.PrimerApellido = txtPrimerApe.Text;
            paciente.SegundoApellido = txtSegundoApe.Text;
            paciente.FechaNacimiento = txtFechaNacimiento.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Genero = txtGenero.Text;
            paciente.Correo = txtCorreo.Text;
            paciente.Telefono = txtTelefono.Text;
            return paciente;
        }


        private void Limpiar()
        {
            txtIdPaciente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrimerApe.Text = string.Empty;
            txtSegundoApe.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtNombre.Focus();

        }

        //********************************************
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EntidadPacientes paciente = generarEntidadPaciente();
            LogicaPacientes logicaPaciente = new LogicaPacientes(Configuracion.getCadenaConexion);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPrimerApe.Text) | string.IsNullOrEmpty(txtSegundoApe.Text) | string.IsNullOrEmpty(txtFechaNacimiento.Text) | string.IsNullOrEmpty(txtCedula.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtCorreo.Text) | string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paciente = generarEntidadPaciente();
                    resultado = logicaPaciente.Insertar(paciente);
                    Limpiar();
                    MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//Fin btnInsertar

        //********************************************
        public void CargarListaGrid(string condicion = "")
        {
            LogicaPacientes logPaciente = new LogicaPacientes(Configuracion.getCadenaConexion);

            List<EntidadPacientes> listaPacientes;

            listaPacientes = logPaciente.ListarPacientesLista();

            foreach (EntidadPacientes item in listaPacientes)
            {
                dgvPacientes.Rows.Add(new object[] { "", item.IdPaciente, item.Nombre, item.PrimerApellido, item.SegundoApellido, item.Cedula, item.FechaNacimiento, item.Genero, item.Telefono, item.Correo });

            }
        }//FinCargarListaGrid


        //********************************************


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
       


        private void cbbPuestoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin FrmFuncionarios_Load






        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Evento que permite selecionar el contenido de una fila del datagridview

            if (dgvPacientes.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvPacientes.Rows[indice].Cells["IdPaciente"].Value.ToString();
                    txtNombre.Text = dgvPacientes.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtPrimerApe.Text = dgvPacientes.Rows[indice].Cells["PrimerApellido"].Value.ToString();
                    txtSegundoApe.Text = dgvPacientes.Rows[indice].Cells["SegundoApellido"].Value.ToString();
                    txtCedula.Text = dgvPacientes.Rows[indice].Cells["Cedula"].Value.ToString();
                    txtFechaNacimiento.Text = dgvPacientes.Rows[indice].Cells["FechaNacimiento"].Value.ToString();
                    txtGenero.Text = dgvPacientes.Rows[indice].Cells["Genero"].Value.ToString();
                    txtTelefono.Text = dgvPacientes.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvPacientes.Rows[indice].Cells["Correo"].Value.ToString();
                }
            }

        }//Fin dgvFuncionarios_CellContentClick

        //**********************************

        //**********************************


        private void btnEditar_Click(object sender, EventArgs e)
        {
            LogicaPacientes logicaPaciente = new LogicaPacientes(Configuracion.getCadenaConexion);
            EntidadPacientes paciente = generarEntidadPaciente();

            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPrimerApe.Text) | string.IsNullOrEmpty(txtSegundoApe.Text) | string.IsNullOrEmpty(txtFechaNacimiento.Text) | string.IsNullOrEmpty(txtCedula.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtCorreo.Text) | string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paciente = generarEntidadPaciente();
                    paciente.IdPaciente = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool resultado = logicaPaciente.EditarListaPaciente(paciente, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow fila = dgvPacientes.Rows[Convert.ToInt32(btnSeleccionar.Text)];
                        fila.Cells["IdPaciente"].Value = txtIdSeleccionado.Text;
                        fila.Cells["Nombre"].Value = txtNombre.Text;
                        fila.Cells["PrimerApellido"].Value = txtPrimerApe.Text;
                        fila.Cells["SegundoApellido"].Value = txtSegundoApe.Text;
                        fila.Cells["Cedula"].Value = txtCedula.Text;
                        fila.Cells["FechaNacimiento"].Value = txtFechaNacimiento.Text;
                        fila.Cells["Genero"].Value = txtGenero.Text;
                        fila.Cells["Telefono"].Value = txtTelefono.Text;
                        fila.Cells["Correo"].Value = txtCorreo.Text;


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

        }//Fin btnEditar_Click





        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LogicaPacientes logicaPaciente = new LogicaPacientes(Configuracion.getCadenaConexion);
            EntidadPacientes paciente = generarEntidadPaciente();


            string Mensaje = string.Empty;
            if (Convert.ToInt32(txtIdSeleccionado.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este funcionario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    paciente.IdPaciente = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool respuesta = logicaPaciente.EliminarPaciente(paciente, out Mensaje);
                }
            }

        }//btn btnEliminar_Click



        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        //private void FrmPacientes_Load(object sender, EventArgs e)
        //{

        //}



    }//FinFrmPacientes : Form 
}
