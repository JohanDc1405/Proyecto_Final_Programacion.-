using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion._
{
    public class Pelicula
    {
        public static List<Pelicula> peliculas = new List<Pelicula>();
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }
        public int Disponibilidad { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Anotaciones { get; set; }

        public Pelicula(int identificador, string nombre, string genero, double precio, int disponibilidad)
        {
            Identificador = identificador;
            Nombre = nombre;
            Genero = genero;
            Precio = precio;
            Disponibilidad = disponibilidad;
            Anotaciones = "";
        }

        public static int Alquilar(int cantidad, int identificador, Usuario usuario)
        {
            foreach (var pelicula in peliculas)
            {
                if (pelicula.Identificador == identificador)
                {
                    if (pelicula.Disponibilidad >= 0)
                    {
                        if (cantidad > 0 && cantidad <= pelicula.Disponibilidad)
                        {
                            pelicula.Disponibilidad -= cantidad;
                            MessageBox.Show($"Has alquilado exitosamente {cantidad} película(s) de {pelicula.Nombre}");
                            usuario.Peliculas_Alquiladas.Add(pelicula);
                            return pelicula.Disponibilidad;
                        }
                        else
                        {
                            MessageBox.Show($"No se permiten valores negativos, ceros, ni valores mayores a la disponibilidad. \nHay disponibles {pelicula.Disponibilidad} películas");
                            return pelicula.Disponibilidad;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay disponibilidad");
                        return 0;
                    }
                }
            }
            return 0;
        }

    }

}
