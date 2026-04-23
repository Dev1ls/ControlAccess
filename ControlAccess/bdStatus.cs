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
    public partial class bdStatus : Form
    {
        private static bdStatus frmInstancia = null;
        public bdStatus()
        {
            InitializeComponent();
        }
        private void bdStatus_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            try
            {
                conn.Open();
                lblStatus.Text = "Conexión Establecida";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception)
            {
                lblStatus.Text = "Error";
                lblStatus.ForeColor = System.Drawing.Color.Red;             
            }         
        }
        public static bdStatus Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new bdStatus();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
    }
}
