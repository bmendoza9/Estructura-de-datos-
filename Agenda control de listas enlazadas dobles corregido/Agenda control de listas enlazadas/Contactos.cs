using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_control_de_listas_enlazadas
{
        public class Contactos
        {
            string _nombre;
            string _apellidoPaterno;
            string _apellidoMaterno;
            string _correo;
            long _telefono;
            int _edad;
            Contactos _siguiente;
            Contactos _anterior;

            public Contactos Siguiente
            {
                get { return _siguiente; }
                set { _siguiente = value; }
            }
            public Contactos Anterior
            {
                get { return _anterior; }
                set { _anterior = value; }
            }

            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }
            public string ApellidoPaterno
            {
                get { return _apellidoPaterno; }
                set { _apellidoPaterno = value; }
            }
            public string ApellidoMaterno
            {
                get { return _apellidoMaterno; }
                set { _apellidoMaterno = value; }
            }
            public string Correo
            {
                get { return _correo; }
                set { _correo = value; }
            }
            public long Telefono
            {
                get { return _telefono; }
                set { _telefono = value; }
            }
            public int Edad
            {
                get { return _edad; }
                set { _edad = value; }
            }

            public override string ToString()
            {
                return "Nombre: " + _nombre + Environment.NewLine + "Apellido parterno: " + _apellidoPaterno + Environment.NewLine + "Apellido Materno: " + _apellidoMaterno + Environment.NewLine + "Teléfono: " + Telefono + Environment.NewLine + "Correo: " + _correo + Environment.NewLine + "Edad: " + _edad + Environment.NewLine;
            }
        }
}
