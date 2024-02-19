using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion._
{
    public class Usuario
    {
        string Nombre { set; get; }
        int NroDocumento { set; get; }
        string Contrasenia { set; get; }
        public Usuario()
        {
        }
        public Usuario(string nombre, int nroDocumento, string contrasenia)
        {
            Nombre = nombre;
            NroDocumento = nroDocumento;
            Contrasenia = contrasenia;
        }
    }
}
