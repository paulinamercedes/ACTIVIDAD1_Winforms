using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EJERCICIO_7
{
    public partial class Form1 : Form
    {
        private object elemento;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string elemento = textoElemento.Text.Trim();

            if (!string.IsNullOrEmpty(elemento))
            {
                listaElementos.Items.Add(elemento); 
                textoElemento.Clear();              
                textoElemento.Focus();              
            }
            else
            {
                MessageBox.Show("Por favor, escribir un elemento para agregar.");
            }

        }

        private void listaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}