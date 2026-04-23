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
    public partial class Editar : Form
    {
        private static Editar frmInstancia = null;
        public Editar()
        {
            InitializeComponent();
            txtID.MaxLength = 3;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDomicilio.Enabled = false;
            txtPatente1.Enabled = false;
            txtPatente2.Enabled = false;
            txtPatente3.Enabled = false;
            btnEditar.Enabled = false;
            txtPatente1.CharacterCasing = CharacterCasing.Upper;
            txtPatente2.CharacterCasing = CharacterCasing.Upper;
            txtPatente3.CharacterCasing = CharacterCasing.Upper;
            txtPatente1.MaxLength = 6;
            txtPatente2.MaxLength = 6;
            txtPatente3.MaxLength = 6;
        }
        public static Editar Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Editar();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                txtNombre.Enabled = true;
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals(""))
            {
                txtApellido.Enabled = true;
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
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
            if (e.KeyChar == 13)
            {
                txtNombre.Focus();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") | txtApellido.Text.Equals("") | txtDomicilio.Text.Equals(""))
            {
                MessageBox.Show("Ingresa Datos Personales ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("Ingresa ID ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEditar.Enabled = false;
                }
                else
                {
                    int txtIDint = Convert.ToInt32(txtID.Text);
                    Usuario usuario = new Usuario();
                    usuario.iD = txtIDint;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Domicilio = txtDomicilio.Text;
                    usuario.Patente1 = txtPatente1.Text;
                    usuario.Patente2 = txtPatente2.Text;
                    usuario.Patente3 = txtPatente3.Text;

                    int Resultado = CRUD.Modificar(usuario);

                    if (Resultado > 0)
                    {
                        try
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
                            btnEditar.Enabled = false;
                            txtID.Text = "";
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            txtDomicilio.Text = "";
                            txtPatente1.Text = "";
                            txtPatente2.Text = "";
                            txtPatente3.Text = "";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al Ejecutar", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            throw;
                        }
                    }
                }                         
            }          
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!txtID.Text.Equals(""))
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtDomicilio.Enabled = true;
                txtPatente1.Enabled = true;
                txtPatente2.Enabled = true;
                txtPatente3.Enabled = true;
                btnEditar.Enabled = true;
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                    conn.Open();
                    DataTable Dtable = new DataTable();
                    //ES NECESARIO??
                    int txtIDint = Convert.ToInt32(txtID.Text);
                    SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usuario WHERE ID_Usuario='" + txtIDint + "'", conn);                   
                    query.Fill(Dtable);
                    Tabla.DataSource = Dtable;                                                                         
                }
                catch (Exception)
                {
                    throw;
                } 
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int txtIDint = Convert.ToInt32(txtID.Text);
                string sentencia = ("SELECT * FROM Usuario WHERE ID_Usuario='" + txtIDint + "'");
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                conn.Open();
                SqlCommand cmd = new SqlCommand(string.Format(sentencia));
                cmd.Connection = conn;
                SqlDataReader Dreader = cmd.ExecuteReader();
                if (Dreader.Read() == true)
                {
                    txtNombre.Text = Dreader["Nombre"].ToString();
                    txtApellido.Text = Dreader["Apellido"].ToString();
                    txtDomicilio.Text = Dreader["Domicilio"].ToString();
                    txtPatente1.Text = Dreader["Patente1"].ToString();
                    txtPatente2.Text = Dreader["Patente2"].ToString();
                    txtPatente3.Text = Dreader["Patente3"].ToString();
                }              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
