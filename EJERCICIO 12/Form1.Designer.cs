namespace EJERCICIO_12
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
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.BotonConvertir = new System.Windows.Forms.Button();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.BackColor = System.Drawing.Color.Thistle;
            this.textBoxCelsius.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCelsius.Location = new System.Drawing.Point(160, 42);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(100, 38);
            this.textBoxCelsius.TabIndex = 0;
            // 
            // BotonConvertir
            // 
            this.BotonConvertir.BackColor = System.Drawing.Color.Plum;
            this.BotonConvertir.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConvertir.Location = new System.Drawing.Point(59, 194);
            this.BotonConvertir.Name = "BotonConvertir";
            this.BotonConvertir.Size = new System.Drawing.Size(168, 64);
            this.BotonConvertir.TabIndex = 2;
            this.BotonConvertir.Text = "Convertir";
            this.BotonConvertir.UseVisualStyleBackColor = false;
            this.BotonConvertir.Click += new System.EventHandler(this.BotonConvertir_Click);
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelsius.Location = new System.Drawing.Point(53, 45);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(92, 31);
            this.labelCelsius.TabIndex = 3;
            this.labelCelsius.Text = "Celsius";
            // 
            // labelFahrenheit
            // 
            this.labelFahrenheit.AutoSize = true;
            this.labelFahrenheit.BackColor = System.Drawing.Color.Thistle;
            this.labelFahrenheit.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFahrenheit.Location = new System.Drawing.Point(53, 123);
            this.labelFahrenheit.Name = "labelFahrenheit";
            this.labelFahrenheit.Size = new System.Drawing.Size(130, 31);
            this.labelFahrenheit.TabIndex = 4;
            this.labelFahrenheit.Text = "Fahrenheit";
            this.labelFahrenheit.Click += new System.EventHandler(this.labelFahrenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(728, 325);
            this.Controls.Add(this.labelFahrenheit);
            this.Controls.Add(this.labelCelsius);
            this.Controls.Add(this.BotonConvertir);
            this.Controls.Add(this.textBoxCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Button BotonConvertir;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.Label labelFahrenheit;
    }
}

