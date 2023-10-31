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
    public partial class FormaEstudiantes : Form
    {
        public FormaEstudiantes()
        {
            InitializeComponent();
        }

        private void dataEstudiante_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminando el registro";

            if (!(dataEstudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón", "Estudiante eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando Estudiante",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Número de Control"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
                {
                    MessageBox.Show("Campo vacío","ERROR");
                    return;
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un número entero válido en su No. de Control.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(textBox3.Text, out int valorTextBox3) && valorTextBox3 <= 0)
                {
                    MessageBox.Show("Error en el No. de Control","ERROR");
                    return;
                }
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox3.Text;
                renglon.Cells[1].Value = textBox1.Text;
                renglon.Cells[2].Value = textBox2.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = comboBox2.Text;

                dataEstudiante.Rows.Add(renglon); //agrega renglon
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
