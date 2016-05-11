using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Inmueble
    {
        int codigoInmueble;

        public int CodigoInmueble
        {
            get { return codigoInmueble; }
            set { codigoInmueble = value; }
        }
        String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        String barrio;

        public String Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Inmueble(int codigo,string direccion,String barrio,bool estado)
        {
            this.codigoInmueble = codigo;
            this.direccion = direccion;
            this.barrio = barrio;
            this.estado = estado;
        }
    }
}
