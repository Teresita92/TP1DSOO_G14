namespace MiBiblioteca.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public string Editorial { get; set; }
        public Libro(string titulo, string autor, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }
    }

}