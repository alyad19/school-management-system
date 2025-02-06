namespace ecoute
{
    partial class Paiement
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
            this.label1 = new System.Windows.Forms.Label();
            this.ScolariteTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResteTxtBox = new System.Windows.Forms.TextBox();
            this.MontantTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PayerButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frais de Scolarité";
            // 
            // ScolariteTxtBox
            // 
            this.ScolariteTxtBox.Location = new System.Drawing.Point(206, 33);
            this.ScolariteTxtBox.Name = "ScolariteTxtBox";
            this.ScolariteTxtBox.ReadOnly = true;
            this.ScolariteTxtBox.Size = new System.Drawing.Size(222, 26);
            this.ScolariteTxtBox.TabIndex = 1;
            this.ScolariteTxtBox.TextChanged += new System.EventHandler(this.ScolariteTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reste à régler";
            // 
            // ResteTxtBox
            // 
            this.ResteTxtBox.Location = new System.Drawing.Point(206, 112);
            this.ResteTxtBox.Name = "ResteTxtBox";
            this.ResteTxtBox.ReadOnly = true;
            this.ResteTxtBox.Size = new System.Drawing.Size(222, 26);
            this.ResteTxtBox.TabIndex = 3;
            this.ResteTxtBox.TextChanged += new System.EventHandler(this.ResteTxtBox_TextChanged);
            // 
            // MontantTxtBox
            // 
            this.MontantTxtBox.Location = new System.Drawing.Point(206, 188);
            this.MontantTxtBox.Name = "MontantTxtBox";
            this.MontantTxtBox.Size = new System.Drawing.Size(222, 26);
            this.MontantTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant";
            // 
            // PayerButton
            // 
            this.PayerButton.Location = new System.Drawing.Point(206, 372);
            this.PayerButton.Name = "PayerButton";
            this.PayerButton.Size = new System.Drawing.Size(159, 43);
            this.PayerButton.TabIndex = 6;
            this.PayerButton.Text = "Payer";
            this.PayerButton.UseVisualStyleBackColor = true;
            this.PayerButton.Click += new System.EventHandler(this.PayerButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PayerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MontantTxtBox);
            this.Controls.Add(this.ResteTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScolariteTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Paiement";
            this.Text = "Paiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScolariteTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResteTxtBox;
        private System.Windows.Forms.TextBox MontantTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PayerButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}