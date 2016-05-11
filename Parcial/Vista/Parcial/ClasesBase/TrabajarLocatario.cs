using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarLocatario
    {
        public static DataTable ListLocatarios()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT dni,(CONVERT(varchar(10),dni)+' - '+apellido+', '+nombre) AS 'Locatario' FROM Locatario";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
    }
}
