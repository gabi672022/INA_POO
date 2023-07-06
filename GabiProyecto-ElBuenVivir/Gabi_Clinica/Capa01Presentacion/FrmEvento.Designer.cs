
namespace Capa01Presentacion
{
    partial class FrmEvento
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEventoEspecialista = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdEspecialista = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.cbbHoraInicio = new System.Windows.Forms.ComboBox();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEventoEspecialista
            // 
            this.lblEventoEspecialista.AutoSize = true;
            this.lblEventoEspecialista.Location = new System.Drawing.Point(201, 38);
            this.lblEventoEspecialista.Name = "lblEventoEspecialista";
            this.lblEventoEspecialista.Size = new System.Drawing.Size(63, 13);
            this.lblEventoEspecialista.TabIndex = 1;
            this.lblEventoEspecialista.Text = "Especialista";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(45, 55);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(117, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // txtIdEspecialista
            // 
            this.txtIdEspecialista.Location = new System.Drawing.Point(204, 53);
            this.txtIdEspecialista.Multiline = true;
            this.txtIdEspecialista.Name = "txtIdEspecialista";
            this.txtIdEspecialista.Size = new System.Drawing.Size(84, 22);
            this.txtIdEspecialista.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnGuardar.IconColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(45, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(58, 57);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Nuevo";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.FechaCita,
            this.HoraInicio,
            this.HoraFin});
            this.dataGridView1.Location = new System.Drawing.Point(45, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 185);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(42, 101);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.lblHoraInicio.TabIndex = 6;
            this.lblHoraInicio.Text = "Hora Inicio";
            this.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(201, 101);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(47, 13);
            this.lblHoraFin.TabIndex = 7;
            this.lblHoraFin.Text = "Hora Fin";
            this.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbbHoraInicio
            // 
            this.cbbHoraInicio.FormattingEnabled = true;
            this.cbbHoraInicio.Location = new System.Drawing.Point(45, 116);
            this.cbbHoraInicio.Name = "cbbHoraInicio";
            this.cbbHoraInicio.Size = new System.Drawing.Size(121, 21);
            this.cbbHoraInicio.TabIndex = 8;
            this.cbbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.cbbHoraInicio_SelectedIndexChanged);
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(201, 115);
            this.txtHoraFin.Multiline = true;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(122, 22);
            this.txtHoraFin.TabIndex = 9;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 30;
            // 
            // FechaCita
            // 
            this.FechaCita.HeaderText = "Fecha Cita";
            this.FechaCita.Name = "FechaCita";
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "HoraInicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "HoraFin";
            this.HoraFin.Name = "HoraFin";
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.cbbHoraInicio);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdEspecialista);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblEventoEspecialista);
            this.Controls.Add(this.lblFecha);
            this.Name = "FrmEvento";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.FrmEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEventoEspecialista;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIdEspecialista;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.ComboBox cbbHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
    }
}