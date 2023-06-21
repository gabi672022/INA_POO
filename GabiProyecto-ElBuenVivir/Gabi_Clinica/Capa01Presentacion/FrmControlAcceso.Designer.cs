
namespace Capa01Presentacion
{
    partial class FrmControlAcceso
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
            this.lblControlAcceso = new System.Windows.Forms.Label();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.txtIdAccesoSistema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cbbNivelAcceso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdSeleccionado = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnInsertar = new FontAwesome.Sharp.IconButton();
            this.dgvControlAcceso = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdAccesoSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAcceso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlAcceso
            // 
            this.lblControlAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlAcceso.Location = new System.Drawing.Point(37, 9);
            this.lblControlAcceso.Name = "lblControlAcceso";
            this.lblControlAcceso.Size = new System.Drawing.Size(477, 56);
            this.lblControlAcceso.TabIndex = 0;
            this.lblControlAcceso.Text = "Control de Acceso";
            this.lblControlAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Location = new System.Drawing.Point(33, 93);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(89, 13);
            this.lblAcceso.TabIndex = 1;
            this.lblAcceso.Text = "IdAccesoSistema";
            // 
            // txtIdAccesoSistema
            // 
            this.txtIdAccesoSistema.Location = new System.Drawing.Point(36, 109);
            this.txtIdAccesoSistema.Name = "txtIdAccesoSistema";
            this.txtIdAccesoSistema.Size = new System.Drawing.Size(100, 20);
            this.txtIdAccesoSistema.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Funcionario";
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(150, 108);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(121, 21);
            this.cbbFuncionario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(287, 109);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 6;
            // 
            // cbbNivelAcceso
            // 
            this.cbbNivelAcceso.FormattingEnabled = true;
            this.cbbNivelAcceso.Location = new System.Drawing.Point(393, 108);
            this.cbbNivelAcceso.Name = "cbbNivelAcceso";
            this.cbbNivelAcceso.Size = new System.Drawing.Size(121, 21);
            this.cbbNivelAcceso.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nivel de Acceso";
            // 
            // txtIdSeleccionado
            // 
            this.txtIdSeleccionado.Location = new System.Drawing.Point(477, 135);
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
            this.btnEliminar.Location = new System.Drawing.Point(312, 351);
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
            this.btnEditar.Location = new System.Drawing.Point(174, 351);
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
            this.btnSalir.Location = new System.Drawing.Point(450, 351);
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
            this.btnInsertar.Location = new System.Drawing.Point(36, 351);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(64, 61);
            this.btnInsertar.TabIndex = 43;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dgvControlAcceso
            // 
            this.dgvControlAcceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlAcceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.IdAccesoSistema,
            this.IdFuncionario,
            this.Clave,
            this.NivelAcceso});
            this.dgvControlAcceso.Location = new System.Drawing.Point(36, 178);
            this.dgvControlAcceso.Name = "dgvControlAcceso";
            this.dgvControlAcceso.Size = new System.Drawing.Size(478, 150);
            this.dgvControlAcceso.TabIndex = 48;
            this.dgvControlAcceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlAcceso_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Width = 30;
            // 
            // IdAccesoSistema
            // 
            this.IdAccesoSistema.HeaderText = "IdAccesoSistema";
            this.IdAccesoSistema.Name = "IdAccesoSistema";
            this.IdAccesoSistema.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdAccesoSistema.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IdFuncionario
            // 
            this.IdFuncionario.HeaderText = "Funcionario";
            this.IdFuncionario.Name = "IdFuncionario";
            this.IdFuncionario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdFuncionario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NivelAcceso
            // 
            this.NivelAcceso.HeaderText = "Nive de Acceso";
            this.NivelAcceso.Name = "NivelAcceso";
            this.NivelAcceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NivelAcceso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmControlAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 437);
            this.Controls.Add(this.dgvControlAcceso);
            this.Controls.Add(this.txtIdSeleccionado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cbbNivelAcceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdAccesoSistema);
            this.Controls.Add(this.lblAcceso);
            this.Controls.Add(this.lblControlAcceso);
            this.Name = "FrmControlAcceso";
            this.Text = "Control de Acceso";
            this.Load += new System.EventHandler(this.FrmControlAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlAcceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlAcceso;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.TextBox txtIdAccesoSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cbbNivelAcceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdSeleccionado;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnInsertar;
        private System.Windows.Forms.DataGridView dgvControlAcceso;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAccesoSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelAcceso;
    }
}