using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricesclase
{
    class Matriz
    {
        int[,] _matriz = new int[6, 6];
        Random num = new Random();


        public void Llenar()
        {
            int contador = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    _matriz[i, j] = contador++;
                }
            }
        }
        public void LlenarPorColumnas()
        {
            int contador = 1;
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    _matriz[i, j] = contador++;
                }
            }
        }
        public string Mostrar()
        {
            string str = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    str += _matriz[i, j] + ", ";
                }
                str += Environment.NewLine;
            }
            return str;
        }
        public void LlenarInverso()
        {
            int contador = 36;
            for(int i =0;i<6;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    _matriz[i, j] = contador--;
                }
            }
        }
        public string MostrarDP()
        {
            string str = "";
            for(int i = 0; i < 6; i++)
            {
                str += _matriz[i, i] + ", ";
            }
            return str;
        }
        public string MostrarDS()
        {
            string str = "";
            for (int i = 0, j = 5; i < 6 && j >= 0; i++, j--)
            {
                str += _matriz[i, j] + ", ";
            }
            return str;
        }
        public string MostrarAbajoDP()
        {
            string str = "";
            for (int i = 0; i < 6; i++)
            {
                for (int x = i + 1; x < 6; x++)
                {
                    str += _matriz[x, i] + ", ";
                }

            }
            return str;
        }
        public string MostrarAbajoDS()
        {
            string str = "";
            int x = 5;
           for(int i = 1; i <= 5; i++)
            {
                for(int j = x; j <= 5; j++)
                {
                    str += _matriz[i, j] + ", ";
                }
                x--;
            }
            return str;
        }
        public void GirarDP()
        {
            int temp = 0;
            int contador = 0;

            for(int i = 1; i < 6; i++)
            {
                contador++;
                for(int j =0; j <= contador; j++)
                {
                    temp = _matriz[i, j];
                    _matriz[i, j] = _matriz[j, i];
                    _matriz[j, i] = temp;
                }
            }
           
        }
        public void girarDS()
        {
            int temp = 0;
            int contador = 0;

            for (int i=0; i < 5; i++)
            {
                contador++;
                for(int j = 0; j < 4; j++)
                {
                    int i2 = ((5 - j) - 1);
                    int j2 = ((5 - i) - 1);
                    temp = _matriz[i, j];
                    _matriz[i, j] = _matriz[j2, i2];
                    _matriz[j2, i2] = temp;
                }
            }
        }
    }
}
