using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_control_de_listas_enlazadas
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            Contactos busqueda = agenda.buscar(Convert.ToInt32(txtTelefono.Text));
            if (busqueda != null)
            {
                txtMostrar.Text = busqueda.ToString();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el contacto");
            }
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

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            if (agenda.eliminar(Convert.ToInt32(txtTelefono.Text)))
            {
                MessageBox.Show("Se ha eliminado el contacto");
            }
            else
            {
                MessageBox.Show("No se ha podido encontrar el contacto");
            }
            limpiarTxT();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt64(txtTelefono.Text);
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

            agenda.agregar(NuevoContacto);

            limpiarTxT();
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text= agenda.listar();
            limpiarTxT();
        }
        private void button_insertar_Click(object sender, EventArgs e)
        {
            Contactos Reemplazo = new Contactos();
            Reemplazo.Telefono = Convert.ToInt64(txtTelefono.Text);
            Reemplazo.Nombre = txtNombre.Text;
            Reemplazo.ApellidoPaterno = txtApPaterno.Text;
            Reemplazo.ApellidoMaterno = txtApMaterno.Text;
            Reemplazo.Correo = txtCorreo.Text;
            Reemplazo.Edad = Convert.ToInt32(txtEdad.Text);

            agenda.insertar(Reemplazo,Convert.ToInt32(txt_pos.Text));

            limpiarTxT();
        }

        private void button_eliminarprimero_Click(object sender, EventArgs e)
        {
            agenda.eliminar_primero();
        }

        private void button_eliminarultimo_Click(object sender, EventArgs e)
        {
            agenda.eliminar_ultimo();
        }

        private void button_invertirlista_Click(object sender, EventArgs e)
        {
            agenda.invertirLista();
        }

        private void button_mostrarinverso_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = agenda.reporteInverso();
        }
    }
}
