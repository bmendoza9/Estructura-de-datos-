using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbon_binario
{
    class ArbolBinario
    {
        Nodo primero;
        Nodo ultimo;
        Nodo aux;
        string recorrido;

        public Nodo Primero()
        {
            return primero;
        }
        public string Recorrido
        {
            get { return recorrido; }
            set { recorrido = value; }
        }
        public string Mostrar()
        {
            return recorrido;
        }

        public void Agregar(Nodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }
        public void Split(string funcion)
        {
            string[] cadena = new string[20];
            cadena = funcion.Split(' ');
            for (int i = 0; i < cadena.Length; i++)
            {
                Nodo nuevo = new Nodo(Convert.ToChar(cadena[i]));
                AgregarLista(nuevo);
            }
            BinaryTree();
        }
        //notWorking :c
        public int SplitRes(string funcion)
        {
            int resultado = 0;
            string[] cadena = new string[20];
            cadena = funcion.Split(' ');
            for (int i = 0; i < cadena.Length; i++)
            {
                if (resultado == 0)
                {
                    if(cadena[i] == "0" || cadena[i] == "1" || cadena[i] == "2" || cadena[i] == "3" || cadena[i] == "4" || cadena[i] == "5" || cadena[i] == "6" || cadena[i] == "7" || cadena[i] == "8" || cadena[i] == "9")
                    {
                        resultado += Convert.ToInt32(cadena[i]);
                    }
                }
                else if(cadena[i] == "*")
                {
                }
            }
            return resultado;
        }
        public void AgregarLista(Nodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }
        private void Eliminar(Nodo dato)
        {
            if (dato != primero)
            {
                dato.Anterior.Siguiente = dato.Siguiente;
                if (dato.Siguiente != null)
                {
                    dato.Siguiente.Anterior = dato.Anterior;

                }
                else
                    ultimo = dato.Anterior;
            }
            else
            if (primero == ultimo)
                primero = ultimo = null;
            else
            {
                primero = primero.Siguiente;
                primero.Anterior = null;
            }
        }
        public void BinaryTree()
        {
            aux = primero;
            while (aux != null)
            {

                if (aux.Elemento == '/' || aux.Elemento == '*')
                {
                    aux.Izq = aux.Anterior;
                    aux.Der = aux.Siguiente;
                    Eliminar(aux.Anterior);
                    Eliminar(aux.Siguiente);

                }
                aux = aux.Siguiente;
            }
            aux = primero;
            while (aux != null)
            {
                if (aux.Elemento == '+' || aux.Elemento == '-')
                {
                    aux.Izq = aux.Anterior;
                    aux.Der = aux.Siguiente;
                    Eliminar(aux.Anterior);
                    Eliminar(aux.Siguiente);

                }
                aux = aux.Siguiente;

            }
        }

        /*
        private bool esDivMult(string elemento)
        {
            if(elemento == "/" || elemento == "*")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool esSumRes(string elemento)
        {
            if (elemento == "+" || elemento == "-")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool esNum(string elemento)
        {
            if (elemento == "0" || elemento == "1" || elemento == "2" || elemento == "3" || elemento == "4" || elemento == "5" || elemento == "6" || elemento == "7" || elemento == "8" || elemento == "9")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        public void PostOrder(Nodo primero)
        {

            if (primero != null)
            {
                PostOrder(primero.Izq);
                PostOrder(primero.Der);
                recorrido += primero.Elemento;
            }
        }

        public void PreOrder(Nodo primero)
        {
            if (primero != null)
            {

                recorrido += Convert.ToString(primero.Elemento);
                PreOrder(primero.Izq);
                PreOrder(primero.Der);
            }
        }
    }
}
