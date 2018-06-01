using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace procesosColasFIFO
{
    public partial class Form1 : Form
    {
        Proceso inicio;
        int tamaño = 0;
        Random generador = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public Proceso pop()
        {
            Proceso aux = inicio;
            inicio = inicio.Siguiente;
            return aux;
        }
        public void queue(Proceso recibido)
        {
            if (inicio == null)
            {
                inicio = recibido;
            }
            else
            {
                queue(recibido, inicio);
            }
        }
        private void queue(Proceso n, Proceso aux)
        {
            if (aux.Siguiente != null)
            {
                queue(n, aux.Siguiente);
            }
            else
            {
                aux.Siguiente = n;
            }
        }
        private void button_comenzar_Click(object sender, EventArgs e)
        {
            string str = "";
            int suma = 0;
            int i = 0;
            inicio = null;
            int vacios = 0;
            int completados = 0;
            do
            {
                str += "Ciclo No. " + i + " ";
                //probabilidad de generar nuevo proceso
                int rndnew = generador.Next(1, 100);
                if (rndnew <= 35)
                {
                    queue(new Proceso(generador.Next(3, 14),tamaño));
                    tamaño++;
                }
                //para restar pasos al elemento con el paso de los ciclos
                if (inicio != null)
                {
                    str += inicio.ToString() + Environment.NewLine;
                    if (inicio.STEPS > 0)
                    {
                        inicio.STEPS--;
                    }
                    else
                    {
                        pop();
                        completados++;
                    }
                }
                else
                {
                    vacios++;
                }
                i++;
            } while (i < 300);
            while (inicio != null)
            {
                Proceso _pop = pop();
                suma += _pop.STEPS;
            }
            str += Environment.NewLine + "Completados: " + completados.ToString() + " Vacíos: " + vacios.ToString()
                + " Pendientes: " + (tamaño - completados).ToString() + " Suma de pendientes: "+ suma.ToString();

            textBox1.Text = str;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
