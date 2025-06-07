using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {

            string colorSeleccionado = comboBoxColores.SelectedItem.ToString();

            switch (colorSeleccionado)
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColores.Items.Add("Rojo");
            comboBoxColores.Items.Add("Verde");
            comboBoxColores.Items.Add("Azul");
        }
    }
}
