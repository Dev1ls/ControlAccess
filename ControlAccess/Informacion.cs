using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAccess
{
    public partial class Informacion : Form
    {
        private static Informacion frmInstancia = null;
        public Informacion()
        {
            InitializeComponent();
        }
        //CODIGO INSTANCIA PARA ABRIR SOLO UN FORM POR MDI.
        public static Informacion Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new Informacion();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }
        //CODIGO INFORMACION.
        private void Info_Load(object sender, EventArgs e)
        {
            lbl1.Text = "Informacion de Contacto";
            lbl2.Text = "Bla Bla Bla";
            lbl3.Text = "Bla Bla";
            lbl4.Text = "Correo@gmail.com";
            lbl5.Text = "Version";
            lbl6.Text = "0.5.";
            lbl7.Text = "ID Programa";
            lbl8.Text = "xx-xx-xx";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
