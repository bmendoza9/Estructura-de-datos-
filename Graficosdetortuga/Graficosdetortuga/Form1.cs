using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficosdetortuga
{
    public partial class Form1 : Form
    {
        Tortuga turtle = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_avanzar_Click(object sender, EventArgs e)
        {
            turtle.caminar(int.Parse(textBox_pos.Text));
        }

        private void button_derecha_Click(object sender, EventArgs e)
        {
            turtle.girarADerecha();
        }

        private void button_izquierda_Click(object sender, EventArgs e)
        {
            turtle.girarAIzquierda();
        }

        private void button_subir_Click(object sender, EventArgs e)
        {
            turtle.subirPluma();
        }

        private void button_bajar_Click(object sender, EventArgs e)
        {
            turtle.bajarPluma();
        }

        private void button_fin_Click(object sender, EventArgs e)
        {
            turtle.final();
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            textBox_tab.Text = turtle.ToString();
        }
    }
}
