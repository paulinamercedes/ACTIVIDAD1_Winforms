using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonValidar_Click(object sender, EventArgs e)
        {

            double numero;

            if (double.TryParse(TextoEntrada.Text, out numero))
            {
                MessageBox.Show("Es un número válido: " + numero);
            }
            else
            {
                MessageBox.Show("No es un número valido.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}