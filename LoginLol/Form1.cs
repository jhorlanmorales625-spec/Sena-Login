namespace LoginLol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin234")
            {
                // creo una instanci del formulario menu
                FrmMenuPrincipal f = new FrmMenuPrincipal();
                this.Hide();
                //muestro el formulario de instancial
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Creedenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult rpta = new DialogResult();
            //DESEA SALIR?
             rpta = MessageBox.Show("Desea Salir", "Notificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rpta == DialogResult.OK)
            {
                //SALIR DE LA APP
                Application.Exit();
            }

            
        }
    }
}
