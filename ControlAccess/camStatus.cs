using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAccess
{
    public partial class camStatus : Form
    {
        private static camStatus frmInstancia = null;

        public camStatus()
        {
            InitializeComponent();
        }
        public static camStatus Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new camStatus();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }

        private void camStatus_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Unknown";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            /*
             * try
            {               
                lblStatus.Text = "Conexión Establecida";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception)
            {
                lblStatus.Text = "Error";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            */
        }
    }
}
