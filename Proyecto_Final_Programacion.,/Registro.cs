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
    public partial class Registro : Form
    {
        Form1 form1 = new Form1();
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string titular = txt1.Text;
            int documento = 0;
            try
            {
                documento = Convert.ToInt32(txt2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numero de documento invalido.");
            }
            string contrasenia = txt3.Text;
            if (String.IsNullOrEmpty(titular) || String.IsNullOrEmpty(contrasenia) || documento == 0)
            {
                MessageBox.Show("Completa todos los campos.");
            }
            else
            {
                MessageBox.Show(Usuario.CrearCliente(titular, documento, contrasenia));
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form1.ShowDialog();
            this.Close();
        }
    }
}
