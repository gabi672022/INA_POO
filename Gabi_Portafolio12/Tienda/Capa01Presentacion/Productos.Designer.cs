
namespace Capa01Presentacion
{
    partial class Productos
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
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRABADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.DESCRIPCION,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.GRABADO});
            this.dataGridView1.Location = new System.Drawing.Point(31, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO_VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            // 
            // GRABADO
            // 
            this.GRABADO.HeaderText = "GRABADO";
            this.GRABADO.Name = "GRABADO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.Location = new System.Drawing.Point(31, 326);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 51);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 32;
            this.btnNuevo.Location = new System.Drawing.Point(145, 326);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 51);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.Location = new System.Drawing.Point(487, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 51);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 32;
            this.btnEliminar.Location = new System.Drawing.Point(373, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 51);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.Location = new System.Drawing.Point(259, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 51);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(31, 79);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(521, 64);
            this.txtDireccion.TabIndex = 29;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(31, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(40, 13);
            this.lblDireccion.TabIndex = 28;
            this.lblDireccion.Text = "Código";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(459, 25);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(93, 20);
            this.txtTelefono.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 25;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(456, 9);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(159, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 393);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRABADO;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}