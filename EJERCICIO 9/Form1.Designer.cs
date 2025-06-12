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
            this.BotonValidar = new System.Windows.Forms.Button();
            this.TextoEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotonValidar
            // 
            this.BotonValidar.BackColor = System.Drawing.Color.Plum;
            this.BotonValidar.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonValidar.Location = new System.Drawing.Point(228, 177);
            this.BotonValidar.Name = "BotonValidar";
            this.BotonValidar.Size = new System.Drawing.Size(211, 78);
            this.BotonValidar.TabIndex = 0;
            this.BotonValidar.Text = "Validar Numero ";
            this.BotonValidar.UseVisualStyleBackColor = false;
            this.BotonValidar.Click += new System.EventHandler(this.BotonValidar_Click);
            // 
            // TextoEntrada
            // 
            this.TextoEntrada.BackColor = System.Drawing.Color.Thistle;
            this.TextoEntrada.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoEntrada.Location = new System.Drawing.Point(228, 118);
            this.TextoEntrada.Name = "TextoEntrada";
            this.TextoEntrada.Size = new System.Drawing.Size(211, 50);
            this.TextoEntrada.TabIndex = 1;
            this.TextoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(685, 422);
            this.Controls.Add(this.TextoEntrada);
            this.Controls.Add(this.BotonValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonValidar;
        private System.Windows.Forms.TextBox TextoEntrada;
    }
}

