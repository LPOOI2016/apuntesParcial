using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClasesBase;

namespace ClaseConexion
{
    public class TrabajarOrden
    {
        

        public static void insertOrden(Orden_Compra ordenCompra)
        {
            Orden_Compra OrdenADO = new Orden_Compra();

            OrdenADO.InsertOrden(ordenCompra);
        }

        public static DataTable ViewOrden()
        {
            return new Orden_Compra().ListOrden();
        }
        public static DataTable ViewItem(int nID)
        {
            Item_Orden_Compra Obj = new Item_Orden_Compra();
            Obj.Art_ID = nID;
            return new Orden_Compra().ListItem(Obj);
        }

        public static int getUltimoId()
        {
            Orden_Compra ordenCompra = new Orden_Compra();

            return ordenCompra.getUltimoId();
        }
    }
}
