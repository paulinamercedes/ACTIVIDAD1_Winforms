namespace EJERCICIO_5
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
            this.rbotonOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbotonOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbotonOpcion3 = new System.Windows.Forms.RadioButton();
            this.botonaceptar = new System.Windows.Forms.Button();
            this.labelresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbotonOpcion1
            // 
            this.rbotonOpcion1.AutoSize = true;
            this.rbotonOpcion1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotonOpcion1.Location = new System.Drawing.Point(70, 82);
            this.rbotonOpcion1.Name = "rbotonOpcion1";
            this.rbotonOpcion1.Size = new System.Drawing.Size(176, 40);
            this.rbotonOpcion1.TabIndex = 0;
            this.rbotonOpcion1.TabStop = true;
            this.rbotonOpcion1.Text = "Opción 1";
            this.rbotonOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbotonOpcion2
            // 
            this.rbotonOpcion2.AutoSize = true;
            this.rbotonOpcion2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotonOpcion2.Location = new System.Drawing.Point(70, 143);
            this.rbotonOpcion2.Name = "rbotonOpcion2";
            this.rbotonOpcion2.Size = new System.Drawing.Size(176, 40);
            this.rbotonOpcion2.TabIndex = 1;
            this.rbotonOpcion2.TabStop = true;
            this.rbotonOpcion2.Text = "Opción 2";
            this.rbotonOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbotonOpcion3
            // 
            this.rbotonOpcion3.AutoSize = true;
            this.rbotonOpcion3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotonOpcion3.Location = new System.Drawing.Point(70, 204);
            this.rbotonOpcion3.Name = "rbotonOpcion3";
            this.rbotonOpcion3.Size = new System.Drawing.Size(176, 40);
            this.rbotonOpcion3.TabIndex = 2;
            this.rbotonOpcion3.TabStop = true;
            this.rbotonOpcion3.Text = "Opción 3";
            this.rbotonOpcion3.UseVisualStyleBackColor = true;
            // 
            // botonaceptar
            // 
            this.botonaceptar.BackColor = System.Drawing.Color.Plum;
            this.botonaceptar.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonaceptar.Location = new System.Drawing.Point(70, 276);
            this.botonaceptar.Name = "botonaceptar";
            this.botonaceptar.Size = new System.Drawing.Size(189, 81);
            this.botonaceptar.TabIndex = 3;
            this.botonaceptar.Text = "Aceptar";
            this.botonaceptar.UseVisualStyleBackColor = false;
            this.botonaceptar.Click += new System.EventHandler(this.botonaceptar_Click);
            // 
            // labelresultado
            // 
            this.labelresultado.BackColor = System.Drawing.Color.Thistle;
            this.labelresultado.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelresultado.Location = new System.Drawing.Point(402, 82);
            this.labelresultado.Name = "labelresultado";
            this.labelresultado.Size = new System.Drawing.Size(300, 115);
            this.labelresultado.TabIndex = 4;
            this.labelresultado.Click += new System.EventHandler(this.labelresultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelresultado);
            this.Controls.Add(this.botonaceptar);
            this.Controls.Add(this.rbotonOpcion3);
            this.Controls.Add(this.rbotonOpcion2);
            this.Controls.Add(this.rbotonOpcion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbotonOpcion1;
        private System.Windows.Forms.RadioButton rbotonOpcion2;
        private System.Windows.Forms.RadioButton rbotonOpcion3;
        private System.Windows.Forms.Button botonaceptar;
        private System.Windows.Forms.Label labelresultado;
    }
}

