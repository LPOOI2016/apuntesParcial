using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class Usuario
    {
        private int usr_Id;
        private string usr_Nombre;
        private string usr_Apellido;
        private string usr_Email;
        private string usr_UserName;
        private string usr_Password;
        private int rol_Id;
        private string txt_Buscar;
        
        //Getters and Setters
        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        public string Usr_Nombre
        {
            get { return usr_Nombre; }
            set { usr_Nombre = value; }
        }
        public string Usr_Apellido
        {
            get { return usr_Apellido; }
            set { usr_Apellido = value; }
        }
        public string Usr_Email
        {
            get { return usr_Email; }
            set { usr_Email = value; }
        }
        public string Usr_UserName
        {
            get { return usr_UserName; }
            set { usr_UserName = value; }
        }
        public string Usr_Password
        {
            get { return usr_Password; }
            set { usr_Password = value; }
        }
        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
        public string Txt_Buscar
        {
            get { return txt_Buscar; }
            set { txt_Buscar = value; }
        }

        //Constructors
        public Usuario()
        {
        }
        public Usuario(int nUsrID,string sName, string sApe,string sMail,string sUsrName,string sPass, int nRol, string sBuscar)
        {
            Usr_Id = nUsrID;
            Usr_Nombre = sName;
            Usr_Apellido = sApe;
            Usr_Email = sMail;
            Usr_UserName = sUsrName;
            Usr_Password = sPass;
            Rol_Id = nRol;
            Txt_Buscar = sBuscar;
        }

        //Login
        public DataTable ValidUser(Usuario oUser)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT usr_id,usr_apellido,usr_nombre,rol_id FROM Usuario";
            oCmd.CommandText += " WHERE";
            oCmd.CommandText += " usr_username=@username AND usr_password=@password";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@username", oUser.Usr_UserName);
            oCmd.Parameters.AddWithValue("@password", oUser.Usr_Password);

            DataTable oDT = new DataTable();
            try
            {
                SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
                oDA.Fill(oDT);
            }
            catch
            {
                oDT = null;
            }
            return oDT;
        }

        //Insert
        public string InsertUser(Usuario oUser)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
                oCmd.CommandText = "INSERT INTO Usuario(rol_id,usr_apellido,usr_nombre,usr_username,usr_password,usr_email) values(@rol,@ape,@nom,@usu,@pass,@email)";
                oCmd.CommandType = CommandType.Text;
                oCmd.Connection = oCnn;

                oCmd.Parameters.AddWithValue("@rol", oUser.Rol_Id);
                oCmd.Parameters.AddWithValue("@ape", oUser.Usr_Apellido);
                oCmd.Parameters.AddWithValue("@nom", oUser.Usr_Nombre);
                oCmd.Parameters.AddWithValue("@email", oUser.Usr_Email);
                oCmd.Parameters.AddWithValue("@usu", oUser.Usr_UserName);
                oCmd.Parameters.AddWithValue("@pass", oUser.Usr_Password);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if(oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        //Update
        public string UpdateUser(Usuario oUser)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            
                oCmd.CommandText = "UPDATE Usuario";
                oCmd.CommandText += " SET usr_nombre = @nombre, usr_apellido = @apellido, usr_username = @username, usr_password = @password, usr_email = @email, rol_id = @rol";
                oCmd.CommandText += " WHERE usr_id = @id";
                oCmd.CommandType = CommandType.Text;
                oCmd.Connection = oCnn;

                oCmd.Parameters.AddWithValue("@nombre", oUser.Usr_Nombre);
                oCmd.Parameters.AddWithValue("@apellido", oUser.Usr_Apellido);
                oCmd.Parameters.AddWithValue("@username", oUser.Usr_UserName);
                oCmd.Parameters.AddWithValue("@password", oUser.Usr_Password);
                oCmd.Parameters.AddWithValue("@email", oUser.Usr_Email);
                oCmd.Parameters.AddWithValue("@rol", oUser.Rol_Id);
                oCmd.Parameters.AddWithValue("@id", oUser.Usr_Id);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1? "OK":"NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if(oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        //Delete
        public string DeleteUser(Usuario oUser)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "DELETE FROM Usuario";
            oCmd.CommandText += " WHERE usr_id = @id";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", oUser.Usr_Id);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1?"OK":"NO se Elimino el Registro";
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if(oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        //Search
        public DataTable SearchUsers(Usuario oUser)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "usr_id, rol_descrip as 'Rol', ";
            oCmd.CommandText += "usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            oCmd.CommandText += "usr_username as 'Usuario', usr_password as 'Contraseña', ";
            oCmd.CommandText += "usr_email as 'Email'";
            oCmd.CommandText += "FROM Usuario as U";
            oCmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id) ";

            oCmd.CommandText += "WHERE ";
            oCmd.CommandText += "usr_apellido LIKE @pattern OR usr_nombre LIKE @pattern";

            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@pattern", "%" + oUser.Txt_Buscar + "%");

            DataTable oDT = new DataTable();
            try
            {
                SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
                oDA.Fill(oDT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                oDT = null;
            }
            return oDT;
        }
        //Obtener Listas
        public DataTable ListRols()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT * FROM roles";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        public DataTable ListUsers()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT ";
            oCmd.CommandText += "usr_id, rol_descrip as 'Rol', ";
            oCmd.CommandText += "usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            oCmd.CommandText += "usr_username as 'Usuario', usr_password as 'Contraseña', ";
            oCmd.CommandText += "usr_email as 'Email'";
            oCmd.CommandText += "FROM Usuario as U";
            oCmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }

        public static bool noUltimo()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.pasteleriaConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT * FROM Usuario";
            oCmd.CommandText += " WHERE rol_id = 1";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);
            DataTable oDT = new DataTable();

            oDA.Fill(oDT);

            bool bLastAdmin = false;
            if (oDT.Rows.Count > 1)
            {
                bLastAdmin = true;
            }

            return bLastAdmin;
        }
    }
}
