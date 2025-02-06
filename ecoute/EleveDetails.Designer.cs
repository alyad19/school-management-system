namespace ecoute
{
    partial class EleveDetails
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblPaye = new System.Windows.Forms.Label();
            this.lblScolarite = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblReste = new System.Windows.Forms.Label();
            this.lblDernierPaiement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPaiement = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prénom = new System.Windows.Forms.Label();
            this.label_date_naissance = new System.Windows.Forms.Label();
            this.label_classe = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_parent = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_num_tel = new System.Windows.Forms.Label();
            this.label_frais_scolarite = new System.Windows.Forms.Label();
            this.label_txt_dernierpaiement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_resteàpayer = new System.Windows.Forms.Label();
            this.voir_histo_payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(273, 148);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(99, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom_affiche";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(272, 223);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(121, 20);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom_affiche";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(273, 302);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(144, 20);
            this.lblDateNaissance.TabIndex = 2;
            this.lblDateNaissance.Text = "Date de Naissance";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(273, 487);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(273, 590);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(56, 20);
            this.lblParent.TabIndex = 4;
            this.lblParent.Text = "Parent";
            this.lblParent.Click += new System.EventHandler(this.lblParent_Click);
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(273, 681);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(162, 20);
            this.lblNumTel.TabIndex = 5;
            this.lblNumTel.Text = "Numéro de téléphone";
            // 
            // lblPaye
            // 
            this.lblPaye.AutoSize = true;
            this.lblPaye.Location = new System.Drawing.Point(821, 302);
            this.lblPaye.Name = "lblPaye";
            this.lblPaye.Size = new System.Drawing.Size(107, 20);
            this.lblPaye.TabIndex = 6;
            this.lblPaye.Text = "Montant réglé";
            // 
            // lblScolarite
            // 
            this.lblScolarite.AutoSize = true;
            this.lblScolarite.Location = new System.Drawing.Point(821, 223);
            this.lblScolarite.Name = "lblScolarite";
            this.lblScolarite.Size = new System.Drawing.Size(129, 20);
            this.lblScolarite.TabIndex = 7;
            this.lblScolarite.Text = "Frais de scolarité";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(272, 388);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(57, 20);
            this.lblClasse.TabIndex = 8;
            this.lblClasse.Text = "Classe";
            // 
            // lblReste
            // 
            this.lblReste.AutoSize = true;
            this.lblReste.Location = new System.Drawing.Point(821, 400);
            this.lblReste.Name = "lblReste";
            this.lblReste.Size = new System.Drawing.Size(108, 20);
            this.lblReste.TabIndex = 9;
            this.lblReste.Text = "Reste à payer";
            this.lblReste.Click += new System.EventHandler(this.lblReste_Click);
            // 
            // lblDernierPaiement
            // 
            this.lblDernierPaiement.AutoSize = true;
            this.lblDernierPaiement.Location = new System.Drawing.Point(821, 487);
            this.lblDernierPaiement.Name = "lblDernierPaiement";
            this.lblDernierPaiement.Size = new System.Drawing.Size(132, 20);
            this.lblDernierPaiement.TabIndex = 10;
            this.lblDernierPaiement.Text = "Dernier Paiement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Historique des paiements";
            // 
            // buttonPaiement
            // 
            this.buttonPaiement.Location = new System.Drawing.Point(623, 672);
            this.buttonPaiement.Name = "buttonPaiement";
            this.buttonPaiement.Size = new System.Drawing.Size(165, 39);
            this.buttonPaiement.TabIndex = 12;
            this.buttonPaiement.Text = "Paiement";
            this.buttonPaiement.UseVisualStyleBackColor = true;
            this.buttonPaiement.Click += new System.EventHandler(this.buttonPaiement_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(273, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "lblID";
            this.lblID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(70, 158);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(42, 20);
            this.label_nom.TabIndex = 14;
            this.label_nom.Text = "Nom";
            // 
            // label_prénom
            // 
            this.label_prénom.AutoSize = true;
            this.label_prénom.Location = new System.Drawing.Point(67, 234);
            this.label_prénom.Name = "label_prénom";
            this.label_prénom.Size = new System.Drawing.Size(64, 20);
            this.label_prénom.TabIndex = 15;
            this.label_prénom.Text = "Prénom";
            // 
            // label_date_naissance
            // 
            this.label_date_naissance.AutoSize = true;
            this.label_date_naissance.Location = new System.Drawing.Point(67, 302);
            this.label_date_naissance.Name = "label_date_naissance";
            this.label_date_naissance.Size = new System.Drawing.Size(144, 20);
            this.label_date_naissance.TabIndex = 16;
            this.label_date_naissance.Text = "Date de Naissance";
            // 
            // label_classe
            // 
            this.label_classe.AutoSize = true;
            this.label_classe.Location = new System.Drawing.Point(67, 388);
            this.label_classe.Name = "label_classe";
            this.label_classe.Size = new System.Drawing.Size(57, 20);
            this.label_classe.TabIndex = 17;
            this.label_classe.Text = "Classe";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(67, 487);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(54, 20);
            this.label_genre.TabIndex = 18;
            this.label_genre.Text = "Genre";
            // 
            // label_parent
            // 
            this.label_parent.AutoSize = true;
            this.label_parent.Location = new System.Drawing.Point(70, 590);
            this.label_parent.Name = "label_parent";
            this.label_parent.Size = new System.Drawing.Size(56, 20);
            this.label_parent.TabIndex = 19;
            this.label_parent.Text = "Parent";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(65, 57);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(26, 20);
            this.label_id.TabIndex = 20;
            this.label_id.Text = "ID";
            // 
            // label_num_tel
            // 
            this.label_num_tel.AutoSize = true;
            this.label_num_tel.Location = new System.Drawing.Point(65, 681);
            this.label_num_tel.Name = "label_num_tel";
            this.label_num_tel.Size = new System.Drawing.Size(162, 20);
            this.label_num_tel.TabIndex = 21;
            this.label_num_tel.Text = "Numéro de téléphone";
            // 
            // label_frais_scolarite
            // 
            this.label_frais_scolarite.AutoSize = true;
            this.label_frais_scolarite.Location = new System.Drawing.Point(619, 223);
            this.label_frais_scolarite.Name = "label_frais_scolarite";
            this.label_frais_scolarite.Size = new System.Drawing.Size(129, 20);
            this.label_frais_scolarite.TabIndex = 22;
            this.label_frais_scolarite.Text = "Frais de scolarité";
            this.label_frais_scolarite.Click += new System.EventHandler(this.label_frais_scolarite_Click);
            // 
            // label_txt_dernierpaiement
            // 
            this.label_txt_dernierpaiement.AutoSize = true;
            this.label_txt_dernierpaiement.Location = new System.Drawing.Point(619, 487);
            this.label_txt_dernierpaiement.Name = "label_txt_dernierpaiement";
            this.label_txt_dernierpaiement.Size = new System.Drawing.Size(132, 20);
            this.label_txt_dernierpaiement.TabIndex = 23;
            this.label_txt_dernierpaiement.Text = "Dernier Paiement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Montant réglé";
            // 
            // label_resteàpayer
            // 
            this.label_resteàpayer.AutoSize = true;
            this.label_resteàpayer.Location = new System.Drawing.Point(618, 400);
            this.label_resteàpayer.Name = "label_resteàpayer";
            this.label_resteàpayer.Size = new System.Drawing.Size(108, 20);
            this.label_resteàpayer.TabIndex = 25;
            this.label_resteàpayer.Text = "Reste à payer";
            // 
            // voir_histo_payment
            // 
            this.voir_histo_payment.Location = new System.Drawing.Point(825, 565);
            this.voir_histo_payment.Name = "voir_histo_payment";
            this.voir_histo_payment.Size = new System.Drawing.Size(75, 34);
            this.voir_histo_payment.TabIndex = 26;
            this.voir_histo_payment.Text = "Voir";
            this.voir_histo_payment.UseVisualStyleBackColor = true;
            this.voir_histo_payment.Click += new System.EventHandler(this.voir_histo_payment_Click);
            // 
            // EleveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 762);
            this.Controls.Add(this.voir_histo_payment);
            this.Controls.Add(this.label_resteàpayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_txt_dernierpaiement);
            this.Controls.Add(this.label_frais_scolarite);
            this.Controls.Add(this.label_num_tel);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_parent);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_classe);
            this.Controls.Add(this.label_date_naissance);
            this.Controls.Add(this.label_prénom);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.buttonPaiement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDernierPaiement);
            this.Controls.Add(this.lblReste);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblScolarite);
            this.Controls.Add(this.lblPaye);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "EleveDetails";
            this.Text = "EleveDetails";
            this.Load += new System.EventHandler(this.EleveDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.Label lblPaye;
        private System.Windows.Forms.Label lblScolarite;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblReste;
        private System.Windows.Forms.Label lblDernierPaiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPaiement;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prénom;
        private System.Windows.Forms.Label label_date_naissance;
        private System.Windows.Forms.Label label_classe;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_parent;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_num_tel;
        private System.Windows.Forms.Label label_frais_scolarite;
        private System.Windows.Forms.Label label_txt_dernierpaiement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_resteàpayer;
        private System.Windows.Forms.Button voir_histo_payment;
    }
}