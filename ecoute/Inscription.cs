using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ecoute
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inscription_Load);
            cmbClasse.SelectedIndexChanged += new EventHandler(cmbClasse_SelectedIndexChanged);
            cmbGenre.SelectedIndexChanged += new EventHandler(cmbGenre_SelectedIndexChanged);
            
            
        }

       

        private void Inscription_Load(object sender, EventArgs e)
        {
            cmbGenre.Items.Add("Garcon");
            cmbGenre.Items.Add("Fille");

            cmbClasse.Items.Add("CE1");
            cmbClasse.Items.Add("CP1");
            cmbClasse.Items.Add("CP2");
            cmbClasse.Items.Add("3eme");
            cmbClasse.Items.Add("2nde");
            cmbClasse.Items.Add("1ere");
            cmbClasse.Items.Add("Tle");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }
        private int GetFraisScolarite(string classe)
        {
            int frais = 0;
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb; Integrated Security=True";
            string query = "SELECT Frais FROM Scolarite WHERE Classe = @Classe";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Classe", classe);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        frais = Convert.ToInt32(result);
                    }

                }
            }
            return frais;
        }

       

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedItem!=null)
            {
                string selectedClasse = cmbClasse.SelectedItem.ToString();


                int frais = GetFraisScolarite(selectedClasse);
                txtScolarite.Text = frais.ToString();
            }
            
            
           
            else
            {
                Console.WriteLine("SelectedItem is null");
                Console.WriteLine("Items count: " + cmbClasse.Items.Count);
                Console.WriteLine("SelectedIndex:" + cmbClasse.SelectedIndex);


                        txtScolarite.Text = string.Empty; // or handle the case where no item is selected
            }
        }
    

       

        private void InscrireButton_Click(object sender, EventArgs e)
        {
            InscrireButton.Enabled = false;

            try
            {

                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                DateTime dateNaissance = dateTimePicker1.Value;
                string genre = cmbGenre.SelectedItem.ToString();
                string parent = textBoxParent.Text;
                string numTel = textBoxNum.Text;
                string classe = cmbClasse.SelectedItem.ToString();

                if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(genre) ||
                   string.IsNullOrEmpty(parent) || string.IsNullOrEmpty(numTel) || string.IsNullOrEmpty(classe))
                {
                    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int scolarite = GetFraisScolarite(classe);

                if (!EleveExiste(nom,prenom,dateNaissance,parent))
                {
                    string query = "INSERT INTO studentTab(Nom,Prenom,DateNaissance,Genre,Parent,NumTel,Classe,Scolarite) VALUES(@Nom,@Prenom,@DateNaissance,@Genre,@Parent,@NumTel,@Classe,@Scolarite)";


                    using (SqlConnection con = new SqlConnection(@"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True"))
                    {
                        using (SqlCommand cmd2 = new SqlCommand(query, con))
                        {
                            cmd2.Parameters.AddWithValue("@Nom", nom);
                            cmd2.Parameters.AddWithValue("@Prenom", prenom);
                            cmd2.Parameters.AddWithValue("@Genre", genre);
                            cmd2.Parameters.AddWithValue("@Parent", parent);
                            cmd2.Parameters.AddWithValue("@NumTel", numTel);
                            cmd2.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                            cmd2.Parameters.AddWithValue("@Classe", classe);
                            cmd2.Parameters.AddWithValue("@Scolarite", scolarite);

                            con.Open();
                            cmd2.ExecuteNonQuery();
                            con.Close();

                        }
                    }
                    MessageBox.Show("Inscription réussie", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNom.Text= string.Empty;
                    textBoxPrenom.Text = string.Empty;
                    textBoxParent.Text = string.Empty;
                    textBoxNum.Text = string.Empty;
                    txtScolarite.Text = string.Empty;
                    cmbClasse.SelectedIndex = -1;
                    cmbGenre.SelectedIndex = -1;
                    dateTimePicker1.Value = DateTime.Now;

                }

                else
                {

                    MessageBox.Show("Cet élève existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {                 InscrireButton.Enabled = true;
            }
            
        }

        private bool EleveExiste(string nom,string prenom, DateTime dateNaissance, string parent)
        {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM studentTab WHERE Nom = @Nom AND Prenom = @Prenom AND DateNaissance = @dateNaissance AND Parent = @parent";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Prenom", prenom);
                    cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                    cmd.Parameters.AddWithValue("@Parent", parent);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }




        private void label7_Click(object sender, EventArgs e) 
        {

        }

        private void cmbClasse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void Inscription_Load_1(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
           
            Somgande somgande = new Somgande();
            somgande.Show();
            this.Close();
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScolarite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

