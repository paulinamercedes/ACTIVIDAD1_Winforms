using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_8
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void botoncontar_Click(object sender, EventArgs e)
        {
            contador++;
            labelcontador.Text = "Clicks: " + contador;

        }

        private void labelcontador_Click(object sender, EventArgs e)
        {

        }
    }
}
