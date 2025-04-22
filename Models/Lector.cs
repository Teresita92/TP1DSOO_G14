using System.Collections.Generic;

namespace MiBiblioteca.Models
{
    public class Lector
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public List<Libro> LibrosPrestados { get; set; } = new List<Libro>();

        public Lector(string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public bool PuedePedirPrestamo()
        {
            return LibrosPrestados.Count < 3;
        }
    }
}
