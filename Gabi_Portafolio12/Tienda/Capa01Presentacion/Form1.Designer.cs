
namespace Capa01Presentacion
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.stripProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.stripFacturación = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripClientes,
            this.stripProductos,
            this.stripFacturación});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripClientes
            // 
            this.stripClientes.Name = "stripClientes";
            this.stripClientes.Size = new System.Drawing.Size(69, 20);
            this.stripClientes.Text = "CLIENTES";
            // 
            // stripProductos
            // 
            this.stripProductos.Name = "stripProductos";
            this.stripProductos.Size = new System.Drawing.Size(86, 20);
            this.stripProductos.Text = "PRODUCTOS";
            // 
            // stripFacturación
            // 
            this.stripFacturación.Name = "stripFacturación";
            this.stripFacturación.Size = new System.Drawing.Size(98, 20);
            this.stripFacturación.Text = "FACTURACIÓN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripClientes;
        private System.Windows.Forms.ToolStripMenuItem stripProductos;
        private System.Windows.Forms.ToolStripMenuItem stripFacturación;
    }
}

