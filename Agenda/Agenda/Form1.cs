using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Agenda obj = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiarTxT()
        {
            txtTelefono.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string test =  obj.buscar(Convert.ToInt32(txtTelefono.Text));
            txtMostrar.Text = test;
            limpiarTxT();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obj.eliminar(Convert.ToInt32(txtTelefono.Text)))
                MessageBox.Show("Contacto eliminado");
            else
                MessageBox.Show("Contacto no encontrado");
            limpiarTxT();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[4];
           
            datos[0] = txtNombre.Text;
            datos[1] = txtApPaterno.Text;
            datos[2] = txtApMaterno.Text;
            datos[3] = txtCorreo.Text;

            obj.agregar(datos, Convert.ToInt32(txtTelefono.Text), Convert.ToInt32(txtEdad.Text));

            limpiarTxT();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[4];

            datos[0] = txtNombre.Text;
            datos[1] = txtApPaterno.Text;
            datos[2] = txtApMaterno.Text;
            datos[3] = txtCorreo.Text;

            obj.insertar(datos,Convert.ToInt32(txtLugar.Text), Convert.ToInt32(txtTelefono.Text), Convert.ToInt32(txtEdad.Text));

            limpiarTxT();
        }
    }
}
