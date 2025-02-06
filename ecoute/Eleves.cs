using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecoute
{
    public partial class Eleves : Form
    {
        public Eleves()
        {
            InitializeComponent();
            this.Load += new EventHandler(Eleves_Load);
            
           
            ClasseCmbBox.SelectedIndexChanged += new EventHandler(ClasseCmbBox_SelectedIndexChanged);
            
           
           
        }

        public void Eleves_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            ClassesLoad();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButton.Enabled = false;
            
            if (dataGridView1.SelectedRows.Count >0)
            {
               
                int eleveID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string query = "DELETE FROM studentTab WHERE Id = @Id";
                using (SqlConnection conn = new SqlConnection(@"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", eleveID);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                MessageBox.Show("Elève supprimé avec succès");
                LoadStudentData();
               
            }
            else
            {
                MessageBox.Show("Sélectionnez un élève à supprimer");
            }
            
            DeleteButton.Enabled = true;
            

        }

        private void LoadStudentData()
        {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb; Integrated Security=True";
            string query = "SELECT * FROM studentTab";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {


                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void ClassesLoad()
        {
            ClasseCmbBox.Items.Add("CE1");
            ClasseCmbBox.Items.Add("CP1");
            ClasseCmbBox.Items.Add("CP2");
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ActualiserButton_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

       private void LoadEleveCherche(string nom, string prenom, string classe)
       {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
            string query = "SELECT * FROM studentTab WHERE Nom LIKE @Nom AND Prenom LIKE @Prenom AND Classe LIKE @Classe";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {


                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Nom", "%" + nom + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@Prenom", "%" + prenom + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@Classe", "%" + classe + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
       }
        private bool EleveExiste(string nom, string prenom)
        {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM studentTab WHERE Nom = @Nom AND Prenom = @Prenom";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Prenom", prenom);
                    
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void RechercherButton_Click(object sender, EventArgs e)
        {
            
            string nom = NomTxtBox.Text.Trim();
            string prenom = PrenomTxtBox.Text.Trim();
            string classe = ClasseCmbBox.SelectedItem != null ? ClasseCmbBox.SelectedItem.ToString() : "";
            if (EleveExiste(nom, prenom))
                {
                LoadEleveCherche(nom, prenom, classe);
                }
        
                
            else
            {
                MessageBox.Show("Aucun élève trouvé");
            }
            
        }

        private void ClasseCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClasseCmbBox.Items.Add("CE1");
            ClasseCmbBox.Items.Add("CP1");
            ClasseCmbBox.Items.Add("CP2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void VoirButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int eleveId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                EleveDetails eleveDetails = new EleveDetails();
                eleveDetails.LoadEleveDetails(eleveId);
                eleveDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionnez un élève à voir");
            }
        }

        private void Eleves_Load_1(object sender, EventArgs e)
        {

        }
    }
    
}
