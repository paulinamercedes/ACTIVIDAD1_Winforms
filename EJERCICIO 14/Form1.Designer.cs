namespace EJERCICIO_14
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
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.Pestaña1 = new System.Windows.Forms.TabPage();
            this.Pestaña2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabcontrol1.SuspendLayout();
            this.Pestaña1.SuspendLayout();
            this.Pestaña2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.Pestaña1);
            this.tabcontrol1.Controls.Add(this.Pestaña2);
            this.tabcontrol1.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontrol1.Location = new System.Drawing.Point(22, 23);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(726, 415);
            this.tabcontrol1.TabIndex = 0;
            // 
            // Pestaña1
            // 
            this.Pestaña1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Pestaña1.Controls.Add(this.label1);
            this.Pestaña1.Location = new System.Drawing.Point(8, 41);
            this.Pestaña1.Name = "Pestaña1";
            this.Pestaña1.Padding = new System.Windows.Forms.Padding(3);
            this.Pestaña1.Size = new System.Drawing.Size(710, 366);
            this.Pestaña1.TabIndex = 0;
            this.Pestaña1.Text = "Pestaña 1";
            // 
            // Pestaña2
            // 
            this.Pestaña2.BackColor = System.Drawing.Color.LavenderBlush;
            this.Pestaña2.Controls.Add(this.label2);
            this.Pestaña2.Location = new System.Drawing.Point(8, 41);
            this.Pestaña2.Name = "Pestaña2";
            this.Pestaña2.Padding = new System.Windows.Forms.Padding(3);
            this.Pestaña2.Size = new System.Drawing.Size(710, 366);
            this.Pestaña2.TabIndex = 1;
            this.Pestaña2.Text = "Pestaña 2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nEsta es la Pestaña 1 \r\nPaulina Mercedes R.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 101);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\nEsta es la Pestaña 2\r\nLR-2024-01435";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(809, 496);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabcontrol1.ResumeLayout(false);
            this.Pestaña1.ResumeLayout(false);
            this.Pestaña2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage Pestaña1;
        private System.Windows.Forms.TabPage Pestaña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

