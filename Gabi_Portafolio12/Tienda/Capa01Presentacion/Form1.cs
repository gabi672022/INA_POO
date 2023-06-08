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
        private Form ventanaAbierta = null; // Variable para almacenar la ventana abierta actualmente
        public Form1()
        {
            InitializeComponent();
        }

        private void stripClientes_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana abierta actualmente
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            Clientes Cliente = new Clientes();
            Cliente.MdiParent = this;
            Cliente.Show();
            ventanaAbierta = Cliente; // Establecer la nueva ventana abierta como la ventana actual
        }

        private void stripProductos_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            Productos Producto = new Productos();
            Producto.MdiParent = this;
            Producto.Show();
            ventanaAbierta = Producto;
        }

        private void stripFacturación_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            Facturacion Factura = new Facturacion();
            Factura.MdiParent = this;
            Factura.Show();
            ventanaAbierta = Factura;
        }
    }
}
