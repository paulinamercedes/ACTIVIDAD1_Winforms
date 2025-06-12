namespace EJERCICIO_13
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
            this.components = new System.ComponentModel.Container();
            this.BotonIniciar = new System.Windows.Forms.Button();
            this.BotonDeterner = new System.Windows.Forms.Button();
            this.BarraProgreso = new System.Windows.Forms.ProgressBar();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BotonIniciar
            // 
            this.BotonIniciar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BotonIniciar.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciar.Location = new System.Drawing.Point(79, 128);
            this.BotonIniciar.Name = "BotonIniciar";
            this.BotonIniciar.Size = new System.Drawing.Size(147, 46);
            this.BotonIniciar.TabIndex = 0;
            this.BotonIniciar.Text = "Iniciar";
            this.BotonIniciar.UseVisualStyleBackColor = false;
            this.BotonIniciar.Click += new System.EventHandler(this.BotonIniciar_Click);
            // 
            // BotonDeterner
            // 
            this.BotonDeterner.BackColor = System.Drawing.Color.IndianRed;
            this.BotonDeterner.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDeterner.Location = new System.Drawing.Point(516, 128);
            this.BotonDeterner.Name = "BotonDeterner";
            this.BotonDeterner.Size = new System.Drawing.Size(147, 45);
            this.BotonDeterner.TabIndex = 1;
            this.BotonDeterner.Text = "Detener";
            this.BotonDeterner.UseVisualStyleBackColor = false;
            this.BotonDeterner.Click += new System.EventHandler(this.BotonDeterner_Click);
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.BackColor = System.Drawing.Color.Thistle;
            this.BarraProgreso.Location = new System.Drawing.Point(79, 68);
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(584, 31);
            this.BarraProgreso.TabIndex = 2;
            // 
            // Temporizador
            // 
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.BarraProgreso);
            this.Controls.Add(this.BotonDeterner);
            this.Controls.Add(this.BotonIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonIniciar;
        private System.Windows.Forms.Button BotonDeterner;
        private System.Windows.Forms.ProgressBar BarraProgreso;
        private System.Windows.Forms.Timer Temporizador;
    }
}

