using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesosColasFIFO
{
    class Cola
    {
        Queue cola = new Queue();

        public string Procesar()
        {
            string str = "";
            int vacios = 0;
            int completados = 0;
            int pendientes = 0;
            int sumaPendientes = 0;
            Random generador = new Random();

            for(int i = 1; i <= 300; i++)
            {
                int rndnewprocess = generador.Next(1 - 100);
                if (rndnewprocess <= 35)
                {
                    cola.Enqueue();
                }
            }

            return str;
        }
    }
}
