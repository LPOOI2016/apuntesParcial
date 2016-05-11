using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Inmueble
    {
        private int inmueble_id;


        public int Inmueble_id
        {
            get { return inmueble_id; }
            set { inmueble_id = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string barrio;

        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Inmueble()
        {
        }

    }
}
