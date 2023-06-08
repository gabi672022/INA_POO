
namespace Capa01Presentacion
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_ENCABEZADO_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO_DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ENCABEZADO_FACTURA,
            this.FECHA,
            this.ID_CLIENTE,
            this.ID_PRODUCTO,
            this.CANTIDAD,
            this.SUBTOTAL,
            this.IMPUESTO,
            this.MONTO_DESCUENTO});
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_ENCABEZADO_FACTURA
            // 
            this.ID_ENCABEZADO_FACTURA.HeaderText = "ID_ENCABEZADO_FACTURA";
            this.ID_ENCABEZADO_FACTURA.Name = "ID_ENCABEZADO_FACTURA";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.Name = "SUBTOTAL";
            // 
            // IMPUESTO
            // 
            this.IMPUESTO.HeaderText = "IMPUESTO";
            this.IMPUESTO.Name = "IMPUESTO";
            // 
            // MONTO_DESCUENTO
            // 
            this.MONTO_DESCUENTO.HeaderText = "MONTO_DESCUENTO";
            this.MONTO_DESCUENTO.Name = "MONTO_DESCUENTO";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ENCABEZADO_FACTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_DESCUENTO;
    }
}