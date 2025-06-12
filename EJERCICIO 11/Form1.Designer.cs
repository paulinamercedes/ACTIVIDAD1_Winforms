namespace EJERCICIO_11
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.botonfechaseleccionada = new System.Windows.Forms.Button();
            this.labelfecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(441, 38);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // botonfechaseleccionada
            // 
            this.botonfechaseleccionada.BackColor = System.Drawing.Color.Plum;
            this.botonfechaseleccionada.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonfechaseleccionada.Location = new System.Drawing.Point(534, 155);
            this.botonfechaseleccionada.Name = "botonfechaseleccionada";
            this.botonfechaseleccionada.Size = new System.Drawing.Size(197, 61);
            this.botonfechaseleccionada.TabIndex = 1;
            this.botonfechaseleccionada.Text = "Ver Fecha";
            this.botonfechaseleccionada.UseVisualStyleBackColor = false;
            this.botonfechaseleccionada.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelfecha
            // 
            this.labelfecha.BackColor = System.Drawing.Color.Thistle;
            this.labelfecha.Location = new System.Drawing.Point(494, 23);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(270, 104);
            this.labelfecha.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.botonfechaseleccionada);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button botonfechaseleccionada;
        private System.Windows.Forms.Label labelfecha;
    }
}

