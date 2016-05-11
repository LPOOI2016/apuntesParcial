using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        int nroContrato;

        public int NroContrato
        {
            get { return nroContrato; }
            set { nroContrato = value; }
        }
        String dniCliente;

        public String DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }
        int codInmueble;

        public int CodInmueble
        {
            get { return codInmueble; }
            set { codInmueble = value; }
        }
        DateTime fechaAlquiler;

        public DateTime FechaAlquiler
        {
            get { return fechaAlquiler; }
            set { fechaAlquiler = value; }
        }
        int cantidadCuotas;

        public int CantidadCuotas
        {
            get { return cantidadCuotas; }
            set { cantidadCuotas = value; }
        }

        public Alquiler(int nroContrato, String dniCliente, int codInmueble, DateTime fechaAlquiler, int cuotas)
        {
            this.nroContrato = nroContrato;
            this.dniCliente = dniCliente;
            this.codInmueble = codInmueble;
            this.fechaAlquiler = fechaAlquiler;
            this.cantidadCuotas = cuotas;
        }

        public Alquiler( String dniCliente, int codInmueble, DateTime fechaAlquiler, int cuotas)
        {
                this.dniCliente = dniCliente;
            this.codInmueble = codInmueble;
            this.fechaAlquiler = fechaAlquiler;
            this.cantidadCuotas = cuotas;
        }
        public Alquiler()
        {

        }
    }
}
