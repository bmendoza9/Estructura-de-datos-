using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesosColasFIFO
{
    public class Proceso
    {
        private int nombre;
        private int steps;
        private Proceso siguiente;

        public int Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Proceso(int duration, int name)
        {
            nombre = name;
            steps = duration;
        }
        public int STEPS
        {
            get { return steps; }
            set { steps = value; }
        }
        public Proceso Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public override string ToString()
        {
            return "Proceso: " + nombre + " duración: " + steps;
        }
    }
}
