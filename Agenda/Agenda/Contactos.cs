﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contactos
    {
        private
        string _nombre;
        string _apPaterno;
        string _apMaterno;
        string _correo;
        long _telefono;
        int _edad;


        public string Nombre{
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string ApellidoPaterno{
            get { return _apPaterno; }
            set { _apPaterno = value; }
        }
        public string ApellidoMaterno{
            get { return _apMaterno; }
            set { _apMaterno = value; }
        }
        public string Correo{
            get { return _correo; }
            set { _correo = value; }    
        }
        public long Telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public int Edad {
            get { return _edad; }
            set { _edad = value; }
        }
    }
}
