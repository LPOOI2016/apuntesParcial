using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Locatario
    {
        String dni;

        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Locatario(String dni, String apellido, String nombre, String telefono)
        {
            Dni = dni;
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
        }
        public Locatario(String apellido, String nombre, String telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
        }

        public Locatario()
        {
            throw new System.NotImplementedException();
        }
    }
}
