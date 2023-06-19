
namespace Capa01Presentacion
{
    partial class FrmPuestoTrabajo
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
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnInsertar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdPuestoTrabajo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdPuestoTrabajo = new System.Windows.Forms.Label();
            this.dgvPuestoTrabajo = new System.Windows.Forms.DataGridView();
            this.IdPuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestoTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnSalir.IconColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(321, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 61);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnInsertar.IconColor = System.Drawing.Color.CadetBlue;
            this.btnInsertar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsertar.Location = new System.Drawing.Point(42, 237);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(64, 61);
            this.btnInsertar.TabIndex = 36;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 35;
            // 
            // txtIdPuestoTrabajo
            // 
            this.txtIdPuestoTrabajo.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdPuestoTrabajo.Location = new System.Drawing.Point(42, 37);
            this.txtIdPuestoTrabajo.Name = "txtIdPuestoTrabajo";
            this.txtIdPuestoTrabajo.ReadOnly = true;
            this.txtIdPuestoTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPuestoTrabajo.TabIndex = 34;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(160, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdPuestoTrabajo
            // 
            this.lblIdPuestoTrabajo.AutoSize = true;
            this.lblIdPuestoTrabajo.Location = new System.Drawing.Point(42, 21);
            this.lblIdPuestoTrabajo.Name = "lblIdPuestoTrabajo";
            this.lblIdPuestoTrabajo.Size = new System.Drawing.Size(40, 13);
            this.lblIdPuestoTrabajo.TabIndex = 32;
            this.lblIdPuestoTrabajo.Text = "Código";
            // 
            // dgvPuestoTrabajo
            // 
            this.dgvPuestoTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestoTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPuestoTrabajo,
            this.Nombre,
            this.Fecha_creacion});
            this.dgvPuestoTrabajo.Location = new System.Drawing.Point(42, 81);
            this.dgvPuestoTrabajo.Name = "dgvPuestoTrabajo";
            this.dgvPuestoTrabajo.Size = new System.Drawing.Size(343, 150);
            this.dgvPuestoTrabajo.TabIndex = 38;
            // 
            // IdPuestoTrabajo
            // 
            this.IdPuestoTrabajo.HeaderText = "Código";
            this.IdPuestoTrabajo.Name = "IdPuestoTrabajo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_creacion
            // 
            this.Fecha_creacion.HeaderText = "Fecha de Creacion";
            this.Fecha_creacion.Name = "Fecha_creacion";
            // 
            // FrmPuestoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 318);
            this.Controls.Add(this.dgvPuestoTrabajo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdPuestoTrabajo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdPuestoTrabajo);
            this.Name = "FrmPuestoTrabajo";
            this.Text = "FrmPuestoTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestoTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnInsertar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPuestoTrabajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdPuestoTrabajo;
        private System.Windows.Forms.DataGridView dgvPuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_creacion;
    }
}