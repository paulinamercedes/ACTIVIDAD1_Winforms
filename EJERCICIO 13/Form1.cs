using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BarraProgreso.Minimum = 0;
            BarraProgreso.Maximum = 100;
            BarraProgreso.Step = 1;
        }

        private void BotonIniciar_Click(object sender, EventArgs e)
        {
            Temporizador.Start();
        }

        private void BotonDeterner_Click(object sender, EventArgs e)
        {
            Temporizador.Stop();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (BarraProgreso.Value < BarraProgreso.Maximum)
            {
                BarraProgreso.PerformStep();
            }
            else
            {
                Temporizador.Stop();
                MessageBox.Show("Proceso completado.");
            }
        }
    }
}
