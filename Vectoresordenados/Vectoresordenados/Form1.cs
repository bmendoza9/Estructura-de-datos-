using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectoresordenados
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtBxTelefono.Text = "";
            txtBxNombre.Text = "";
            txtBxEmail.Text = "";
            txtBxEdad.Text = "";
            txtBxAPaterno.Text = "";
            txtBxAMaterno.Text = "";
            txtBxTelBuscar.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Contacto cX = new Contacto();

            cX.Nombre = txtBxNombre.Text;
            cX.APaterno = txtBxAPaterno.Text;
            cX.AMaterno = txtBxAMaterno.Text;
            cX.Telefono = txtBxTelefono.Text;
            cX.Edad = txtBxEdad.Text;
            cX.Email = txtBxEmail.Text;

            if (agenda.contador < agenda.tamaño)
            {
                agenda.agregar(cX);
                MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Limite de Contactos Alcanzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            clear();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            agenda.eliminar(txtBxTelefono.Text);
            MessageBox.Show("Contacto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            Contacto contacto = agenda.buscar(txtBxTelBuscar.Text);

            if (agenda.buscar(txtBxTelBuscar.Text) == null)
            {
                MessageBox.Show("Contacto No Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                txtBxNombre.Text = contacto.Nombre;
                txtBxAPaterno.Text = contacto.APaterno;
                txtBxAMaterno.Text = contacto.AMaterno;
                txtBxTelefono.Text = contacto.Telefono;
                txtBxEdad.Text = contacto.Edad;
                txtBxEmail.Text = contacto.Email;
                MessageBox.Show("Contacto Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = agenda.listar();
        }
    }
}
