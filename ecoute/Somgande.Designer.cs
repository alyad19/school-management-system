namespace ecoute
{
    partial class Somgande
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InscriptionButton = new System.Windows.Forms.Button();
            this.ClassesButton = new System.Windows.Forms.Button();
            this.ElevesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 31);
            this.panel1.TabIndex = 0;
            // 
            // InscriptionButton
            // 
            this.InscriptionButton.Location = new System.Drawing.Point(0, 0);
            this.InscriptionButton.Name = "InscriptionButton";
            this.InscriptionButton.Size = new System.Drawing.Size(254, 98);
            this.InscriptionButton.TabIndex = 1;
            this.InscriptionButton.Text = "Inscription";
            this.InscriptionButton.UseVisualStyleBackColor = true;
            this.InscriptionButton.Click += new System.EventHandler(this.InscriptionButton_Click);
            // 
            // ClassesButton
            // 
            this.ClassesButton.Location = new System.Drawing.Point(0, 192);
            this.ClassesButton.Name = "ClassesButton";
            this.ClassesButton.Size = new System.Drawing.Size(254, 109);
            this.ClassesButton.TabIndex = 3;
            this.ClassesButton.Text = "Classes";
            this.ClassesButton.UseVisualStyleBackColor = true;
            this.ClassesButton.Click += new System.EventHandler(this.ClassesButton_Click);
            // 
            // ElevesButton
            // 
            this.ElevesButton.Location = new System.Drawing.Point(0, 92);
            this.ElevesButton.Name = "ElevesButton";
            this.ElevesButton.Size = new System.Drawing.Size(247, 103);
            this.ElevesButton.TabIndex = 4;
            this.ElevesButton.Text = "Eleves";
            this.ElevesButton.UseVisualStyleBackColor = true;
            this.ElevesButton.Click += new System.EventHandler(this.ElevesButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClassesButton);
            this.panel2.Controls.Add(this.InscriptionButton);
            this.panel2.Controls.Add(this.ElevesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 731);
            this.panel2.TabIndex = 6;
            // 
            // Somgande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Somgande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Somgande";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InscriptionButton;
        private System.Windows.Forms.Button ClassesButton;
        private System.Windows.Forms.Button ElevesButton;
        private System.Windows.Forms.Panel panel2;
    }
}