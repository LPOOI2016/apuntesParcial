using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarInmueble
    {
        public static DataTable ListInmueble()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT codinmueble,(direccion+' - '+barrio) AS 'Inmueble' FROM Inmueble WHERE estado=0";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }

        public static DataTable ListInmuebles()
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT codinmueble,(direccion+' - '+barrio) AS 'Inmueble' FROM Inmueble WHERE estado=1";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
    }
}
