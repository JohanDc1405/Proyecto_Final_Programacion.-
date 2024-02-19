using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Programacion._
{
    public partial class Peliculas_Alquiladas : Form
    {
        Usuario usuario;
        public Peliculas_Alquiladas(Usuario usuario)
        {
            InitializeComponent();
            btn1.Visible = false;
            this.usuario = usuario;
            MostrarPelis();
        }

        private void listPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPeliculas.SelectedIndex != -1)
                btn1.Visible = true;
            else
                btn1.Visible = false;
        }
        public void MostrarPelis()
        {
            if (this.usuario.Peliculas_Alquiladas.Count != 0)
            {
                foreach (var pelicula in this.usuario.Peliculas_Alquiladas)
                {
                    listPeliculas.Items.Add(pelicula.Identificador + " 🎬 " + pelicula.Nombre + "  |  " + " 💿 " + pelicula.Genero + "  |  " + pelicula.Anotaciones);
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string novedad = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la novedad que quieres registrar", "Alquilar pelicula", "");
            int i = listPeliculas.SelectedIndex;
            if (i != -1)
            {
                if (novedad != "")
                {
                    string identificador = listPeliculas.SelectedItem.ToString();
                    usuario.generarNovedad(Convert.ToInt32(identificador.Substring(0, 1)), novedad);
                    listPeliculas.Items.RemoveAt(i);
                    MostrarPelis();
                }
            }
        }
    }
}

