using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa04Entidades;
using Capa02Logica;

namespace Capa01Presentacion
{
    public partial class FrmEvento : Form
    {
        private EntidadHorariosEspecialistas entidadGenerada;
        public FrmEvento()
        {
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
           
            txtFecha.Text =  UserControl1_Dias.diaS + "/" + FrmCalendario.mesS + "/" + FrmCalendario.annioS;
            //GenerarEntidadHorariosEspecialistas();
            CargarHorasEnComboBox();
            //entidadGenerada = GenerarEntidadHorariosEspecialistas();
        }

        public EntidadHorariosEspecialistas GenerarEntidadHorariosEspecialistas()
        {
            EntidadHorariosEspecialistas objEntidadHorariosEspecialistas = new EntidadHorariosEspecialistas();
            EntidadEspecialistas objEntidadEspecialista = new EntidadEspecialistas();
            string mensaje = string.Empty; 

            string fechaAgenda = txtFecha.Text;

            string[] partesFecha = fechaAgenda.Split('/');
            string mes = string.Empty;
            string dia = string.Empty;
             string annio = string.Empty;

            if (partesFecha.Length == 3)
            {
                 mes = partesFecha[1];
                 dia = partesFecha[0];
                annio = partesFecha[2];

               mensaje = string.Format("Fecha formateada: {0}-{1}-{2}\n Fecha original: {3}",dia, mes, annio, fechaAgenda);
            }
           

            MessageBox.Show(mensaje);

            string consultaCbb = cbbHoraInicio.SelectedItem.ToString();
            MessageBox.Show("Contenido de cbb" + consultaCbb);

            if (cbbHoraInicio.SelectedItem != null)
            {
                objEntidadHorariosEspecialistas.Hora_inicio = cbbHoraInicio.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna hora");
                return null;
            }
            objEntidadHorariosEspecialistas.FechaAgenda = txtFecha.Text;
            objEntidadHorariosEspecialistas.Hora_fin = txtHoraFin.Text;
            //objEntidadHorariosEspecialistas.Dia = dia;
            objEntidadHorariosEspecialistas.objEspecialista = new EntidadEspecialistas();
            objEntidadHorariosEspecialistas.objEspecialista.IdEspecialista = Convert.ToInt32(txtIdEspecialista.Text);
           
            return objEntidadHorariosEspecialistas;

        }

        private void CargarHorasEnComboBox()
        {
            cbbHoraInicio.Items.Clear();
            DateTime horaInicio = new DateTime(1, 1, 1, 7, 0, 0);
            DateTime horaFin = new DateTime(1, 1, 1, 22, 0, 0);
            TimeSpan intervalo = TimeSpan.FromMinutes(30);
            while (horaInicio<= horaFin)
            {
                cbbHoraInicio.Items.Add(horaInicio.ToString("HH:mm"));
                horaInicio = horaInicio.Add(intervalo);
            }

        }

 private void cbbHoraInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHoraInicio.SelectedItem != null)
            {
                string horaInicioSeleccionada = cbbHoraInicio.SelectedItem.ToString();
                DateTime horaInicio = DateTime.Parse(horaInicioSeleccionada);             
                DateTime horaFin = horaInicio.AddMinutes(30);          
                txtHoraFin.Text= horaFin.ToString("HH:mm");
            }
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //EntidadHorariosEspecialistas objHorariosEspecialistas = GenerarEntidadHorariosEspecialistas();
            EntidadHorariosEspecialistas objHorariosEspecialistas = new EntidadHorariosEspecialistas();
            LogicaHorariosEspecialistas logicaHorariosEspecialistas = new LogicaHorariosEspecialistas(Configuracion.getCadenaConexion);

            int resultado = 0;

            try
            {
                if (string.IsNullOrEmpty(txtFecha.Text) | string.IsNullOrEmpty(txtIdEspecialista.Text) | string.IsNullOrEmpty(cbbHoraInicio.Text) | string.IsNullOrEmpty(txtHoraFin.Text) )
                {
                    MessageBox.Show("No se permiten campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objHorariosEspecialistas = GenerarEntidadHorariosEspecialistas();
                    resultado = logicaHorariosEspecialistas.InsertarHorarioEspecialista(objHorariosEspecialistas);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
 