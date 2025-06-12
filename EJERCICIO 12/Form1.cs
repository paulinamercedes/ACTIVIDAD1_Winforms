using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCelsius.Text, out double celsius))
            {
                double Fahrenheit = (celsius * 9 / 5) + 32;
                labelFahrenheit.Text = "La temperatura equivalente en Fahrenheit es =  " +
                Fahrenheit.ToString();
                    
            }
            else
            {
                MessageBox.Show("Por Favor ingresar un número válido.");
            }
        }

        private void labelFahrenheit_Click(object sender, EventArgs e)
        {

        }
    }
}