using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Programacion._
{
    public partial class Tienda_Peliculas : Form
    {

        static int sesiones = 0;
        public static Usuario usuario;
        int indice = -1;



        public Tienda_Peliculas(Usuario usuario)
        {
            InitializeComponent();
            Tienda_Peliculas.usuario = usuario;
            textBox2.Text = usuario.Nombre;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a de peliculas a alquilar", "Alquilar pelicula", "0"));
            label5.Text = Pelicula.Alquilar(cantidad, indice, usuario).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBox1.SelectedIndex;
            foreach (var pelicula in Pelicula.peliculas)
            {
                if (pelicula.Identificador == indice)
                {
                    textBox2.Text = pelicula.Nombre;
                    textBox1.Text = pelicula.Genero;
                    textBox3.Text = "$ " + pelicula.Precio;
                    textBox4.Text = pelicula.Disponibilidad.ToString();
                    switch (indice)
                    {

                        case 0:
                            pictureBox3.Image = Proyecto_Final_Programacion._.Properties.Resources.img_flash;
                            break;
                        case 1:
                            pictureBox3.Image = Proyecto_Final_Programacion._.Properties.Resources.img_spiderman;
                            break;
                        case 2:
                            pictureBox3.Image = Proyecto_Final_Programacion._.Properties.Resources.img_guardianes;
                            break;
                        case 3:
                            pictureBox3.Image = Proyecto_Final_Programacion._.Properties.Resources.img_mario;
                            break;
                        case 4:
                            pictureBox3.Image = Proyecto_Final_Programacion._.Properties.Resources.img_huerfana;
                            break;

                    }
                }
            }
        }
        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Peliculas_Alquiladas form = new Peliculas_Alquiladas(usuario);
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formLogin = new Form1();
            formLogin.ShowDialog();
            this.Close();
        }

        private void Tienda_Peliculas_Load_1(object sender, EventArgs e)
        {

            sesiones++;
            if (sesiones == 1)
            {
                Pelicula pelicula1 = new Pelicula(0, "FLASH", "Acción/Ciencia ficción", 2000, 5);
                Pelicula pelicula2 = new Pelicula(1, "Spider-Man Cruzando el Multiverso", "Comedia/Accion", 2000, 5);
                Pelicula pelicula3 = new Pelicula(2, "Guardianes de la Galaxia", "Accion/Ciencia ficcion", 2000, 5);
                Pelicula pelicula4 = new Pelicula(3, "Super Mario Bros: La Pelicula", "Infantil/Comedia", 2000, 5);
                Pelicula pelicula5 = new Pelicula(4, "La huerfana", "Suspenso/Crimen", 2000, 5);

                Pelicula.peliculas.Add(pelicula1);
                Pelicula.peliculas.Add(pelicula2);
                Pelicula.peliculas.Add(pelicula3);
                Pelicula.peliculas.Add(pelicula4);
                Pelicula.peliculas.Add(pelicula5);
            }

            foreach (var pelicula in Pelicula.peliculas)
            {
                comboBox1.Items.Add(pelicula.Nombre);
            }
        }

    }
}
