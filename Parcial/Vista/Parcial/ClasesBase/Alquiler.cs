using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        private int contrato_nro;

        public int Contrato_nro
        {
            get { return contrato_nro; }
            set { contrato_nro = value; }
        }
        private int cliente;

        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private int inmueble;

        public int Inmueble
        {
            get { return inmueble; }
            set { inmueble = value; }
        }
        private DateTime fecha_alquiler;

        public DateTime Fecha_alquiler
        {
            get { return fecha_alquiler; }
            set { fecha_alquiler = value; }
        }
        private int cuotas;

        public int Cuotas
        {
            get { return cuotas; }
            set { cuotas = value; }
        }

        public Alquiler()
        {
        }
    }
}
