using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbon_binario
{
    class Nodo
    {
        private char elemento;
        private Nodo izq;
        private Nodo der;
        private Nodo sig;
        private Nodo prev;

        public Nodo(char Elemento)
        {
            elemento = Elemento;
            izq = null;
            der = null;
            sig = null;
            prev = null;
        }
        public char Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
        public Nodo Izq
        {
            get { return izq; }
            set { izq = value; }
        }
        public Nodo Der
        {
            get { return der; }
            set { der = value; }
        }
        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public Nodo Anterior
        {
            get { return prev; }
            set { prev = value; }
        }
        public override string ToString()
        {
            return elemento.ToString();
        }
    }
}
