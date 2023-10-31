using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplicación.formularios;

namespace aplicación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Campo vacío","ERROR");
                return;
            }
            else if (textBox1.Text.Length < 4 && textBox2.Text.Length < 4)
            {
                MessageBox.Show("Los campos no pueden tener menos de 3 letras","ERROR");
                return;
            }
            else
            {
                FormaEstudiantes home = new FormaEstudiantes();
                home.Show();

                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regístrate regist = new Regístrate();
            regist.Show();

            this.Hide();
        }
    }
}
