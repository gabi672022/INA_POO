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
    public partial class FrmControlAcceso : Form
    {
        public FrmControlAcceso()
        {
            InitializeComponent();
            CargarFuncionarios();
            

        }//Fin FrmControlAcceso

        private void FrmControlAcceso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin FrmControlAcceso_Load

        private EntidadAccesoSistema generarEntidadAccesoSistema()
        {
           
            EntidadAccesoSistema accesoSistema = new EntidadAccesoSistema();
            EntidadFuncionarios funcionario = new EntidadFuncionarios();

            accesoSistema.Clave = txtClave.Text;

            //if (cbbNivelAcceso.SelectedItem != null)
            //{
            //    if (int.TryParse(cbbNivelAcceso.SelectedItem.ToString(), out int nivelAcceso))
            //    {
            //        accesoSistema.NivelAcceso = nivelAcceso;
            //    }
            //    else
            //    {
            //        accesoSistema.NivelAcceso = 0;
            //    }


            //}
            cbbNivelAcceso.Items.Clear();
            for (int i = 1; i < 3; i++)
            {
                cbbNivelAcceso.Items.Add(i.ToString());
            }

            EntidadFuncionarios funcionarioSeleccionado = cbbFuncionario.SelectedItem as EntidadFuncionarios;

            if (funcionarioSeleccionado!= null)
            {
                accesoSistema.objFuncionario = new EntidadFuncionarios();
                accesoSistema.objFuncionario.IdFuncionario = funcionarioSeleccionado.IdFuncionario;
                accesoSistema.objFuncionario.Cedula = funcionarioSeleccionado.Cedula;

            }

            return accesoSistema;

        }//generarEntidadAccesoSistema

        private void Limpiar()
        {
            txtIdAccesoSistema.Text = string.Empty;
            cbbFuncionario.Text = string.Empty;
            txtClave.Text = string.Empty;
            cbbNivelAcceso.Text = string.Empty;
        }//Limpiar

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EntidadAccesoSistema accesoSistema = generarEntidadAccesoSistema();
            LogicaControlAcceso controlAcceso = new LogicaControlAcceso(Configuracion.getCadenaConexion);

            int resultado;

            try
            {
                if (string.IsNullOrEmpty(cbbFuncionario.Text) | string.IsNullOrEmpty(txtClave.Text) | string.IsNullOrEmpty(cbbNivelAcceso.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    accesoSistema = generarEntidadAccesoSistema();
                    resultado = controlAcceso.InsertarAccesoSistema (accesoSistema);
                    Limpiar();
                    MessageBox.Show("Operación realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }//FinbtnInsertar_Click


        public void CargarListaGrid(string condicion = "")
        {
            LogicaControlAcceso logicaControlAcceso = new LogicaControlAcceso(Configuracion.getCadenaConexion);

            List<EntidadAccesoSistema> listaAccesoSistema;

            listaAccesoSistema = logicaControlAcceso.listaAccesoSistema();

            foreach (EntidadAccesoSistema item in listaAccesoSistema)
            {
                dgvControlAcceso.Rows.Add(new object[] { "", item.IdAccesoSistema, item.objFuncionario.IdFuncionario, item.Clave, item.NivelAcceso});

            }
        }//Fin CargarListaGrid

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }//FinbtnSalir_Click

        private void CargarFuncionarios()
        {

            LogicaFuncionarios LogicaFuncionarios = new LogicaFuncionarios(Configuracion.getCadenaConexion);
            List<EntidadFuncionarios> funcionarios = LogicaFuncionarios.ListarFuncionariosLista();
            cbbFuncionario.DataSource = funcionarios;
            cbbFuncionario.DisplayMember = "Cedula";
            cbbFuncionario.ValueMember = "IdFuncionario";
           
        }//FinCargarFuncionarios

        private void dgvControlAcceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogicaFuncionarios logicaFuncionarios = new LogicaFuncionarios(Configuracion.getCadenaConexion);
            List<EntidadFuncionarios> funcionarios = logicaFuncionarios.ListarFuncionariosLista();


            if (dgvControlAcceso.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIdSeleccionado.Text = dgvControlAcceso.Rows[indice].Cells["IdAccesoSistema"].Value.ToString();

                    int idFuncionario = (int)dgvControlAcceso.Rows[indice].Cells["IdFuncionario"].Value;
                    string cedulaFuncionario =funcionarios.FirstOrDefault(x => x.IdFuncionario == idFuncionario)?.Cedula;
                    cbbFuncionario.Text = cedulaFuncionario;

                    txtClave.Text = dgvControlAcceso.Rows[indice].Cells["Clave"].Value.ToString();

                    cbbNivelAcceso.Text = dgvControlAcceso.Rows[indice].Cells["NivelAcceso"].Value.ToString();

                }
            }
        }//FindgvControlAcceso_CellContentClick

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            LogicaControlAcceso logicaControlAcceso = new LogicaControlAcceso(Configuracion.getCadenaConexion);
            EntidadAccesoSistema entidadAcceso = generarEntidadAccesoSistema();

            string Mensaje = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(cbbFuncionario.Text) | string.IsNullOrEmpty(txtClave.Text) | string.IsNullOrEmpty(cbbNivelAcceso.Text))
                {
                    MessageBox.Show("Faltan datos.  Favor complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    entidadAcceso = generarEntidadAccesoSistema();
                    entidadAcceso.IdAccesoSistema = Convert.ToInt32(txtIdSeleccionado.Text);
                    bool resultado = logicaControlAcceso.EditarControlAcceso(entidadAcceso, out Mensaje);

                    if (resultado)
                    {
                        DataGridViewRow fila = dgvControlAcceso.Rows[Convert.ToInt32(btnSeleccionar.Text)];
                        fila.Cells["IdAccesoSistema"].Value = txtIdSeleccionado.Text;
                        fila.Cells["IdFuncionario"].Value =cbbFuncionario.SelectedItem;
                        fila.Cells["Clave"].Value = txtClave.Text;
                        fila.Cells["NivelAcceso"].Value = cbbNivelAcceso.SelectedValue;
                       
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



    }//FrmControlAcceso
}
