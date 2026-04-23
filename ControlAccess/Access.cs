
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAccess.Clases;

/*
***********TODO***********
VALIDAR USUARIO, VALIDAR ELIMINAR.



*/

namespace ControlAccess
{
    public partial class Access : Form
    {
        camStatus cam;
        bdStatus status;
        Informacion info;
        Invitacion Inv;
        Eliminar Delete;
        Editar Edit;
        Agregar Add;
        Login Log;
        AccessPrincipal Prin;
        Admin Adm;
        public Access()
        {
            InitializeComponent();
            btnArchivo.Enabled = false;
            btnCrud.Enabled = false;
            btnAyuda.Enabled = false;
        }
        public bool UsuarioLogueado = false;
        private void Access_Load(object sender, EventArgs e)
        {
            //this.Hide();
            Log = new Login();
            Log.ShowDialog();
            if (Log.Logueado==true)
            {
                btnCrud.Enabled = true;
                this.Show();
                StripBarra.Text = "Usuario: " + Log.txtNombre.Text.ToUpper();
                UsuarioLogueado = true;
                btnArchivo.Enabled = true;
                btnAyuda.Enabled = true;
            }
            else
            {
                this.Close();
            }
        }
        private void Access_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioLogueado == true)
            {
                btnArchivo.Enabled = false;
                btnCrud.Enabled = false;
                DialogResult respuesta;
                respuesta = MessageBox.Show("Cerrar Programa?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    btnArchivo.Enabled = true;
                    btnCrud.Enabled = true;
                    e.Cancel = true;
                }
            }
        }
        private void Desconectar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datos.CerrarConexion();
            Log = new Login();
            Log.ShowDialog();
            Log.txtNombre.Text = "";
            Log.txtContraseña.Text = "";
            if (true)
            {
                if (Log.Logueado == true)
                {
                    btnCrud.Enabled = true;
                    this.Show();
                    StripBarra.Text = "Usuario: " + Log.txtNombre.Text.ToUpper();
                    UsuarioLogueado = true;
                    btnArchivo.Enabled = true;
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void accessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prin = AccessPrincipal.Instancia();
            Prin.MdiParent = this;
            Prin.Show();
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add = Agregar.Instancia();
            Add.MdiParent = this;
            Add.Show();
        }
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edit = Editar.Instancia();
            Edit.MdiParent = this;
            Edit.Show();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete = Eliminar.Instancia();
            Delete.MdiParent = this;
            Delete.Show();
        }
        private void agregarInvitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inv = Invitacion.Instancia();
            Inv.MdiParent = this;
            Inv.Show();
        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Adm = Admin.Instancia();
                Adm.MdiParent = this;
                Adm.Show();
            }
        }
        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info = Informacion.Instancia();
            info.MdiParent = this;
            info.Show();
        }

        private void statusBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = bdStatus.Instancia();
            status.MdiParent = this;
            status.Show();
        }

        private void statusCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam = camStatus.Instancia();
            cam.MdiParent = this;
            cam.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
