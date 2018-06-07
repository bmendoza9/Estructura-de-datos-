using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesosColasFIFO
{
    class Lista
    {
        private Proceso inicio = null;

        public void agregarFinal(Proceso recibido)
        {
            if (inicio == null)
            {
                inicio = recibido;
                inicio.Siguiente = inicio;
            }
            else
            {
                Proceso aux = inicio;
                while (aux.Siguiente != inicio)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = recibido;
                aux.Siguiente.Siguiente = inicio;
            }
        }
        public Proceso eliminarInicio()
        {
            Proceso aux = inicio;
            Proceso aux2 = inicio;
            while (aux.Siguiente != inicio)
            {
                aux = aux.Siguiente;
            }
            inicio = inicio.Siguiente;
            aux.Siguiente = inicio;
            return aux2;
        }
        public string Procesar()
        {
            Random generador = new Random();
            string str = "";
            int suma = 0;
            int i = 0;
            inicio = null;
            int vacios = 0;
            int tamaño = 0;
            int completados = 0;
            do
            {     //     0    0   4   4   4   4   4
                str += "Ciclo No. " + i + " ";
                //probabilidad de generar un nuevo proceso
                int rndnew = generador.Next(1, 100);
                if (rndnew <= 35)
                {
                    agregarFinal(new Proceso(generador.Next(3, 14), tamaño));
                    tamaño++;
                }
                //restar pasos al elemento con el paso de los ciclos
                if (inicio != null)
                {
                    str += inicio.ToString() + Environment.NewLine;
                    if (inicio.STEPS > 0)
                    {
                        inicio.STEPS--;
                        inicio = inicio.Siguiente;
                    }
                    else
                    {
                        eliminarInicio();
                        completados++;
                    }
                }
                else
                {
                    str += "No hay procesos para atender" + Environment.NewLine;
                    vacios++;  
                }
                i++;
            } while (i < 300);
            Proceso aux = inicio.Siguiente;
            while (aux != inicio )
            {
                suma += aux.STEPS;
                aux = aux.Siguiente;
            }
            
            str += Environment.NewLine + "Completados: " + completados.ToString() + " Vacíos: " + vacios.ToString()
                + " Pendientes: " + (tamaño - completados).ToString() + " Suma de pendientes: " + suma.ToString();
            return str;
        }
    }
}
