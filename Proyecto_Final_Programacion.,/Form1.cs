namespace Proyecto_Final_Programacion._
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int documento = 0;
            string contrasenia = txt2.Text;
            try
            {
                documento = Convert.ToInt32(txt1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Documento incorrecto");
            }

            if (documento != 0 && !String.IsNullOrEmpty(contrasenia))
            {
                if (Usuario.Login(documento, contrasenia) != null)
                {
                    Tienda_Peliculas formApp = new Tienda_Peliculas(Usuario.Login(documento, contrasenia));
                    this.Hide();
                    formApp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Documento y/o contraseña iconrrecto(s).");
                }
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro formRegistro = new Registro();
            this.Hide();
            formRegistro.ShowDialog();
            this.Close();
        }
    }

}

