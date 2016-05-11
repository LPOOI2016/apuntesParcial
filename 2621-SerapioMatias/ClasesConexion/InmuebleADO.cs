using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClasesBase;
namespace ClasesConexion
{
    public class InmuebleADO
    {
        public static DataTable getAll() 
        {
            DataTable dt = new DataTable();

            SqlConnection cnn = new SqlConnection(ClasesConexion.Properties.Settings.Default.cadenaconexion);
            SqlCommand command = new SqlCommand("select * from Inmuebles", cnn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public static void updateEstado(int codigo, bool estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesConexion.Properties.Settings.Default.cadenaconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update Inmuebles set estado = @estado where codInmuebles = @cod";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.Parameters.AddWithValue("@estado", estado);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
