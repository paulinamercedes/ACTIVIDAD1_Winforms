namespace EJERCICIO_10
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
            this.BotonMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonMensaje
            // 
            this.BotonMensaje.BackColor = System.Drawing.Color.Plum;
            this.BotonMensaje.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonMensaje.Location = new System.Drawing.Point(253, 164);
            this.BotonMensaje.Name = "BotonMensaje";
            this.BotonMensaje.Size = new System.Drawing.Size(251, 91);
            this.BotonMensaje.TabIndex = 0;
            this.BotonMensaje.Text = "Hacer Click";
            this.BotonMensaje.UseVisualStyleBackColor = false;
            this.BotonMensaje.Click += new System.EventHandler(this.BotonMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonMensaje;
    }
}

