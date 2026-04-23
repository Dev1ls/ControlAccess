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
    public partial class Invitacion : Form
    {
        private static Invitacion frmInstancia = null;
        public Invitacion()
        {
            InitializeComponent();
            txtInv1.CharacterCasing = CharacterCasing.Upper;
            txtInv2.CharacterCasing = CharacterCasing.Upper;
            txtInv3.CharacterCasing = CharacterCasing.Upper;
            txtInv1.MaxLength = 6;
            txtInv2.MaxLength = 6;
            txtInv3.MaxLength = 6;
        }
        //CODIGO INSTANCIA PARA ABRIR SOLO UN FORM POR MDI.
        public static Invitacion Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Invitacion();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
        //VALIDA ID
        //CODIGO INGRESA PATENTE1,PATENTE2 Y PATENTE3
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Ingresa ID ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {              
                try
                {
                    int Resultado = 0;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
                    conn.Open();
                    int txtIDint = Convert.ToInt32(txtID.Text);
                    SqlCommand Command = new SqlCommand(string.Format("UPDATE Usuario set Patente_Inv1='" + txtInv1.Text + "',Patente_Inv2='" + txtInv2.Text + "',Patente_Inv3='" + txtInv3.Text + "' WHERE ID_Usuario='" + txtIDint + "'"), conn);
                    //ASIGNAR CONEXION A COMMAND
                    Command.Connection = conn;
                    Resultado = Command.ExecuteNonQuery();
                    if (Resultado > 0)
                    {
                        lblStatus.Text = "Invitaciones Agregadas";
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblStatus.Text = "ERROR";
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }                   
        }
    }
}
