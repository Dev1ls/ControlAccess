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
    public partial class Eliminar : Form
    {
        DataTable Dtable = new DataTable();
        private static Eliminar frmInstancia = null;

        public Eliminar()
        {
            InitializeComponent();
            txtID.MaxLength = 3;
            btnEliminar.Enabled = false;
        }
        
        public static Eliminar Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Eliminar();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Ingresa ID ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnEliminar.Enabled = true;
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                    conn.Open();
                    DataTable Dtable = new DataTable();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("Ingresa ID ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable Dtable = new DataTable();
                //RESULTADO STRING TO INT, txtIDint FINAL.
                int txtIDint = Convert.ToInt32(txtID.Text);
                Usuario usuario = new Usuario();
                usuario.iD = txtIDint;
                int Resultado = CRUD.Eliminar(usuario);

                if (Resultado > 0)
                {
                    MessageBox.Show("Usuario Eliminado Correctamente", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                    conn.Open();
                    //REINICIO TABLA
                    SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usuario", conn);
                    query.Fill(Dtable);
                    Tabla.DataSource = Dtable;
                    txtID.Text = "";
                }
                else
                {
                    MessageBox.Show("Error al Ejecutar", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            //REINICIO TABLA
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Usuario", conn);
            query.Fill(Dtable);
            Tabla.DataSource = Dtable;
            //conn.Close();         
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtID.Text.Equals(""))
                {
                    MessageBox.Show("Ingresa ID ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnEliminar.Enabled = true;
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
            ValidarNumero.SoloNumeros(e);
        }
    }
}