using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cuotas
    {
        int nroContrato;

        public int NroContrato
        {
            get { return nroContrato; }
            set { nroContrato = value; }
        }
        DateTime fechaPago;

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Cuotas(int nroContrato, DateTime fechaPago, Boolean estado)
        {
            this.nroContrato = nroContrato;
            this.fechaPago = fechaPago;
            this.estado = estado;
        }

    }
}
