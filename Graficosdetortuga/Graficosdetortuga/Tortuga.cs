using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficosdetortuga
{
    class Tortuga
    {
        private int[,] tab = new int[20, 20];
        bool trazo;
        int x = 0;
        int y = 0;
        int direccion = 0;

        public Tortuga()
        {
            trazo = false;
            direccion = 2;
            x = 0;
            y = 0;
        }

        public void subirPluma()
        {
            trazo = false;
        }

        public void bajarPluma()
        {
            tab[x, y] = 1;
            trazo = false;
        }

        public void caminar(int q)
        {
            if (direccion == 2 && (y + q) <= 19)
            {
                if (trazo == true)
                {
                    for (int z = y; z <= (y + q); z++)
                    {
                        tab[x, z] = 1;
                        y += q;
                    }
                }
            }

            if (direccion == 1 && (x - q) >= 0)
            {
                if (trazo == true)
                {
                    for (int z = x; z >= (x - q); z--)
                    {
                        tab[z, y] = 1;
                        x -= q;
                    }

                }
            }

            if (direccion == 3 && (x + q) <= 19)
            {
                if (trazo == true)
                    for (int z = x; z <= (x + q); z++) tab[z, y] = 1;
                x += q;
            }

            if (direccion == 4 && (y - q) >= 0)
            {
                if (trazo == true)
                    for (int z = y; z >= (y - q); z--) tab[x, z] = 1;
                y -= q;
            }
        }

        public void final()
        {
            for(int a = 0; a < 20; a++)
            {
                for(int b = 0; b < 20; b++)
                {
                    tab[a, b] = 0;
                }
            }
        }
        public void girarADerecha()
        {
            if (direccion == 1) direccion = 2;
            else if (direccion == 2) direccion = 3;
            else if (direccion == 3) direccion = 4;
            else direccion = 1;
        }

        public void girarAIzquierda()
        {
            if (direccion == 1) direccion = 4;
            else if (direccion == 4) direccion = 3;
            else if (direccion == 3) direccion = 2;
            else direccion = 1;
        }
        public override string ToString()
        {
            string str = "";
            for(int a = 0; a < 20; a++)
            {
                for(int b = 0; b < 20; b++)
                {
                    if(tab[a,b] == 1)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += "";
                    }
                    if (b == 19)
                    {
                        str += Environment.NewLine;
                    }
                    else
                    {
                        str += " , ";
                    }
                }
            }
                return str;
        }
    }
}
