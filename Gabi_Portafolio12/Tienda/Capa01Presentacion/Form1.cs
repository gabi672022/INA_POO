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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stripClientes_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();
            Cliente.MdiParent = this;
            Cliente.Show();
        }

        private void stripProductos_Click(object sender, EventArgs e)
        {
            Productos Producto = new Productos();
            Producto.MdiParent = this;
            Producto.Show();

        }

        private void stripFacturación_Click(object sender, EventArgs e)
        {
            Facturacion Factura = new Facturacion();
            Factura.MdiParent = this;
            Factura.Show();
        }
    }
}
