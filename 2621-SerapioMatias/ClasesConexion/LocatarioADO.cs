using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;
using System.Data.SqlClient;
namespace ClasesConexion
{
    public class LocatarioADO
    {
        public static DataTable getLocatarios()
        {
            DataTable dt = new DataTable();

            SqlConnection cnn = new SqlConnection(ClasesConexion.Properties.Settings.Default.cadenaconexion);
            SqlCommand command= new SqlCommand("select * from Locatarios", cnn);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
    }
}
