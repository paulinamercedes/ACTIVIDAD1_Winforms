namespace EJERCICIO_7
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
            this.textoElemento = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.listaElementos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textoElemento
            // 
            this.textoElemento.BackColor = System.Drawing.Color.Thistle;
            this.textoElemento.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoElemento.Location = new System.Drawing.Point(35, 50);
            this.textoElemento.Name = "textoElemento";
            this.textoElemento.Size = new System.Drawing.Size(214, 44);
            this.textoElemento.TabIndex = 0;
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.Plum;
            this.botonAgregar.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(35, 129);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(214, 59);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar ";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // listaElementos
            // 
            this.listaElementos.BackColor = System.Drawing.Color.Thistle;
            this.listaElementos.Font = new System.Drawing.Font("Baskerville Old Face", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaElementos.FormattingEnabled = true;
            this.listaElementos.ItemHeight = 31;
            this.listaElementos.Location = new System.Drawing.Point(308, 50);
            this.listaElementos.Name = "listaElementos";
            this.listaElementos.Size = new System.Drawing.Size(408, 128);
            this.listaElementos.TabIndex = 3;
            this.listaElementos.SelectedIndexChanged += new System.EventHandler(this.listaElementos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.listaElementos);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textoElemento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoElemento;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ListBox listaElementos;
    }
}

