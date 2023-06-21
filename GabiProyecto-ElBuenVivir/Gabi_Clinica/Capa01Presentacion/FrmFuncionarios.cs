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
    public partial class FrmFuncionarios : Form
    {
        EntidadFuncionarios funcionarioRegistrado;
        //LogicaPuestoTrabajo listaObjPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);
        public FrmFuncionarios()
        {
            InitializeComponent();
            txtNombre.Focus();
            CargarPuestosTrabajo();
        }

        private EntidadFuncionarios generarEntidadFuncionario()
        {
            EntidadPuestoTrabajo puestoTrabajo = new EntidadPuestoTrabajo();
            EntidadFuncionarios funcionario = new EntidadFuncionarios();

            funcionario.Nombre = txtNombre.Text;
            funcionario.PrimerApellido = txtPrimerApe.Text;
            funcionario.SegundoApellido = txtSegundoApe.Text;
            funcionario.FechaNacimiento = txtFechaNacimiento.Text;
            funcionario.Cedula = txtCedula.Text;
            funcionario.Genero = txtGenero.Text;
            funcionario.Correo = txtCorreo.Text;
            funcionario.Telefono = txtTelefono.Text;
            EntidadPuestoTrabajo puestoTrabajoSeleccionado = cbbPuestoTrabajo.SelectedItem as EntidadPuestoTrabajo;
            if (puestoTrabajoSeleccionado != null)
            {
                funcionario.objPuestoTrabajo = new EntidadPuestoTrabajo();
                funcionario.objPuestoTrabajo.Nombre = puestoTrabajoSeleccionado.Nombre;
                funcionario.objPuestoTrabajo.IdPuestoTrabajo = puestoTrabajoSeleccionado.IdPuestoTrabajo;
            }

            return funcionario;
        }


        private void Limpiar()
        {
            txtIdFuncionario.Text = string.Empty;
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
            EntidadFuncionarios funcionario = generarEntidadFuncionario();
            LogicaFuncionarios logicaFunionario = new LogicaFuncionarios(Configuracion.getCadenaConexion);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPrimerApe.Text) | string.IsNullOrEmpty(txtSegundoApe.Text) | string.IsNullOrEmpty(txtFechaNacimiento.Text) | string.IsNullOrEmpty(txtCedula.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtCorreo.Text) | string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    funcionario = generarEntidadFuncionario();
                    resultado = logicaFunionario.Insertar(funcionario);
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
            LogicaFuncionarios logFuncionario = new LogicaFuncionarios(Configuracion.getCadenaConexion);

            List<EntidadFuncionarios> listaFuncionarios;

            listaFuncionarios = logFuncionario.ListarFuncionariosLista();

            foreach (EntidadFuncionarios item in listaFuncionarios)
            {
                dgvFuncionarios.Rows.Add(new object[] { "", item.IdFuncionario, item.Nombre, item.PrimerApellido, item.SegundoApellido, item.Cedula, item.FechaNacimiento, item.Genero, item.Telefono, item.Correo, item.objPuestoTrabajo.IdPuestoTrabajo });

            }
        }


        //********************************************


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarPuestosTrabajo()
        {
            LogicaPuestoTrabajo LogicaPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);
            List<EntidadPuestoTrabajo> puestoTrabajos = LogicaPuestoTrabajo.listaPuestoTrabajo();
            cbbPuestoTrabajo.DataSource = puestoTrabajos;
            cbbPuestoTrabajo.DisplayMember = "Nombre";
            cbbPuestoTrabajo.ValueMember = "IdPuestoTrabajo";
        }//FinCargarPuestosTrabajo


        private void cbbPuestoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
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

         
        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogicaPuestoTrabajo LogicaPuestoTrabajo = new LogicaPuestoTrabajo(Configuracion.getCadenaConexion);
            List<EntidadPuestoTrabajo> puestoTrabajos = LogicaPuestoTrabajo.listaPuestoTrabajo();


            if (dgvFuncionarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvFuncionarios.Rows[indice].Cells["IdFuncionario"].Value.ToString();
                    txtNombre.Text = dgvFuncionarios.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtPrimerApe.Text = dgvFuncionarios.Rows[indice].Cells["PrimerApellido"].Value.ToString();
                    txtSegundoApe.Text = dgvFuncionarios.Rows[indice].Cells["SegundoApellido"].Value.ToString();
                    txtCedula.Text = dgvFuncionarios.Rows[indice].Cells["Cedula"].Value.ToString();
                    txtFechaNacimiento.Text = dgvFuncionarios.Rows[indice].Cells["FechaNacimiento"].Value.ToString();
                    txtGenero.Text = dgvFuncionarios.Rows[indice].Cells["Genero"].Value.ToString();
                    txtTelefono.Text = dgvFuncionarios.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvFuncionarios.Rows[indice].Cells["Correo"].Value.ToString();
                    //cbbPuestoTrabajo.Text= dgvFuncionarios.Rows[indice].Cells["PuestoTrabajo"].Value.ToString();

                    int idPuestoTrabajo = (int)dgvFuncionarios.Rows[indice].Cells["PuestoTrabajo"].Value;
                    string nombrePuestoTrabajo = puestoTrabajos.FirstOrDefault(x => x.IdPuestoTrabajo == idPuestoTrabajo)?.Nombre;
                    cbbPuestoTrabajo.Text = nombrePuestoTrabajo;
                }
            }

        }//Fin dgvFuncionarios_CellContentClick

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LogicaFuncionarios logicaFunionario = new LogicaFuncionarios(Configuracion.getCadenaConexion);
            EntidadFuncionarios funcionario = generarEntidadFuncionario();

            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtPrimerApe.Text) | string.IsNullOrEmpty(txtSegundoApe.Text) | string.IsNullOrEmpty(txtFechaNacimiento.Text) | string.IsNullOrEmpty(txtCedula.Text) | string.IsNullOrEmpty(txtGenero.Text) | string.IsNullOrEmpty(txtCorreo.Text) | string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    funcionario = generarEntidadFuncionario();
                    funcionario.IdFuncionario = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool resultado = logicaFunionario.EditarFuncionario(funcionario, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow fila = dgvFuncionarios.Rows[Convert.ToInt32(btnSeleccionar.Text)];
                        fila.Cells["IdFuncionario"].Value = txtIdSeleccionado.Text;
                        fila.Cells["Nombre"].Value = txtNombre.Text;
                        fila.Cells["PrimerApellido"].Value = txtPrimerApe.Text;
                        fila.Cells["SegundoApellido"].Value = txtSegundoApe.Text;
                        fila.Cells["Cedula"].Value = txtCedula.Text;
                        fila.Cells["FechaNacimiento"].Value = txtFechaNacimiento.Text;
                        fila.Cells["Genero"].Value = txtGenero.Text;
                        fila.Cells["Telefono"].Value = txtTelefono.Text;
                        fila.Cells["Correo"].Value = txtCorreo.Text;

                        fila.Cells["PuestoTrabajo"].Value = cbbPuestoTrabajo.SelectedItem;


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
            LogicaFuncionarios logicaFunionario = new LogicaFuncionarios(Configuracion.getCadenaConexion);
            EntidadFuncionarios funcionario = generarEntidadFuncionario();


            string Mensaje = string.Empty;
            if (Convert.ToInt32(txtIdSeleccionado.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar este funcionario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcionario.IdFuncionario = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool respuesta = logicaFunionario.EliminarFuncionario(funcionario, out Mensaje);
                   
                }
            }

        }//FinbtnEliminar_Click



    }
}//Fin FrmFuncionarios

