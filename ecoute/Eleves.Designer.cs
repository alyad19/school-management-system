namespace ecoute
{
    partial class Eleves
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ActualiserButton = new System.Windows.Forms.Button();
            this.RechercherButton = new System.Windows.Forms.Button();
            this.ClasseCmbBox = new System.Windows.Forms.ComboBox();
            this.NomTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrenomTxtBox = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.VoirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1072, 28);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 36);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ActualiserButton
            // 
            this.ActualiserButton.Location = new System.Drawing.Point(260, 94);
            this.ActualiserButton.Name = "ActualiserButton";
            this.ActualiserButton.Size = new System.Drawing.Size(111, 36);
            this.ActualiserButton.TabIndex = 2;
            this.ActualiserButton.Text = "Actualiser";
            this.ActualiserButton.UseVisualStyleBackColor = true;
            this.ActualiserButton.Click += new System.EventHandler(this.ActualiserButton_Click);
            // 
            // RechercherButton
            // 
            this.RechercherButton.Location = new System.Drawing.Point(815, 28);
            this.RechercherButton.Name = "RechercherButton";
            this.RechercherButton.Size = new System.Drawing.Size(183, 36);
            this.RechercherButton.TabIndex = 3;
            this.RechercherButton.Text = "Rechercher";
            this.RechercherButton.UseVisualStyleBackColor = true;
            this.RechercherButton.Click += new System.EventHandler(this.RechercherButton_Click);
            // 
            // ClasseCmbBox
            // 
            this.ClasseCmbBox.FormattingEnabled = true;
            this.ClasseCmbBox.Location = new System.Drawing.Point(580, 31);
            this.ClasseCmbBox.Name = "ClasseCmbBox";
            this.ClasseCmbBox.Size = new System.Drawing.Size(167, 28);
            this.ClasseCmbBox.TabIndex = 4;
            this.ClasseCmbBox.Text = "Classe";
            this.ClasseCmbBox.SelectedIndexChanged += new System.EventHandler(this.ClasseCmbBox_SelectedIndexChanged);
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.Location = new System.Drawing.Point(131, 28);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.Size = new System.Drawing.Size(109, 26);
            this.NomTxtBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrenomTxtBox
            // 
            this.PrenomTxtBox.Location = new System.Drawing.Point(368, 28);
            this.PrenomTxtBox.Name = "PrenomTxtBox";
            this.PrenomTxtBox.Size = new System.Drawing.Size(109, 26);
            this.PrenomTxtBox.TabIndex = 7;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(298, 34);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(64, 20);
            this.Prenom.TabIndex = 8;
            this.Prenom.Text = "Prenom";
            // 
            // VoirButton
            // 
            this.VoirButton.Location = new System.Drawing.Point(131, 85);
            this.VoirButton.Name = "VoirButton";
            this.VoirButton.Size = new System.Drawing.Size(73, 55);
            this.VoirButton.TabIndex = 10;
            this.VoirButton.Text = "Voir";
            this.VoirButton.UseVisualStyleBackColor = true;
            this.VoirButton.Click += new System.EventHandler(this.VoirButton_Click_1);
            // 
            // Eleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 699);
            this.Controls.Add(this.VoirButton);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.PrenomTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomTxtBox);
            this.Controls.Add(this.ClasseCmbBox);
            this.Controls.Add(this.RechercherButton);
            this.Controls.Add(this.ActualiserButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Eleves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eleves";
            this.Load += new System.EventHandler(this.Eleves_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ActualiserButton;
        private System.Windows.Forms.Button RechercherButton;
        private System.Windows.Forms.ComboBox ClasseCmbBox;
        private System.Windows.Forms.TextBox NomTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrenomTxtBox;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Button VoirButton;
    }
}