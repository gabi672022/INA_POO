
namespace Capa01Presentacion
{
    partial class FrmEspecialidad
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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.lblTituloEspecialidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.lblRequisitos = new System.Windows.Forms.Label();
            this.dgvEspecialidad = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdSeleccionado = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnInsertar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(12, 54);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(40, 13);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Código";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(12, 70);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtIdEspecialidad.TabIndex = 1;
            // 
            // lblTituloEspecialidad
            // 
            this.lblTituloEspecialidad.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTituloEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEspecialidad.Location = new System.Drawing.Point(15, 23);
            this.lblTituloEspecialidad.Name = "lblTituloEspecialidad";
            this.lblTituloEspecialidad.Size = new System.Drawing.Size(474, 23);
            this.lblTituloEspecialidad.TabIndex = 2;
            this.lblTituloEspecialidad.Text = "Especialidad";
            this.lblTituloEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(118, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(284, 70);
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(205, 20);
            this.txtRequisitos.TabIndex = 6;
            // 
            // lblRequisitos
            // 
            this.lblRequisitos.AutoSize = true;
            this.lblRequisitos.Location = new System.Drawing.Point(284, 54);
            this.lblRequisitos.Name = "lblRequisitos";
            this.lblRequisitos.Size = new System.Drawing.Size(117, 13);
            this.lblRequisitos.TabIndex = 5;
            this.lblRequisitos.Text = "Requisitos Académicos";
            // 
            // dgvEspecialidad
            // 
            this.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Codigo,
            this.Nombre,
            this.Requisitos});
            this.dgvEspecialidad.Location = new System.Drawing.Point(15, 118);
            this.dgvEspecialidad.Name = "dgvEspecialidad";
            this.dgvEspecialidad.Size = new System.Drawing.Size(474, 150);
            this.dgvEspecialidad.TabIndex = 7;
            this.dgvEspecialidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidad_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 30;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Requisitos
            // 
            this.Requisitos.HeaderText = "Requisitos";
            this.Requisitos.Name = "Requisitos";
            this.Requisitos.Width = 150;
            // 
            // txtIdSeleccionado
            // 
            this.txtIdSeleccionado.Location = new System.Drawing.Point(452, 92);
            this.txtIdSeleccionado.Name = "txtIdSeleccionado";
            this.txtIdSeleccionado.Size = new System.Drawing.Size(37, 20);
            this.txtIdSeleccionado.TabIndex = 47;
            this.txtIdSeleccionado.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnEliminar.IconColor = System.Drawing.Color.CadetBlue;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(287, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 61);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.CadetBlue;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.Location = new System.Drawing.Point(151, 297);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 61);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.btnSalir.IconColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(423, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 61);
            this.btnSalir.TabIndex = 44;
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
            this.btnInsertar.Location = new System.Drawing.Point(15, 297);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(64, 61);
            this.btnInsertar.TabIndex = 43;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // FrmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 370);
            this.Controls.Add(this.txtIdSeleccionado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dgvEspecialidad);
            this.Controls.Add(this.txtRequisitos);
            this.Controls.Add(this.lblRequisitos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloEspecialidad);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Name = "FrmEspecialidad";
            this.Text = " Especialidades";
            this.Load += new System.EventHandler(this.FrmEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label lblTituloEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.DataGridView dgvEspecialidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requisitos;
        private System.Windows.Forms.TextBox txtIdSeleccionado;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnInsertar;
    }
}