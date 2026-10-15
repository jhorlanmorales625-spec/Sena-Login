using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginLol
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //lo que esta habilitado, se desabilita
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalir.Enabled = false;
            btnEliminar.Enabled = false;
            // lo que esta desabilitado, se habilita
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            //enviar cursor cierto lugar (ID texto) 
            txtID.Focus();
            //limpiar textos
            txtID.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //lo que esta habilitado, se desabilita
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalir.Enabled = true;
            btnEliminar.Enabled = true;
            // lo que esta desabilitado, se habilita
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            //foco
            btnNuevo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //si hay datos en los text box
            //valido que si hay datos en los text box

            if(txtID.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Algunos datos estan en vacio!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } else // Si hay datos mostrar y guardar!
            {
                MessageBox.Show("Datos Guardados!","Guardado con Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
    }
}
