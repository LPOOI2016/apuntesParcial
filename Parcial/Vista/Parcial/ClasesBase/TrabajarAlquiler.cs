using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarAlquiler
    {
        public static string InsertAlquiler(Alquiler oAlq)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "INSERT INTO Alquiler(cliente,inmueble,fechaalquiler,cantidadcuotas) VALUES(@cliente,@inmueble,@fecha,@cantidad) SET @orden=SCOPE_IDENTITY()";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.Add("@orden", SqlDbType.Int).Direction = ParameterDirection.Output;
            oCmd.Parameters.AddWithValue("@cliente",oAlq.Cliente);
            oCmd.Parameters.AddWithValue("@inmueble",oAlq.Inmueble);
            oCmd.Parameters.AddWithValue("@fecha",oAlq.Fecha_alquiler.Date);
            oCmd.Parameters.AddWithValue("@cantidad",oAlq.Cuotas);
            try
            {
                oCnn.Open();
                sRpta = oCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (sRpta == "OK")
                {
                    sRpta = UpdateInmueble(oAlq.Inmueble, true);
                    if  (sRpta == "OK")
                    {
                        int mes,orden;
                        orden=Convert.ToInt32(oCmd.Parameters["@orden"].Value);
                        DateTime fecha = new DateTime(oAlq.Fecha_alquiler.Year, oAlq.Fecha_alquiler.Month, 1);
                        for (mes = 1; mes <= oAlq.Cuotas; mes++)
                        {
                            sRpta = InsertCuota(orden, fecha.AddMonths(mes), false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sRpta = ex.Message;
            }
            finally
            {
                if (oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }

        public static string UpdateInmueble(int nInmueble, bool bEstado)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "UPDATE Inmueble SET estado=@estado WHERE codinmueble=@id";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", nInmueble);
            oCmd.Parameters.AddWithValue("@estado", bEstado);
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
                if (oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        public static string InsertCuota(int nAlquiler, DateTime dPago, bool bEstado)
        {
            string sRpta = "";
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "INSERT INTO Cuotas(alquiler,fechapago,estado) VALUES(@alquiler,@fecha,@estado)";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@alquiler", nAlquiler);
            oCmd.Parameters.AddWithValue("@fecha", dPago);
            oCmd.Parameters.AddWithValue("@estado", bEstado);
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
                if (oCnn.State == ConnectionState.Open) oCnn.Close();
            }
            return sRpta;
        }
        public static DataTable GetContrato(int nID)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT * FROM Alquiler WHERE inmueble=@id";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", nID);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
        
        public static DataTable ListCuotas(int nInmueble)
        {
            SqlConnection oCnn = new SqlConnection(Properties.Settings.Default.parcialConnection);
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandText = "SELECT fechapago AS 'Fecha Cuota',estado AS 'Pagada' FROM Cuotas WHERE alquiler=@id AND estado=0";
            oCmd.CommandType = CommandType.Text;
            oCmd.Connection = oCnn;

            oCmd.Parameters.AddWithValue("@id", nInmueble);

            SqlDataAdapter oDA = new SqlDataAdapter(oCmd);

            DataTable oDT = new DataTable();
            oDA.Fill(oDT);

            return oDT;
        }
    }
}
