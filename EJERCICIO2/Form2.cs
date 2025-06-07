
using System;
using System.Windows.Forms;

namespace EJERCICIO2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botonCambiarTexto_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "Texto cambiado";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Este evento se ejecuta al cargar el formulario
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {
            // Este evento se ejecuta si haces clic en la etiqueta (opcional)
        }
    }
}

