using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbon_binario
{
    public partial class Form1 : Form
    {
        ArbolBinario tree = new ArbolBinario();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            tree.Split(textBox_input.Text);
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            tree.Recorrido = "";
            tree.PreOrder(tree.Primero());
            textBox_output.Text = tree.Mostrar();
        }

        private void button_post_Click(object sender, EventArgs e)
        {
            tree.Recorrido = "";
            tree.PostOrder(tree.Primero());
            textBox_output.Text = tree.Mostrar();
        }

        private void button_resolver_Click(object sender, EventArgs e)
        {
            textBox_res.Text = tree.SplitRes(textBox_output.Text).ToString();
            
        }
    }
}
