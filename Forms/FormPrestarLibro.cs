using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBiblioteca
{
    public partial class FormPrestarLibro : Form
    {
        public string TituloIngresado => txtTitulo.Text.Trim();
        public string DniIngresado => txtDni.Text.Trim();

        public FormPrestarLibro()
        {
            InitializeComponent();
            this.Text = "Préstamo de Libro";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor complete ambos campos.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormPrestarLibro_Load(object sender, EventArgs e)
        {

        }
    }

}
