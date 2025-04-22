namespace MiBiblioteca.Models
{
    public class Biblioteca
    {
        public List<Libro> LibrosDisponibles { get; set; } = new List<Libro>();
        public List<Lector> LectoresRegistrados { get; set; } = new List<Lector>();

        //Prcargamos datos a la bibliote - Libros y Lectores
        public Biblioteca()
        {
            LibrosDisponibles = new List<Libro>
        {
            new Libro("Cien años de soledad","Jose"),
            new Libro("El principito", "Jose"),
            new Libro("1984", "Jose"),
            new Libro("Rayuela", "Jose"),
            new Libro("Crónica de una muerte anunciada", "Jose")
        };

            LectoresRegistrados = new List<Lector>
        {
            new Lector("Caloni Adriano", "36543024"),
            new Lector("María López", "87654321"),
            new Lector("Lucía García", "11223344")
        };
        }
        public string AltaLector(string nombre, string dni)
        {
            if (LectoresRegistrados.Any(l => l.Dni == dni))
                return "Lector ya registrado";

            LectoresRegistrados.Add(new Lector(nombre, dni));
            return "Lector dado de alta";
        }

        public string PrestarLibro(string titulo, string dni)
        {
            var lector = LectoresRegistrados.FirstOrDefault(l => l.Dni == dni);
            if (lector == null)
                return "LECTOR INEXISTENTE";

            if (!lector.PuedePedirPrestamo())
                return "TOPE DE PRESTAMO ALCAZADO";

            var libro = LibrosDisponibles.FirstOrDefault(l => l.Titulo == titulo);
            if (libro == null)
                return "LIBRO INEXISTENTE";

            LibrosDisponibles.Remove(libro);
            lector.LibrosPrestados.Add(libro);
            return "PRESTAMO EXITOSO";
        }
    }

}


