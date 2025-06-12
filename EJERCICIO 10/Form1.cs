using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonMensaje_Click(object sender, EventArgs e)
        {
            string Nombre = "Paulina Mercedes R.";
            string Matricula = "LR-2024-01435";

            MessageBox.Show($"Hola, soy {Nombre}  {Matricula}", "Mensaje");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
