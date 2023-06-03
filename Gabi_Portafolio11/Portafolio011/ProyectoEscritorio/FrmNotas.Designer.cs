
namespace ProyectoEscritorio
{
    partial class FrmNotas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotaSeleccionada = new System.Windows.Forms.TextBox();
            this.lstNotasIngresadas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMostrarPromedio = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotaSeleccionada);
            this.groupBox1.Controls.Add(this.lstNotasIngresadas);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtMostrarPromedio);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.btnPromedio);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(611, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // txtNotaSeleccionada
            // 
            this.txtNotaSeleccionada.Location = new System.Drawing.Point(181, 95);
            this.txtNotaSeleccionada.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotaSeleccionada.Name = "txtNotaSeleccionada";
            this.txtNotaSeleccionada.ReadOnly = true;
            this.txtNotaSeleccionada.Size = new System.Drawing.Size(132, 23);
            this.txtNotaSeleccionada.TabIndex = 9;
            // 
            // lstNotasIngresadas
            // 
            this.lstNotasIngresadas.FormattingEnabled = true;
            this.lstNotasIngresadas.ItemHeight = 16;
            this.lstNotasIngresadas.Location = new System.Drawing.Point(339, 23);
            this.lstNotasIngresadas.Margin = new System.Windows.Forms.Padding(4);
            this.lstNotasIngresadas.Name = "lstNotasIngresadas";
            this.lstNotasIngresadas.Size = new System.Drawing.Size(255, 308);
            this.lstNotasIngresadas.TabIndex = 8;
            this.lstNotasIngresadas.SelectedIndexChanged += new System.EventHandler(this.lstNotasIngresadas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(215, 28);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMostrarPromedio
            // 
            this.txtMostrarPromedio.BackColor = System.Drawing.SystemColors.Info;
            this.txtMostrarPromedio.Location = new System.Drawing.Point(12, 308);
            this.txtMostrarPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMostrarPromedio.Name = "txtMostrarPromedio";
            this.txtMostrarPromedio.Size = new System.Drawing.Size(301, 23);
            this.txtMostrarPromedio.TabIndex = 6;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(111, 31);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota.MaxLength = 3;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(95, 23);
            this.txtNota.TabIndex = 5;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(156, 244);
            this.btnPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(159, 28);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Ver Resultado";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 185);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(195, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Lista de Notas";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 149);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota Seleccionada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite la Nota";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(527, 373);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotaSeleccionada;
        private System.Windows.Forms.ListBox lstNotasIngresadas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMostrarPromedio;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}

