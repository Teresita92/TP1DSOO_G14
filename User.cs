using System.Collections.Generic;
using System.Linq;

namespace MiBiblioteca
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // Lista estática con usuarios precargados
        public static List<User> Usuarios = new List<User>
        {
            new User { Username = "admin", Password = "1234" },
            new User { Username = "acaloni", Password = "12345" },
            new User { Username = "fsanchez", Password = "1234" }
        };

        // Método para validar usuario y contraseña
        public static bool Validar(string user, string pass)
        {
            return Usuarios.Any(u => u.Username == user && u.Password == pass);
        }
    }
}