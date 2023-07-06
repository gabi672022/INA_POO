using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa01Presentacion
{
    public partial class FrmCalendario : Form
    {
        int mes, annio;
        public static int mesS, annioS;
        public FrmCalendario()
        {
            InitializeComponent();
         
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            MuestraDias();
        }

        private void MuestraDias()
        {
            DateTime hoy = DateTime.Now;
            mes = hoy.Month;
            annio = hoy.Year;

            string nombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

            lblFecha.Text = nombreMes + " " + annio;

            annioS = annio;
            mesS = mes;
            DateTime primerDelMes = new DateTime(annio, mes, 1);
           
            //obtiene la cantidad de días en el mes
            int dias = DateTime.DaysInMonth(annio, mes);
          
            //Se obtiene el día de la semana en que se encuentra hoy
            int diaSemana = Convert.ToInt32(primerDelMes.DayOfWeek.ToString("d"))+1;
 
            for (int i = 1; i < diaSemana; i++)
            {
                UserControl1_Blank ucBlank = new UserControl1_Blank();
                panelContenedorDias.Controls.Add(ucBlank);
            }

            //User Control para los días

            for (int i = 1; i < dias+1; i++)
            {
                UserControl1_Dias ucDias = new UserControl1_Dias();
                ucDias.dias(i);
                panelContenedorDias.Controls.Add(ucDias);
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            panelContenedorDias.Controls.Clear();
            mes--;
            annioS = annio;
            mesS = mes;
            string nombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

            lblFecha.Text = nombreMes + " " + annio;
            DateTime primerDelMes = new DateTime(annio, mes, 1);
          
            //obtiene la cantidad de días en el mes
            int dias = DateTime.DaysInMonth(annio, mes);
          
            //Se obtiene el día de la semana en que se encuentra hoy
            int diaSemana = Convert.ToInt32(primerDelMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControl1_Blank ucBlank = new UserControl1_Blank();
                panelContenedorDias.Controls.Add(ucBlank);
            }

            //User Control para los días

            for (int i = 1; i < dias + 1; i++)
            {
                UserControl1_Dias ucDias = new UserControl1_Dias();
                ucDias.dias(i);
                panelContenedorDias.Controls.Add(ucDias);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            panelContenedorDias.Controls.Clear();
            mes++;
            annioS = annio;
            mesS = mes;

            string nombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);

            lblFecha.Text = nombreMes + " " + annio;
            DateTime primerDelMes = new DateTime(annio, mes, 1);
           
            //obtiene la cantidad de días en el mes
            int dias = DateTime.DaysInMonth(annio, mes);
          

            //Se obtiene el día de la semana en que se encuentra hoy
            int diaSemana = Convert.ToInt32(primerDelMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaSemana; i++)
            {
                UserControl1_Blank ucBlank = new UserControl1_Blank();
                panelContenedorDias.Controls.Add(ucBlank);
            }

            //User Control para los días

            for (int i = 1; i < dias + 1; i++)
            {
                UserControl1_Dias ucDias = new UserControl1_Dias();
                ucDias.dias(i);
                panelContenedorDias.Controls.Add(ucDias);
            }
        }
    }
}
