using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace ClasesConexion
{
    public class CuotasADO
    {
        public static void generarCuotas(Alquiler alquiler)
        {
            SqlConnection cnn = new SqlConnection(ClasesConexion.Properties.Settings.Default.cadenaconexion);
            
            
            int nCuotas = alquiler.CantidadCuotas;
            DateTime fechaActual = alquiler.FechaAlquiler;
            cnn.Open();
            for (int i = 0; i < nCuotas; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;

                DateTime fechaPago = fechaActual.AddMonths(i);
                cmd.CommandText = "insert into Cuotas(alquiler,fechaPago,estado) ";
                cmd.CommandText += "values(@alquiler,@fechaPago,@estado)";
                cmd.Parameters.AddWithValue("@alquiler", alquiler.NroContrato);
                cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                cmd.Parameters.AddWithValue("@estado", false);
                cmd.ExecuteNonQuery();
            }    
            cnn.Close();

        }
    }
}
