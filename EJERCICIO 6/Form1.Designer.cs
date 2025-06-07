namespace EJERCICIO_6
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
            this.comboBoxColores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxColores
            // 
            this.comboBoxColores.Font = new System.Drawing.Font("Baskerville Old Face", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColores.FormattingEnabled = true;
            this.comboBoxColores.Location = new System.Drawing.Point(266, 173);
            this.comboBoxColores.Name = "comboBoxColores";
            this.comboBoxColores.Size = new System.Drawing.Size(231, 51);
            this.comboBoxColores.TabIndex = 0;
            this.comboBoxColores.SelectedIndexChanged += new System.EventHandler(this.comboBoxColores_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColores;
    }
}

