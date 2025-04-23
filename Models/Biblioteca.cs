namespace MiBiblioteca.Models
{
    public class Biblioteca
    {
        public List<Libro> LibrosDisponibles { get; set; } = new List<Libro>();
        public List<Lector> LectoresRegistrados { get; set; } = new List<Lector>();

    //Precargamos datos a la biblioteca - Libros y Lectores
    public Biblioteca()
        {
            LibrosDisponibles = new List<Libro>
        {
            new Libro("Cien años de soledad","Jose", "Editorial"),
            new Libro("El principito", "Jose", "Editorial"),
            new Libro("1984", "Jose", "Editorial"),
            new Libro("Rayuela", "Jose", "Editorial"),
            new Libro("Crónica de una muerte anunciada", "Jose", "Editorial")
        };

            LectoresRegistrados = new List<Lector>
        {
            new Lector("Armando Paredes", "12345678")
        };

        }
        public string AltaLector(string nombre, string dni)
        {
            if (this.LectoresRegistrados.Any(l => l.Dni == dni))
                return "Lector ya registrado";

            this.LectoresRegistrados.Add(new Lector(nombre, dni));
            Console.WriteLine("meti los lectores" + this.LectoresRegistrados);
            return "Lector dado de alta";
        }

        public string AltaLibro(string titulo, string autor, string editorial)
        {
            if (this.LibrosDisponibles.Any(l => l.Titulo == titulo))
                return "Libro ya registrado";

            this.LibrosDisponibles.Add(new Libro (titulo, autor, editorial));
            return "Libro dado de alta";
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


