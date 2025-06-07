using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botoncalcular_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = double.Parse(textnumero1.Text);
                double num2 = double.Parse(textnumero2.Text);

                labelsuma.Text = "Suma: " + (num1 + num2);
                labelresta.Text = "Resta: " + (num1 - num2);
                labelmultiplicacion.Text = "Multiplicación: " + (num1 * num2);
                labeldivision.Text = num2 != 0 ? "División: " + (num1 / num2) : "División: No se puede dividir entre 0";
            }
            catch
            {
                MessageBox.Show("Favor ingresar números válidos.");
            }
        }

    
}
}
