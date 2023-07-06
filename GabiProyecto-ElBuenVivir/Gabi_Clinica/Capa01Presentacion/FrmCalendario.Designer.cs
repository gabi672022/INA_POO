
namespace Capa01Presentacion
{
    partial class FrmCalendario
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
            this.panelContenedorDias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAtras = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.lblDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelContenedorDias
            // 
            this.panelContenedorDias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelContenedorDias.Location = new System.Drawing.Point(47, 87);
            this.panelContenedorDias.Name = "panelContenedorDias";
            this.panelContenedorDias.Size = new System.Drawing.Size(575, 270);
            this.panelContenedorDias.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAtras.IconColor = System.Drawing.Color.CadetBlue;
            this.btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtras.IconSize = 32;
            this.btnAtras.Location = new System.Drawing.Point(6, 322);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(35, 35);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.CadetBlue;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 32;
            this.btnSiguiente.Location = new System.Drawing.Point(628, 322);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(35, 35);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDia
            // 
            this.lblDia.Location = new System.Drawing.Point(68, 61);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(56, 23);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Domingo";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(158, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lunes";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(235, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Martes";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(475, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Viernes";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(395, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jueves";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(308, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Miércoles";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(558, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sábado";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(47, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(567, 23);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "MES-AÑO";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 390);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelContenedorDias);
            this.Name = "FrmCalendario";
            this.Text = "FrmCalendario";
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelContenedorDias;
        private FontAwesome.Sharp.IconButton btnAtras;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
    }
}