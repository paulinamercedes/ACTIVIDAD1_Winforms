namespace EJERCICIO_3
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
            this.Botonrojo = new System.Windows.Forms.Button();
            this.Botonazul = new System.Windows.Forms.Button();
            this.Botonverde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botonrojo
            // 
            this.Botonrojo.BackColor = System.Drawing.Color.Crimson;
            this.Botonrojo.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonrojo.Location = new System.Drawing.Point(93, 223);
            this.Botonrojo.Name = "Botonrojo";
            this.Botonrojo.Size = new System.Drawing.Size(146, 54);
            this.Botonrojo.TabIndex = 0;
            this.Botonrojo.Text = "Rojo";
            this.Botonrojo.UseVisualStyleBackColor = false;
            this.Botonrojo.Click += new System.EventHandler(this.Botonrojo_Click);
            // 
            // Botonazul
            // 
            this.Botonazul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Botonazul.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonazul.Location = new System.Drawing.Point(326, 223);
            this.Botonazul.Name = "Botonazul";
            this.Botonazul.Size = new System.Drawing.Size(147, 54);
            this.Botonazul.TabIndex = 1;
            this.Botonazul.Text = "Azul";
            this.Botonazul.UseVisualStyleBackColor = false;
            this.Botonazul.Click += new System.EventHandler(this.Botonazul_Click);
            // 
            // Botonverde
            // 
            this.Botonverde.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Botonverde.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonverde.Location = new System.Drawing.Point(566, 223);
            this.Botonverde.Name = "Botonverde";
            this.Botonverde.Size = new System.Drawing.Size(142, 54);
            this.Botonverde.TabIndex = 2;
            this.Botonverde.Text = "Verde";
            this.Botonverde.UseVisualStyleBackColor = false;
            this.Botonverde.Click += new System.EventHandler(this.Botonverde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Botonverde);
            this.Controls.Add(this.Botonazul);
            this.Controls.Add(this.Botonrojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botonrojo;
        private System.Windows.Forms.Button Botonazul;
        private System.Windows.Forms.Button Botonverde;
    }
}

