using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private Contactos[] agenda = new Contactos[15];
        private int pos=0;
        
        
        public void agregar(string[] datos, long tel, int edad)
        {
           
            agenda[pos] = new Contactos(); // creando obj

            agenda[pos].Nombre = datos[0];
            agenda[pos].ApellidoPaterno = datos[1];
            agenda[pos].ApellidoMaterno = datos[2];
            agenda[pos].Correo = datos[3];
            agenda[pos].Telefono = tel;
            agenda[pos].Edad = edad;
            pos++;
        }

        public void insertar(string[] datos, int lugar, int tel, int edad)
        {
            if (lugar == 0)
            {
                agenda[lugar] = new Contactos();
            }
            else
            {
                if (pos > lugar)
                {
                    agenda[lugar] = new Contactos();
                }
            }
                
            
           // agenda[lugar] = new Contactos();
            if (agenda[lugar].Nombre != " "){
                if (pos==0)
                {
                    agenda[lugar].Nombre = datos[0];
                    agenda[lugar].ApellidoPaterno = datos[1];
                    agenda[lugar].ApellidoMaterno = datos[2];
                    agenda[lugar].Correo = datos[3];
                    agenda[lugar].Telefono = tel;
                    agenda[lugar].Edad = edad;
                }
                else
                {
                    for (int i = pos++; i >= lugar; i--)
                    {
                        agenda[i] = agenda[i - 1];
                    }

                    agenda[lugar].Nombre = datos[0];
                    agenda[lugar].ApellidoPaterno = datos[1];
                    agenda[lugar].ApellidoMaterno = datos[2];
                    agenda[lugar].Correo = datos[3];
                    agenda[lugar].Telefono = tel;
                    agenda[lugar].Edad = edad;
                }
                
            }
        }
        public string buscar(long tel)
        {
            string str = "";
            for (int i = 0; i <= pos; i++)
                if (agenda[i].Telefono == tel)
                {
                    str += agenda[i].Telefono + Environment.NewLine;
                    str += agenda[i].Nombre + Environment.NewLine;
                    str += agenda[i].ApellidoPaterno + Environment.NewLine;
                    str += agenda[i].ApellidoMaterno + Environment.NewLine;
                    str += agenda[i].Edad + Environment.NewLine;
                    str += agenda[i].Correo + Environment.NewLine;
                }
            return str;
        }

        public bool eliminar(int tel)
        {
            bool estado = false;
            for (int i = 0; i <= pos; i++)
                if (agenda[i].Telefono == tel)
                {
                    agenda[i].Telefono = 0;
                    agenda[i].Nombre="";
                    agenda[i].ApellidoPaterno="";
                    agenda[i].ApellidoMaterno="";
                    agenda[i].Edad=0;
                    agenda[i].Correo="";
                    estado = true;
                }
            return estado;
        }    

        public string listar()
        {

            return " ";
        }
    }
}
