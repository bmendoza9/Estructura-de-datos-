using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricesclase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Matriz mat = new Matriz();

        private void button_llenar_Click(object sender, EventArgs e)
        {
            mat.Llenar();
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = mat.Mostrar();
        }

        private void button_llenarinv_Click(object sender, EventArgs e)
        {
            mat.LlenarInverso();
        }

        private void button_llenarcol_Click(object sender, EventArgs e)
        {
            mat.LlenarPorColumnas();
        }

        private void button_mostrarDS_Click(object sender, EventArgs e)
        {
            textBox1.Text = mat.MostrarDS();
        }

        private void button_mostrarDP_Click(object sender, EventArgs e)
        {
            textBox1.Text = mat.MostrarDP();
        }

        private void button_abajoDP_Click(object sender, EventArgs e)
        {
            textBox1.Text = mat.MostrarAbajoDP();
        }

        private void button_abajoDS_Click(object sender, EventArgs e)
        {
            textBox1.Text = mat.MostrarAbajoDS();
        }

        private void button_intercambiar_Click(object sender, EventArgs e)
        {
            mat.GirarDP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mat.girarDS();
        }
    }
}
