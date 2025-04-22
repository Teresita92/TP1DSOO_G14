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
            Form menu = new Menu();
            menu.ShowDialog(); 

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

    }
}
