using MiBiblioteca.Models;

namespace MiBiblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Para llamar al formulario del Menú principal
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (User.Validar(usuario, password))
            {
                Form menu = new Menu();
                menu.Show();
                this.Hide(); // Ocultás el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Foco en Ingrese usuario
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Ingrese usuario...")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Ingrese usuario...";
            }
        }


        // Foco en contraseña
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Ingrese contraseña...")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Ingrese contraseña...";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
