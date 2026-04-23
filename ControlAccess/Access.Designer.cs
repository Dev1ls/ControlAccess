using System;

namespace ControlAccess
{
    partial class Access
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Access));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.btnArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.accessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Desconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrud = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInvitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusCamaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.StripBarra = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArchivo,
            this.btnCrud,
            this.btnAyuda});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1052, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // btnArchivo
            // 
            this.btnArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessToolStripMenuItem,
            this.Desconectar,
            this.salirToolStripMenuItem});
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(60, 20);
            this.btnArchivo.Text = "Archivo";
            // 
            // accessToolStripMenuItem
            // 
            this.accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            this.accessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.accessToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.accessToolStripMenuItem.Text = "Access";
            this.accessToolStripMenuItem.Click += new System.EventHandler(this.accessToolStripMenuItem_Click);
            // 
            // Desconectar
            // 
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Desconectar.Size = new System.Drawing.Size(181, 22);
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnCrud
            // 
            this.btnCrud.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.agregarInvitacionToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.btnCrud.Name = "btnCrud";
            this.btnCrud.Size = new System.Drawing.Size(50, 20);
            this.btnCrud.Text = "CRUD";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // agregarInvitacionToolStripMenuItem
            // 
            this.agregarInvitacionToolStripMenuItem.Name = "agregarInvitacionToolStripMenuItem";
            this.agregarInvitacionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.agregarInvitacionToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.agregarInvitacionToolStripMenuItem.Text = "Agregar Invitacion";
            this.agregarInvitacionToolStripMenuItem.Click += new System.EventHandler(this.agregarInvitacionToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.editarToolStripMenuItem.Text = "Editar Usuario";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.administradorToolStripMenuItem.Text = "Administrador Report";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBaseDeDatosToolStripMenuItem,
            this.statusCamaraToolStripMenuItem,
            this.informacionToolStripMenuItem});
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(53, 20);
            this.btnAyuda.Text = "Ayuda";
            // 
            // statusBaseDeDatosToolStripMenuItem
            // 
            this.statusBaseDeDatosToolStripMenuItem.Name = "statusBaseDeDatosToolStripMenuItem";
            this.statusBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.statusBaseDeDatosToolStripMenuItem.Text = "Estado Base de Datos";
            this.statusBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.statusBaseDeDatosToolStripMenuItem_Click);
            // 
            // statusCamaraToolStripMenuItem
            // 
            this.statusCamaraToolStripMenuItem.Name = "statusCamaraToolStripMenuItem";
            this.statusCamaraToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.statusCamaraToolStripMenuItem.Text = "Estado Camara";
            this.statusCamaraToolStripMenuItem.Click += new System.EventHandler(this.statusCamaraToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripBarra});
            this.BarraEstado.Location = new System.Drawing.Point(0, 645);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(1052, 22);
            this.BarraEstado.TabIndex = 3;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // StripBarra
            // 
            this.StripBarra.Name = "StripBarra";
            this.StripBarra.Size = new System.Drawing.Size(0, 17);
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 667);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.MinimizeBox = false;
            this.Name = "Access";
            this.Text = "Access";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Access_FormClosing);
            this.Load += new System.EventHandler(this.Access_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem btnArchivo;
        private System.Windows.Forms.ToolStripStatusLabel StripBarra;
        public System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripMenuItem accessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrud;
        private System.Windows.Forms.ToolStripMenuItem agregarInvitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Desconectar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem statusBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusCamaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

