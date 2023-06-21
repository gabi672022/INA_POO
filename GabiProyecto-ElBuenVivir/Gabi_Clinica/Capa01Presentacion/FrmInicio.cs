using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Capa01Presentacion
{
    public partial class FrmInicio : Form
    {

        private IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;
            if (FormularioActivo!=null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();




        }


        private void mnuFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmFuncionarios());
        }

        private void mnuPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmPacientes());
        }

        private void puestoDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnuMantenimiento, new FrmPuestoTrabajo());
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnuMantenimiento, new FrmEspecialidad());
        }

        private void establecerHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnuEspecialidades, new FrmHorarios());
        }

        private void controlDeAccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(mnuMantenimiento, new FrmControlAcceso());
        }
    }
    
}
