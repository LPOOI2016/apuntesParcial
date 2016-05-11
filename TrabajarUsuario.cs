using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data ;
using System.Data.SqlClient ;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static DataTable list_roles() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static void insert_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(rol_id,usr_apellido,usr_nombre,usr_email,usr_username,usr_password) values(@rol,@ape,@nom,@email,@usu,@pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Id);
            cmd.Parameters.AddWithValue("@ape", user.Usr_Apellido);
            cmd.Parameters.AddWithValue("@nom", user.Usr_Nombre);
            cmd.Parameters.AddWithValue("@email", user.Usr_Email);
            cmd.Parameters.AddWithValue("@usu", user.Usr_UserName);
            cmd.Parameters.AddWithValue("@pass", user.Usr_Password);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_usuarios()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " usr_email as 'Email', usr_id, U.rol_id ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " usr_email as 'Email', usr_id, U.rol_id ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usr_apellido LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
