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
                txtTelefono.Text = busqueda.Telefono.ToString();
                txtNombre.Text = busqueda.Nombre;
                txtApPaterno.Text = busqueda.ApellidoPaterno;
                txtApMaterno.Text = busqueda.ApellidoMaterno;
                txtCorreo.Text = busqueda.Correo;
                txtEdad.Text = busqueda.Edad.ToString();
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
                MessageBox.Show("Contacto eliminado");
            }
            else
            {
                MessageBox.Show("Contacto no encontrado");
            }
            limpiarTxT();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
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
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

            agenda.agregar(NuevoContacto);

            limpiarTxT();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Contactos editar = agenda.buscar(Convert.ToInt32(txtTelefono.Text));
            if (editar != null)
            {
                editar.Telefono = Convert.ToInt32(txtTelefono.Text);
                editar.Nombre = txtNombre.Text;
                editar.ApellidoPaterno = txtApPaterno.Text;
                editar.ApellidoMaterno = txtApMaterno.Text;
                editar.Correo = txtCorreo.Text;
                editar.Edad = Convert.ToInt32(txtEdad.Text);
            }
            else MessageBox.Show("Contacto no encontrado");
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

            //agenda.insertar(NuevoContacto,Convert.ToInt32(txtLugar.Text));

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
