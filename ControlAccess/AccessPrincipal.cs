using MODI;
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
    public partial class AccessPrincipal : Form
    {
        //SE ASIGNA VALOR NULL A FORM. 
        private static AccessPrincipal frmInstancia = null;
        public AccessPrincipal()
        {
            InitializeComponent();
        }
        //CODIGO INSTANCIA PARA ABRIR SOLO UN FORM POR MDI.
        public static AccessPrincipal Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new AccessPrincipal();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
        //CODIGO PARA ABRIR PORTON.
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            this.TimerBar.Start();
            lblPorton.Visible = true;
            lblPorton.ForeColor = System.Drawing.Color.Lime;
            lblPorton.Text = "ABIERTO";
        }
        //CODIGO PARA CERRAR PORTON.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.TimerBar.Start();
            lblPorton.Visible = true;
            lblPorton.ForeColor = System.Drawing.Color.Red;
            lblPorton.Text = "CERRADO";
        }
        //CODIGO REPORTE USUARIO NO REGISTRADO EN BASE DE DATOS.
        //SI LA CAMARA DETECTA PATENTE NO GUARDADA EN BASE DE DATOS, SE ACTIVARA BOTON REPORTE, 
        //SE GUARDARA REGISTRO DE PATENTE Y HORA DE LLEGADA(OPCIONAL CONSERJE O PERSONA A CARGO)
        private void btnReporte_Click(object sender, EventArgs e)          
        {
            {
                if (lblID.Text.Equals("No Registro"))
                {
                    
                    using (System.IO.StreamWriter Reporte = new System.IO.StreamWriter(@"C:\Users\Nicolas\Documents\ControlAccess\Reporte.txt"))
                    Reporte.WriteLine("ID " + lblID.Text + Environment.NewLine + "Nombre: " + lblNombre.Text + Environment.NewLine + "Apellido: " + lblApellido.Text + Environment.NewLine + "Domicilio: " + lblDomicilio.Text + Environment.NewLine + "Patente: " + lblPatente.Text + Environment.NewLine + "Llegada: " + lblHoraLlegada.Text + Environment.NewLine + "Salida: " + lblHoraSalida.Text + Environment.NewLine + "Imagen Vehiculo: C:/Users/Nicolas/Desktop/ProyectoFinal/PatentesControlAccess " + lblPatente.Text);
                    lblReporte.ForeColor = System.Drawing.Color.Green;
                    lblReporte.Text = "GUARDADO";
                }
                else
                {
                    MessageBox.Show("Usuario Valido ", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblReporte.ForeColor = System.Drawing.Color.Red;
                    lblReporte.Text = "ERROR";
                }
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
        }
        //CODIGO BOTON TEST RECON
        private void button1_Click(object sender, EventArgs e)
        {
            lblPatente.Text = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir Archivo";
            //open.Filter = "JPG files (*.jpg)| *.jpg | PNG files (*.png)| *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                String filename = open.FileName;
                Bitmap picture = new Bitmap(filename);
                boxImagen.Image = (System.Drawing.Image)picture;
                String nombreImagen = open.SafeFileName;

                Document variable = new Document();
                variable.Create(filename);
                variable.OCR(MODI.MiLANGUAGES.miLANG_SPANISH, true, true);
                MODI.Image image2 = (MODI.Image)variable.Images[0];
                Layout layout = image2.Layout;
                foreach (Word word in layout.Words)
                {
                    lblPatente.Text = lblPatente.Text + word.Text;
                }
            }

            string sentencia = ("SELECT * FROM Usuario WHERE Patente1 ='" + lblPatente.Text + "'or Patente2 ='" + lblPatente.Text + "'  or Patente3 ='" + lblPatente.Text + "'  or Patente_Inv1 ='" + lblPatente.Text + "'  or Patente_Inv2 ='" + lblPatente.Text + "'  or Patente_Inv3 ='" + lblPatente.Text + "'");
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format(sentencia));
            cmd.Connection = conn;
            SqlDataReader Dreader = cmd.ExecuteReader();
            if (Dreader.Read() == true)
            {
                comboPatentes.Items.Clear();
                comboInvitaciones.Items.Clear();              
                lblID.Text = Dreader["ID_Usuario"].ToString();
                lblNombre.Text = Dreader["Nombre"].ToString();
                lblApellido.Text = Dreader["Apellido"].ToString();
                lblDomicilio.Text = Dreader["Domicilio"].ToString();
                comboPatentes.Items.Add(Dreader["Patente1"].ToString());
                comboPatentes.Items.Add(Dreader["Patente2"].ToString());
                comboPatentes.Items.Add(Dreader["Patente3"].ToString());
                comboInvitaciones.Items.Add(Dreader["Patente_Inv1"].ToString());
                comboInvitaciones.Items.Add(Dreader["Patente_Inv2"].ToString());
                comboInvitaciones.Items.Add(Dreader["Patente_Inv3"].ToString());
                //lblPatente.Text = Dreader["Patente1"].ToString();
                lblHoraLlegada.Text = DateTime.Now.ToShortTimeString();
                lblPorton.Visible = true;
                lblPorton.ForeColor = System.Drawing.Color.Lime;
                lblPorton.Text = "ABIERTO";
            }
            else
            {
                comboPatentes.Items.Clear();
                comboInvitaciones.Items.Clear();
                lblID.Text = "No Registro";
                lblNombre.Text = "--";
                lblApellido.Text = "--";
                lblDomicilio.Text = "No Registro";
                lblHoraLlegada.Text = DateTime.Now.ToShortTimeString();
                lblHoraSalida.Text = "";
                lblPorton.Visible = true;
                lblPorton.ForeColor = System.Drawing.Color.Red;
                lblPorton.Text = "CERRADO";
            }
        }
        private void boxImagen_Click(object sender, EventArgs e)
        {
            
        }

        private void AccessPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetProductos.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.datasetProductos.Usuario);

        }
        //CODIGO TIMER BARRA DE PROGRESO
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bar.Minimum = 0;
            Bar.Maximum = 100;
            this.Bar.Increment(1);
            if(Bar.Value == 100)
            {
                Bar.Value = 0;
                TimerBar.Enabled = false;
            }

        }
    }
}
