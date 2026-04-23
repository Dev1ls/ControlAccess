using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAccess.Clases;


namespace ControlAccess
{
    public class Usuario
    {
        public int iD { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Patente1 { get; set; }
        public string Patente2 { get; set; }
        public string Patente3 { get; set; }

        public Usuario()
        {
        }
        public Usuario(int uiD, string uNombre, string uApellido, string uDomicilio, string uPatente1, string uPatente2, string uPatente3, int uTelefono)
        {
            this.iD = uiD;
            this.Nombre = uNombre;
            this.Apellido = uApellido;
            this.Domicilio = uDomicilio;
            this.Patente1 = uPatente1;
            this.Patente2 = uPatente2;
            this.Patente3 = uPatente3;
            this.Telefono = uTelefono;    
        }
    }
}