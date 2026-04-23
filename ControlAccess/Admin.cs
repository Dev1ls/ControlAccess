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
using System.Windows.Forms;

namespace ControlAccess
{
    public partial class Admin : Form
    {
        private static Admin frmInstancia = null;
        public Admin()
        {
            InitializeComponent();
            gifError.Visible = false;
            report.Visible = false;
            txtPass.MaxLength = 3;
        }
        public static Admin Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Admin();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                if (txtPass.Text.Equals("god"))
                {
                    gifError.Visible = false;
                    txtPass.Visible = false;
                    lblPass.Visible = false;
                    report.Visible = true;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    gifError.Visible = true;
                    txtPass.Focus();
                    txtPass.Text = "";
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetProductos.Usuario' Puede moverla o quitarla según sea necesario.
            this.UsuarioTableAdapter.Fill(this.datasetProductos.Usuario);

            this.report.RefreshReport();
        }
    }
}
