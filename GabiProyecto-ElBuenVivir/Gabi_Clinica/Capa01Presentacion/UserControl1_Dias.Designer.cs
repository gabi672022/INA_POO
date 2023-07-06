
namespace Capa01Presentacion
{
    partial class UserControl1_Dias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(21, 11);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(25, 13);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "  00";
            // 
            // UserControl1_Dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.lblDias);
            this.Name = "UserControl1_Dias";
            this.Size = new System.Drawing.Size(76, 38);
            this.Load += new System.EventHandler(this.UserControl1_Dias_Load);
            this.Click += new System.EventHandler(this.UserControl1_Dias_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
    }
}
