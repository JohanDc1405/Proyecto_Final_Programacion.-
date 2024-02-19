using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion._
{
    public class Usuarios
    {
        public List<Usuario> ListaUsuarios { get; set; }

        public Usuarios()
        {
            ListaUsuarios = new List<Usuario>();
        }
        public static string CrearUsuario(string nombre, int nroDocumento, string contrasenia)
        {
            Usuario usuario = new Usuario(nombre, nroDocumento, contrasenia);
            ListaUsuarios.Add(usuario);
            return "Cuenta creada satisfactoriamente";
        }

        // Método para realizar el login
        public static Usuario Login(int nroDocumento, string contrasenia)
        {
            return ListaUsuarios.Find(usuario => usuario.NroDocumento == nroDocumento && usuario.Contrasenia == contrasenia);
        }
    }
}
