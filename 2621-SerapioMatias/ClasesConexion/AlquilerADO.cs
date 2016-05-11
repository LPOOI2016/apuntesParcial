using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace ClasesConexion
{
    public class AlquilerADO
    {
        public static int insert(Alquiler alquiler)
        {
            SqlConnection cnn = new SqlConnection(ClasesConexion.Properties.Settings.Default.cadenaconexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Alquileres(cliente,inmueble,fechaAlquiler,cantCuotas) Values(@cliente,@inmueble,@fechaAlquiler,@cantCuotas);SELECT SCOPE_IDENTITY()";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cliente", alquiler.DniCliente);
            cmd.Parameters.AddWithValue("@inmueble", alquiler.CodInmueble);
            cmd.Parameters.AddWithValue("@fechaAlquiler", alquiler.FechaAlquiler);
            cmd.Parameters.AddWithValue("@cantCuotas",alquiler.CantidadCuotas);
            cnn.Open();
            Object ultimo = cmd.ExecuteScalar();
            int id =Int32.Parse(ultimo.ToString());
            cnn.Close();
            return id;
        }
    }
}
