using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectoresordenados
{
    class Contacto
    {
        private string nombre, aPaterno, aMaterno, email, telefono, edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APaterno
        {
            get { return aPaterno; }
            set { aPaterno = value; }
        }

        public string AMaterno
        {
            get { return aMaterno; }
            set { aMaterno = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
