using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion._
{
    public class Usuario
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        string nombre;
        int nroDocumento;
        string contrasenia;
        List<Pelicula> peliculasAlquiladas = new List<Pelicula>();


        public Usuario(string nombre, int nroDocumento, string contrasenia)
        {
            this.nombre = nombre;
            this.nroDocumento = nroDocumento;
            this.contrasenia = contrasenia;
        }


        public static string CrearCliente(string nombre, int documento, string contrasenia)
        {
            Usuario usuario = new Usuario(nombre, documento, contrasenia);
            usuarios.Add(usuario);
            return "Cuenta creada satisfactoriamente";
        }

        public static Usuario Login(int nroDocumento, string contrasenia)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NroDocumento == nroDocumento && usuario.Contrasenia == contrasenia)
                {
                    return usuario;
                }
            }
            return null;
        }

        public void generarNovedad(int identificador, string novedad)
        {
            foreach (var pelicula in peliculasAlquiladas)
            {
                if (pelicula.Identificador == identificador)
                {
                    pelicula.Anotaciones = novedad;
                    MessageBox.Show("Anotación realizada exitosamente");
                }
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public List<Pelicula> Peliculas_Alquiladas { get => peliculasAlquiladas; set => peliculasAlquiladas = value; }
    }
}
