using System;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_I_Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNombre.Text = "René González";
            lblEdad.Text = "28";
            lblNombre.AutoSize = true;
            lblEdad.AutoSize = false;
            lblNombre.Font = new Font("Arial", lblNombre.Font.Size, FontStyle.Bold);
            lblEdad.Font = new Font("New time Roman", lblEdad.Font.Size);
            lblNombre.ForeColor = Color.Blue;
            lblEdad.ForeColor = Color.Brown;
            lblNombre.BackColor = Color.Yellow;
            lblEdad.BackColor = Color.GreenYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido";
            MessageBox.Show("Bienvenido al Curso");
        }
    }
}
