﻿
namespace Capa01Presentacion
{
    partial class Inicio
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.mnuEspecialidades = new FontAwesome.Sharp.IconMenuItem();
            this.mnuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.mnuPago = new FontAwesome.Sharp.IconMenuItem();
            this.mnuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.mnuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuEspecialidades,
            this.mnuMantenimiento,
            this.mnuPago,
            this.mnuAcercaDe});
            this.mnuMenu.Location = new System.Drawing.Point(0, 70);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 73);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.AutoSize = false;
            this.mnuUsuarios.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.mnuUsuarios.IconColor = System.Drawing.Color.Black;
            this.mnuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuUsuarios.IconSize = 50;
            this.mnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(100, 69);
            this.mnuUsuarios.Text = "Pacientes";
            this.mnuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.AutoSize = false;
            this.mnuEspecialidades.IconChar = FontAwesome.Sharp.IconChar.RodSnake;
            this.mnuEspecialidades.IconColor = System.Drawing.Color.Black;
            this.mnuEspecialidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuEspecialidades.IconSize = 50;
            this.mnuEspecialidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(100, 69);
            this.mnuEspecialidades.Text = "Especialidades";
            this.mnuEspecialidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.AutoSize = false;
            this.mnuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.mnuMantenimiento.IconColor = System.Drawing.Color.Black;
            this.mnuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuMantenimiento.IconSize = 50;
            this.mnuMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(100, 69);
            this.mnuMantenimiento.Text = "Mantenimiento";
            this.mnuMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuPago
            // 
            this.mnuPago.AutoSize = false;
            this.mnuPago.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.mnuPago.IconColor = System.Drawing.Color.Black;
            this.mnuPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuPago.IconSize = 50;
            this.mnuPago.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPago.Name = "mnuPago";
            this.mnuPago.Size = new System.Drawing.Size(100, 69);
            this.mnuPago.Text = "Pago";
            this.mnuPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuAcercaDe
            // 
            this.mnuAcercaDe.AutoSize = false;
            this.mnuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.mnuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.mnuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuAcercaDe.IconSize = 50;
            this.mnuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(100, 69);
            this.mnuAcercaDe.Text = "Acerca De";
            this.mnuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuTitulo
            // 
            this.mnuTitulo.AutoSize = false;
            this.mnuTitulo.BackColor = System.Drawing.Color.CadetBlue;
            this.mnuTitulo.Location = new System.Drawing.Point(0, 0);
            this.mnuTitulo.Name = "mnuTitulo";
            this.mnuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuTitulo.Size = new System.Drawing.Size(800, 70);
            this.mnuTitulo.TabIndex = 1;
            this.mnuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clínica El Buen Vivir";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 143);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 307);
            this.pnlContenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.mnuTitulo);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.MenuStrip mnuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem mnuUsuarios;
        private FontAwesome.Sharp.IconMenuItem mnuEspecialidades;
        private FontAwesome.Sharp.IconMenuItem mnuMantenimiento;
        private FontAwesome.Sharp.IconMenuItem mnuPago;
        private FontAwesome.Sharp.IconMenuItem mnuAcercaDe;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}
