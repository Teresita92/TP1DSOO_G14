using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca.Models;

namespace MiBiblioteca
{
    public partial class Lectores : Form
    {
        // para acceder a los métodos del modelo biblioteca
        private Biblioteca biblioteca;
        public Lectores(Biblioteca bibliotecaExistente)
        {
            InitializeComponent();
            this.biblioteca = bibliotecaExistente;
        }

        private void btnAgregarLector_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreLector.Text.Trim();
            string dni = txtDni.Text.Trim();


            if (string.IsNullOrWhiteSpace(txtNombreLector.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor complete ambos campos.");
                return;
            }

            string resultado = biblioteca.AltaLector(nombre, dni);
            MessageBox.Show(resultado);

            RefrescarGrilla();
        }

        // Para mostrar el lector agregado en el momento
        private void RefrescarGrilla()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            foreach (var lector in biblioteca.LectoresRegistrados)
            {
                dataGridView1.Rows.Add(lector.Nombre, lector.Dni);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var lector = dataGridView1.Rows[e.RowIndex].DataBoundItem as Lector;
            if (lector == null) return;

            // Volcamos en los TextBox
            txtNombreLector.Text = lector.Nombre;
            txtDni.Text = lector.Dni;
        }

        private void Lectores_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }
    }
}
