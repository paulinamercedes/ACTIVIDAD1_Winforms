namespace EJERCICIO2
{
    partial class Form2
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
            this.labelresultado = new System.Windows.Forms.Label();
            this.botoncambiartexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelresultado
            // 
            this.labelresultado.AutoSize = true;
            this.labelresultado.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.Location = new System.Drawing.Point(264, 116);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(248, 43);
            this.labelresultado.TabIndex = 0;
            this.labelresultado.Text = "Texto original ";
            this.labelresultado.Click += new System.EventHandler(this.etiquetaresultado_Click);
            // 
            // botoncambiartexto
            // 
            this.botoncambiartexto.BackColor = System.Drawing.Color.LightBlue;
            this.botoncambiartexto.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncambiartexto.Location = new System.Drawing.Point(248, 181);
            this.botoncambiartexto.Name = "botoncambiartexto";
            this.botoncambiartexto.Size = new System.Drawing.Size(278, 73);
            this.botoncambiartexto.TabIndex = 1;
            this.botoncambiartexto.Text = "Cambiar Texto";
            this.botoncambiartexto.UseVisualStyleBackColor = false;
            this.botoncambiartexto.Click += new System.EventHandler(this.botoncambiartexto_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botoncambiartexto);
            this.Controls.Add(this.labelresultado);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelresultado;
        private System.Windows.Forms.Button botoncambiartexto;
    }
}

