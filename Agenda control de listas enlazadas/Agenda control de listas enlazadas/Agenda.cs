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

        public void eliminar_primero()
        {
            inicio = inicio.Siguiente;
        }
        public void eliminar_ultimo()
        {
            Contactos aux = inicio;
            while(aux.Siguiente.Siguiente != null)
            {
                aux = aux.Siguiente;
            }
            aux.Siguiente = null;

        }
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
        public void agregar(Contactos nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {

                Contactos aux = inicio;
                while (aux.Siguiente != null)
                    aux = aux.Siguiente;
                aux.Siguiente = nuevo;
            }
        }

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

        public bool eliminar(long tel)
        {
            Contactos aux = inicio;
            while (aux.Siguiente != null)
                if (aux.Siguiente.Telefono == tel)
                {
                    aux.Siguiente = aux.Siguiente.Siguiente;
                    return true;
                }
            return false;
        }

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
        public void insertar(Contactos reemplazo, int pos)
        {
            Contactos aux = inicio;
            for(int i =1; i < pos; i++)
            {
                aux = aux.Siguiente;
            }
            aux.Nombre = reemplazo.Nombre;
            aux.ApellidoPaterno = reemplazo.ApellidoPaterno;
            aux.ApellidoMaterno = reemplazo.ApellidoMaterno;
            aux.Telefono = reemplazo.Telefono;
            aux.Correo = reemplazo.Correo;
            aux.Edad = reemplazo.Edad;
        }
    }
}
