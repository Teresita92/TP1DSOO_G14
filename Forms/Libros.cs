using System.Net;
using MiBiblioteca.Models;

namespace MiBiblioteca
{
    public partial class Libros : Form
    {
        private Biblioteca biblioteca;

        public Libros(Biblioteca bibliotecaExistente)
        {
            InitializeComponent();
            this.biblioteca = bibliotecaExistente;

            // “Enlazamos” cada columna al nombre de la propiedad de Libro
            nombreLibro.DataPropertyName = "Titulo";
            autorLibro.DataPropertyName = "Autor";
            editorialLibro.DataPropertyName = "Editorial";

            // Subscribimos el evento si queremos volcar la fila en los TextBox
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            //  Asignamos la lista pre‑cargada al DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = biblioteca.LibrosDisponibles;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var libro = dataGridView1.Rows[e.RowIndex].DataBoundItem as Libro;
            if (libro == null) return;

            // Volcamos en los TextBox
            txtNombreLibro.Text = libro.Titulo;
            txtAutorLibro.Text = libro.Autor;
            txtEditorialLibro.Text = libro.Editorial;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtNombreLibro.Text.Trim();
            string autor = txtAutorLibro.Text.Trim();
            string editorial = txtEditorialLibro.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtNombreLibro.Text) || string.IsNullOrWhiteSpace(txtAutorLibro.Text) || string.IsNullOrWhiteSpace(txtEditorialLibro.Text))
            {
                MessageBox.Show("Por favor complete ambos campos.");
                return;
            }

            string resultado = biblioteca.AltaLibro(titulo, autor, editorial);
            MessageBox.Show(resultado);
        }



    }
}
