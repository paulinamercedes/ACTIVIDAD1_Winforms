using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace EJERCICIO_16
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Botones de los numeros 
        private void boton1_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "9";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textoPantalla.Text += "0";
        }
        //Boton suma
        private void botonSuma_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(textoPantalla.Text);
            operacion = "+";
            textoPantalla.Clear();
        }
        //Boton Borrar
        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            textoPantalla.Clear();
            primerNumero = 0;
            operacion = "";
        }
        //Boton para borrar un digito
        private void BotonBA_Click(object sender, EventArgs e)
        {
            if (textoPantalla.Text.Length> 0)
            {
                textoPantalla.Text = textoPantalla.Text.Substring(0, textoPantalla.Text.Length - 1);

            }

        }

        //Boton para decimal
        private void BotonDecimal_Click(object sender, EventArgs e)
        {
            if (!textoPantalla.Text.Contains("."))

            { textoPantalla.Text += ".";

            }
        }

        //Boton igual =
        private void button12_Click(object sender, EventArgs e)
        {
            double segundoNumero;
            double resultado = 0;
            try
            {
                segundoNumero = Convert.ToDouble(textoPantalla.Text);
                switch (operacion)

                {
                    case "+":
                        resultado = primerNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primerNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primerNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = primerNumero / segundoNumero;
                        else
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                            return;
                        }
                        break;
                }
                textoPantalla.Text = resultado.ToString();
            }
            catch { MessageBox.Show    ("Error al realizar la operacion"); }

        }

        private void BotonResta_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(textoPantalla.Text);
            operacion = "-";
            textoPantalla.Clear();
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(textoPantalla.Text);
            operacion = "/";
            textoPantalla.Clear();
        }

        private void botonMultiplicacion_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(textoPantalla.Text);
            operacion = "*";
            textoPantalla.Clear();
        }
    }
}
