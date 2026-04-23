using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAccess.Clases;
namespace ControlAccess.Clases
{
    class CRUD
    {
        public static int Agregar(Usuario uUsuario)
        {
            //Datos.IniciarConexion();
            int Retorno = 0;
            SqlConnection conn = new SqlConnection();           
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            SqlCommand Command = new SqlCommand(string.Format("INSERT into Usuario(Nombre,Apellido,Domicilio,Patente1,Patente2,Patente3) VALUES ('" + uUsuario.Nombre + "','" + uUsuario.Apellido + "','" + uUsuario.Domicilio + "','" + uUsuario.Patente1 + "','" + uUsuario.Patente2 + "','" + uUsuario.Patente3 + "')"),conn);
            //ASIGNAR CONEXION A COMMAND         
            Command.Connection = conn;
            Retorno = Command.ExecuteNonQuery();
            //conn.Close();
            return Retorno;
        }
        public static int Modificar(Usuario uUsuario)
        {
            //Datos.IniciarConexion();
            int Retorno = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            SqlCommand Command = new SqlCommand(string.Format("UPDATE Usuario set Nombre='"+uUsuario.Nombre+"',Apellido='"+uUsuario.Apellido+"',Domicilio='"+uUsuario.Domicilio+ "',Patente1='"+uUsuario.Patente1+ "',Patente2='"+uUsuario.Patente2+ "',Patente3='"+uUsuario.Patente3+ "' WHERE ID_Usuario='"+uUsuario.iD+"'"),conn);
            //ASIGNAR CONEXION A COMMAND
            Command.Connection = conn;
            Retorno = Command.ExecuteNonQuery();
            //conn.Close();
            return Retorno;
        }
        public static int Eliminar(Usuario uUsuario)
        {
            //Datos.IniciarConexion();
            int Retorno = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            conn.Open();
            SqlCommand Command = new SqlCommand(string.Format("DELETE from Usuario WHERE ID_Usuario='" + uUsuario.iD + "' "),conn);
            //ASIGNAR CONEXION A COMMAND
            Command.Connection = conn;
            Retorno = Command.ExecuteNonQuery();
            //conn.Close();
            return Retorno;
        }
    }   
}