namespace EJERCICIO_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonvalidar = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.TextoEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonvalidar
            // 
            this.botonvalidar.BackColor = System.Drawing.Color.Plum;
            this.botonvalidar.Location = new System.Drawing.Point(60, 130);
            this.botonvalidar.Name = "botonvalidar";
            this.botonvalidar.Size = new System.Drawing.Size(194, 54);
            this.botonvalidar.TabIndex = 0;
            this.botonvalidar.Text = "Validar Numero";
            this.botonvalidar.UseVisualStyleBackColor = false;
            this.botonvalidar.Click += new System.EventHandler(this.botonvalidar_Click);
            // 
            // LabelResultado
            // 
            this.LabelResultado.BackColor = System.Drawing.Color.Thistle;
            this.LabelResultado.Location = new System.Drawing.Point(414, 50);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(200, 100);
            this.LabelResultado.TabIndex = 1;
            // 
            // TextoEntrada
            // 
            this.TextoEntrada.BackColor = System.Drawing.Color.Thistle;
            this.TextoEntrada.Location = new System.Drawing.Point(60, 66);
            this.TextoEntrada.Name = "TextoEntrada";
            this.TextoEntrada.Size = new System.Drawing.Size(200, 31);
            this.TextoEntrada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextoEntrada);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.botonvalidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonvalidar;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.TextBox TextoEntrada;
    }
}

