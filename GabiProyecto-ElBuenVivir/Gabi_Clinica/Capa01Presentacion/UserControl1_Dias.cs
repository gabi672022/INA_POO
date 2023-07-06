using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa01Presentacion
{
    public partial class UserControl1_Dias : UserControl
    {

        public static string diaS;
        public UserControl1_Dias()
        {
            InitializeComponent();
        }

        private void UserControl1_Dias_Load(object sender, EventArgs e)
        {

        }
         public void dias(int numDay)
        {
            lblDias.Text = numDay + "";
        }

        private void UserControl1_Dias_Click(object sender, EventArgs e)
        {
            diaS = lblDias.Text;
            FrmEvento eventoForm = new FrmEvento();
            eventoForm.Show();
        }
    }
}
