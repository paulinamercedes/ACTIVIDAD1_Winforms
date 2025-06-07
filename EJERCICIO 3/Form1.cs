using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Botonrojo_Click(object sender, EventArgs e) => this.BackColor = Color.Red;

        private void Botonazul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Botonverde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
