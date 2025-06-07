namespace EJERCICIO_8
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
            this.botoncontar = new System.Windows.Forms.Button();
            this.labelcontador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botoncontar
            // 
            this.botoncontar.BackColor = System.Drawing.Color.Plum;
            this.botoncontar.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncontar.Location = new System.Drawing.Point(217, 238);
            this.botoncontar.Name = "botoncontar";
            this.botoncontar.Size = new System.Drawing.Size(295, 83);
            this.botoncontar.TabIndex = 0;
            this.botoncontar.Text = "Haz click aquì";
            this.botoncontar.UseVisualStyleBackColor = false;
            this.botoncontar.Click += new System.EventHandler(this.botoncontar_Click);
            // 
            // labelcontador
            // 
            this.labelcontador.AutoSize = true;
            this.labelcontador.BackColor = System.Drawing.Color.Thistle;
            this.labelcontador.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontador.Location = new System.Drawing.Point(321, 161);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(108, 36);
            this.labelcontador.TabIndex = 1;
            this.labelcontador.Text = "Clicks: ";
            this.labelcontador.Click += new System.EventHandler(this.labelcontador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 446);
            this.Controls.Add(this.labelcontador);
            this.Controls.Add(this.botoncontar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoncontar;
        private System.Windows.Forms.Label labelcontador;
    }
}

