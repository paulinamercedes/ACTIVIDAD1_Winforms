using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelresultado_Click(object sender, EventArgs e)
        {

        }

        private void botonaceptar_Click(object sender, EventArgs e)
        {

            if (rbotonOpcion1.Checked)
            {
                labelresultado.Text = "Seleccionaste la Opción 1.";
            }
            else if (rbotonOpcion2.Checked)
            {
                labelresultado.Text = "Seleccionaste la Opción 2.";
            }
            else if (rbotonOpcion3.Checked)
            {
                labelresultado.Text = "Seleccionaste la Opción 3.";
            }
            else
            {
                labelresultado.Text = "No se selccionó ninguna opción.";
            }

        }
    }
}
