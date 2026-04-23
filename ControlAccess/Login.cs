using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlAccess.Clases;

namespace ControlAccess
{
    public partial class Login : Form
    {
        public bool Logueado = false;
        public string Resultado;
        public Login()
        {
            InitializeComponent();
            txtNombre.MaxLength = 10;
            txtContraseña.MaxLength = 5;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtContraseña.TextAlign = HorizontalAlignment.Center;            
        }      
        //VALIDAR LOGIN USUARIO Y CONTRASEÑA.
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Resultado = Datos.IniciarSesion(txtNombre.Text, txtContraseña.Text);
            Logueado = true;
            if (Resultado != "")
            {
                Logueado = true;
                MessageBox.Show("Bienvenido " + txtNombre.Text.ToUpper(),"Acceso Confirmado!", MessageBoxButtons.OK);
                this.Close();            
            }
            else
            {
                MessageBox.Show("Acceso Denegado,Intente Nuevamente", "Error", MessageBoxButtons.OK);
                txtNombre.Text = "";
                txtContraseña.Text = "";
                txtNombre.Focus();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CODIGO SETEO TECLA ENTER. 
        //FOCUS PASS.
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == 13)
            {
                txtContraseña.Focus();
            }
        }
        //VALIDA USUARIO
        //CODIGO VALIDAR CONTRASEÑA
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
            if (e.KeyChar == 13)
            {
                string Resultado = Datos.IniciarSesion(txtNombre.Text, txtContraseña.Text);
                Logueado = true;
                if (Resultado != "")
                {
                    Logueado = true;
                    MessageBox.Show("Bienvenido "+txtNombre.Text.ToUpper(),"Atencion!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado,Intente Nuevamente", "Error", MessageBoxButtons.OK);
                    txtNombre.Text = "";
                    txtContraseña.Text = "";
                    txtNombre.Focus();
                }
            }
        }
    }   
}
