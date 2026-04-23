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
using System.Data.SqlClient;

namespace ControlAccess
{
    public partial class Agregar : Form
    {
        private static Agregar frmInstancia = null;
        public Agregar()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            txtApellido.Enabled = false;
            txtDomicilio.Enabled = false;
            txtPatente1.Enabled = false;
            txtPatente2.Enabled = false;
            txtPatente3.Enabled = false;
            txtPatente1.CharacterCasing = CharacterCasing.Upper;
            txtPatente2.CharacterCasing = CharacterCasing.Upper;
            txtPatente3.CharacterCasing = CharacterCasing.Upper;
            txtPatente1.MaxLength = 6;
            txtPatente2.MaxLength = 6;
            txtPatente3.MaxLength = 6;
        }
        public static Agregar Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Agregar();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") | txtApellido.Text.Equals("") | txtDomicilio.Text.Equals(""))
            {
                MessageBox.Show("Ingresa Datos Personales ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAgregar.Enabled = false;
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Domicilio = txtDomicilio.Text;
                usuario.Patente1 = txtPatente1.Text;
                usuario.Patente2 = txtPatente2.Text;
                usuario.Patente3 = txtPatente3.Text;

                int Resultado = CRUD.Agregar(usuario);
                if (Resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Correctamente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                    conn.Open();
                    DataTable Dtable = new DataTable();
                    //REINICIO TABLA
                    SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usuario", conn);
                    query.Fill(Dtable);
                    Tabla.DataSource = Dtable;
                }
                else
                {
                    MessageBox.Show("Error al Ejecutar", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }              
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                txtApellido.Enabled = true;
                btnAgregar.Enabled = true;
            }
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!txtApellido.Text.Equals(""))
            {
                txtDomicilio.Enabled = true;
            }
        }
        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            if (!txtDomicilio.Text.Equals(""))
            {
                txtPatente1.Enabled = true;
            }
        }
        private void txtPatente1_TextChanged(object sender, EventArgs e)
        {
            if (!txtPatente1.Text.Equals(""))
            {
                txtPatente2.Enabled = true;
            }
        }
        private void txtPatente2_TextChanged(object sender, EventArgs e)
        {
            if (!txtPatente2.Text.Equals(""))
            {
                txtPatente3.Enabled = true;
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            DataTable Dtable = new DataTable();
            //REINICIO TABLA
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usuario", conn);
            query.Fill(Dtable);
            Tabla.DataSource = Dtable;
            //conn.Close();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtApellido.Focus();
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDomicilio.Focus();
            }
        }
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatente1.Focus();
            }
        }
        private void txtPatente1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatente2.Focus();
            }
        }
        private void txtPatente2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPatente3.Focus();
            }
        }
    }
}