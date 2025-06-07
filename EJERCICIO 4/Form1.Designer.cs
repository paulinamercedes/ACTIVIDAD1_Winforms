namespace EJERCICIO_4
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
            this.textnumero1 = new System.Windows.Forms.TextBox();
            this.textnumero2 = new System.Windows.Forms.TextBox();
            this.botoncalcular = new System.Windows.Forms.Button();
            this.labelsuma = new System.Windows.Forms.Label();
            this.labelresta = new System.Windows.Forms.Label();
            this.labelmultiplicacion = new System.Windows.Forms.Label();
            this.labeldivision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textnumero1
            // 
            this.textnumero1.BackColor = System.Drawing.Color.Thistle;
            this.textnumero1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumero1.Location = new System.Drawing.Point(497, 59);
            this.textnumero1.Name = "textnumero1";
            this.textnumero1.Size = new System.Drawing.Size(100, 44);
            this.textnumero1.TabIndex = 0;
            // 
            // textnumero2
            // 
            this.textnumero2.BackColor = System.Drawing.Color.Thistle;
            this.textnumero2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumero2.Location = new System.Drawing.Point(647, 59);
            this.textnumero2.Name = "textnumero2";
            this.textnumero2.Size = new System.Drawing.Size(100, 44);
            this.textnumero2.TabIndex = 1;
            // 
            // botoncalcular
            // 
            this.botoncalcular.BackColor = System.Drawing.Color.Plum;
            this.botoncalcular.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncalcular.Location = new System.Drawing.Point(547, 123);
            this.botoncalcular.Name = "botoncalcular";
            this.botoncalcular.Size = new System.Drawing.Size(149, 56);
            this.botoncalcular.TabIndex = 2;
            this.botoncalcular.Text = "Calcular";
            this.botoncalcular.UseVisualStyleBackColor = false;
            this.botoncalcular.Click += new System.EventHandler(this.botoncalcular_Click);
            // 
            // labelsuma
            // 
            this.labelsuma.AutoSize = true;
            this.labelsuma.BackColor = System.Drawing.Color.Thistle;
            this.labelsuma.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsuma.Location = new System.Drawing.Point(31, 97);
            this.labelsuma.Name = "labelsuma";
            this.labelsuma.Size = new System.Drawing.Size(88, 36);
            this.labelsuma.TabIndex = 3;
            this.labelsuma.Text = "Suma";
            // 
            // labelresta
            // 
            this.labelresta.AutoSize = true;
            this.labelresta.BackColor = System.Drawing.Color.Thistle;
            this.labelresta.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresta.Location = new System.Drawing.Point(31, 143);
            this.labelresta.Name = "labelresta";
            this.labelresta.Size = new System.Drawing.Size(83, 36);
            this.labelresta.TabIndex = 4;
            this.labelresta.Text = "Resta";
            // 
            // labelmultiplicacion
            // 
            this.labelmultiplicacion.AutoSize = true;
            this.labelmultiplicacion.BackColor = System.Drawing.Color.Thistle;
            this.labelmultiplicacion.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmultiplicacion.Location = new System.Drawing.Point(31, 191);
            this.labelmultiplicacion.Name = "labelmultiplicacion";
            this.labelmultiplicacion.Size = new System.Drawing.Size(199, 36);
            this.labelmultiplicacion.TabIndex = 5;
            this.labelmultiplicacion.Text = "Multiplicacion";
            // 
            // labeldivision
            // 
            this.labeldivision.AutoSize = true;
            this.labeldivision.BackColor = System.Drawing.Color.Thistle;
            this.labeldivision.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldivision.Location = new System.Drawing.Point(31, 240);
            this.labeldivision.Name = "labeldivision";
            this.labeldivision.Size = new System.Drawing.Size(122, 36);
            this.labeldivision.TabIndex = 6;
            this.labeldivision.Text = "Division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeldivision);
            this.Controls.Add(this.labelmultiplicacion);
            this.Controls.Add(this.labelresta);
            this.Controls.Add(this.labelsuma);
            this.Controls.Add(this.botoncalcular);
            this.Controls.Add(this.textnumero2);
            this.Controls.Add(this.textnumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnumero1;
        private System.Windows.Forms.TextBox textnumero2;
        private System.Windows.Forms.Button botoncalcular;
        private System.Windows.Forms.Label labelsuma;
        private System.Windows.Forms.Label labelresta;
        private System.Windows.Forms.Label labelmultiplicacion;
        private System.Windows.Forms.Label labeldivision;
    }
}

