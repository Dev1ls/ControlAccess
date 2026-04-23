using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControlAccess.Clases;


namespace ControlAccess.Clases
{
    class Datos
    {
        static SqlConnection Conexion = new SqlConnection();
        public static void IniciarConexion()
        {
            Conexion.ConnectionString = (@"Data Source=.\SQLEXPRESS; Initial Catalog=ControlAccess; Integrated Security=Yes");
            Conexion.Open();
        }
        public static void CerrarConexion()
        {
            Conexion.Close();
        }
        public static string IniciarSesion(string User, string Pass)
        {
            int Log = 0;
            string Mensaje = "";
            IniciarConexion();
            SqlCommand Command = new SqlCommand();
            Command.CommandText = "Registros";
            Command.Connection = Conexion;
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.Add(new SqlParameter("@User", User));
            Command.Parameters.Add(new SqlParameter("@Pass", Pass));

            SqlParameter Plog = new SqlParameter("@Log", 0);
            Plog.Direction = ParameterDirection.Output;
            Command.Parameters.Add(Plog);

            SqlParameter Pmensaje = new SqlParameter("@Mensaje",SqlDbType.VarChar);
            Pmensaje.Direction = ParameterDirection.Output;
            Pmensaje.Size = 40;
            Command.Parameters.Add(Pmensaje);

            Command.ExecuteNonQuery();
            CerrarConexion();
            Log = Int32.Parse(Command.Parameters["@Log"].Value.ToString());
            if (Log >0)
            {
                Mensaje = Command.Parameters["@Mensaje"].Value.ToString();
                return Mensaje;
            }
            else
            {
                return Mensaje; 
            }
        }    
    }
}
