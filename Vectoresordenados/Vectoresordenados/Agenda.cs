using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectoresordenados
{
    class Agenda
    {
        public int tamaño = 4;
        private Contacto[] agenda = new Contacto[5];
        public int contador = 0;

        public void agregar(Contacto conti)
        {
            bool encontrado = false;

            if (contador == 0)
            {
                agenda[contador] = conti;
                contador++;
            }
            else
            {
                for (int x = contador - 1; x >= 0 || encontrado != true; x--)
                    if (int.Parse(conti.Telefono) > int.Parse(agenda[x].Telefono))
                    {
                        for (int y = contador; y > x + 1; y--)
                        {
                            agenda[y] = agenda[y - 1];
                        }
                        agenda[x + 1] = conti;
                        encontrado = true;
                    }
                contador++;
            }
        }

        public Contacto buscar(string telefono)
        {
            bool flag = false;
            for (int x = 0; x < tamaño || flag != true; x++)
            {
                if (int.Parse(telefono) >= int.Parse(agenda[x].Telefono))
                {
                    if (agenda[x].Telefono == telefono) return agenda[x];
                }
                else
                    flag = true;
            }
            return null;
        }

        public void eliminar(string telefono)
        {
            bool flag = false;
            for (int x = 0; x < tamaño || flag != true; x++)
            {
                if (int.Parse(telefono) >= int.Parse(agenda[x].Telefono))
                {
                    if (agenda[x].Telefono == telefono)
                        for (int y = x; y < contador - 1; y++) agenda[y] = agenda[y + 1];
                }
                else
                    flag = true;
            }
            agenda[contador - 1] = null;
            contador--;
        }

        public string listar()
        {
            string cadena = "";
            for (int x = 0; x < contador; x++)
            {
                cadena += agenda[x].Nombre + " " + agenda[x].APaterno + " " + agenda[x].AMaterno + " , " + agenda[x].Telefono + " , " + agenda[x].Edad + " , " + agenda[x].Email + Environment.NewLine;
            }

            return cadena;
        }
    }
}
