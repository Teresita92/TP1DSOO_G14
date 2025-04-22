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
    internal partial class Menu : Form
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        
        public Menu()
        {
            InitializeComponent();
            /* Para crear lista nueva de libros y lectores */
            //this.libros = new List<Libro>(libros);
            //this.lectores = new List<Lector>(lectores);

            /* Métodos del menú */
            // Para libros
            //Menu.buscarLibro();
            //Menu.agregarLibro();
            //Menu.eliminarLibro();
            //Menu.listarLibros();
            //Menu.prestarLibro();

            // Para lectores
            //Menu.altaLector();
            //Menu.listarLectores();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        // Foco en Buscar Libro
        private void txtBuscarLibro_Enter(object sender, EventArgs e)
        {
            if (txtBuscarLibro.Text == "Buscar Libro...")
            {
                txtBuscarLibro.Text = "";
            }
        }

        private void txtBuscarLibro_Leave(object sender, EventArgs e)
        {
            if (txtBuscarLibro.Text == "")
            {
                txtBuscarLibro.Text = "Buscar Libro...";
            }
        }


        // Foco en Buscar Lector
        private void txtBuscarLector_Enter(object sender, EventArgs e)
        {
            if (txtBuscarLector.Text == "Buscar Lector...")
            {
                txtBuscarLector.Text = "";
            }
        }

        private void txtBuscarLector_Leave(object sender, EventArgs e)
        {
            if (txtBuscarLector.Text == "")
            {
                txtBuscarLector.Text = "Buscar Lector...";
            }
        }

        // Para cerrar la aplicación con botón "Cerrar Sesión"
        private void btnDeslog_Click(object sender, EventArgs e)
        {
            /* Para que aparezca un cuadro de diálogo por si o no */
            DialogResult resultado = MessageBox.Show
                (
                    "¿Estás seguro de que querés salir y cerrar el programa?",
                    "Seleccione una opción",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Para llamar al formulario del gestor de libros
        private void btnGestionarLibros_Click(object sender, EventArgs e)
        {
            Form libros = new Libros();
            libros.ShowDialog(); // Para llamar al formulario del gestor de libros
        }


        // Para llamar al formulario del gestor de lectores
        private void btnGestionarLector_Click(object sender, EventArgs e)
        {
            Form lectores = new Lectores();
            lectores.ShowDialog(); 
        }

    }
}
