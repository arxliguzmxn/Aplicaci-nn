using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicación.formularios
{
    public partial class Regístrate : Form
    {
        public Regístrate()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked && checkBox1.Checked)
            {
                //checkBox1.Checked = false;
                MessageBox.Show("No puede seleccionar dos géneros","ERROR");
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(checkBox1.Text) || string.IsNullOrEmpty(checkBox2.Text) || string.IsNullOrEmpty(checkBox2.Text) || string.IsNullOrEmpty(checkBox1.Text))
            {
                MessageBox.Show("Campo vacío", "ERROR");
                return;
            }
            else if (textBox1.Text.Length < 4 && textBox2.Text.Length < 4 && textBox3.Text.Length < 4 && textBox4.Text.Length < 4)
            {
                MessageBox.Show("Los campos no pueden tener menos de 3 letras", "ERROR");
                return;
            }
            else
            {
                FormaEstudiantes home = new FormaEstudiantes();
                home.Show();
                this.Hide();
            }
        }

    }
}
