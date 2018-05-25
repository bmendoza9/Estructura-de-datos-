using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_control_de_listas_enlazadas
{
        class Agenda
        {
            private Contactos inicio;
            private Contactos ultimo;

        //sin cambios
        public void eliminar_primero()
        {
            inicio = inicio.Siguiente;
        }
        //sin cambios
        public void eliminar_ultimo()
        {
            Contactos aux = inicio;
            while(aux.Siguiente.Siguiente != null)
            {
                aux = aux.Siguiente;
            }
            aux.Siguiente = null;

        }
        //sin cambios
        public void invertirLista()
        {
            Contactos aux = inicio;
            Contactos _sigiente;
            while (aux.Siguiente != null)
            {
                _sigiente = aux.Siguiente;
                ultimo = _sigiente.Siguiente;
                _sigiente.Siguiente = inicio;
                aux.Siguiente = ultimo;
                inicio = _sigiente;
            }
        }
        //sin cambios
        public string reporteInverso()
        {
            string str = "";
            int contador = 0;
            Contactos aux2 = inicio;
            
            while(aux2 != null)
            {
                contador++;
                aux2 = aux2.Siguiente;
            }

            Contactos aux;
            Contactos _ultimo = null;
            for (int i = 1; i <= contador; i++)
            {
                aux = inicio;
                while (aux.Siguiente != _ultimo)
                {
                    aux = aux.Siguiente;
                }
                _ultimo = aux;
                str += aux.ToString();
            }
            return str;
        }
        //cambiar
        public void agregar(Contactos nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                //inicio = "contacto"
                //aux = "pos"
                Contactos aux = inicio;
                bool agregado = false;
                while (!agregado)
                {
                    if (String.Compare(nuevo.Nombre, aux.Nombre, true) <= 0)
                    {
                        if (aux.Anterior == null)
                        {
                            nuevo.Siguiente = inicio;
                            aux.Anterior = nuevo;
                            inicio = nuevo;
                            agregado = true;
                        }
                        else
                        {
                            nuevo.Anterior = aux.Anterior;
                            nuevo.Siguiente = aux;
                            nuevo.Anterior.Siguiente = nuevo;
                            aux.Anterior = nuevo;
                            agregado = true;
                        }

                    }
                    else if(aux.Siguiente == null)
                    {
                        aux.Siguiente = nuevo;
                        nuevo.Anterior = aux;
                        agregado = true;
                    }
                    aux = aux.Siguiente;
                }              


            }
        }
        //sin cambios
        public Contactos buscar(long tel)
        {
            Contactos aux = inicio;
            while(aux != null)
            {
                if(aux.Telefono == tel)
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }
        //cambiar
        public bool eliminar(long tel)
        {
            Contactos aux = buscar(tel);
            if (aux != null)
            {
                if (aux.Anterior == null && aux.Siguiente == null)
                {
                    inicio = null;
                    return false;
                }
                else if (aux.Anterior == null && aux.Siguiente != null)
                {
                    aux.Siguiente.Anterior = null;
                    inicio = aux.Siguiente;
                    return false;
                }
                else if (aux.Anterior != null && aux.Siguiente == null)
                {
                    aux.Anterior.Siguiente = null;
                    return false;
                }
                else
                {
                    aux.Anterior.Siguiente = aux.Siguiente;
                    aux.Siguiente.Anterior = aux.Anterior;
                    return false;
                }
            }
            return true;
        }
        //sin cambios
        public string listar()
        {
            string str = "";
            Contactos aux = inicio;
            while(aux != null)
            {
                str += aux.ToString();
                aux = aux.Siguiente;
            }
            return str;
        }
    }
}
