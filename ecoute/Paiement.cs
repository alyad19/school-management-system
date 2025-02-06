using System;
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
    public partial class Paiement : Form
    {
        private decimal remainingBalance;
        private int eleveId;
        private string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
        public Paiement(decimal remainingBalance, int eleveId)
        {
            InitializeComponent();
            this.remainingBalance = remainingBalance;
            this.eleveId=eleveId;

        }

        private void Paiement_Load(object sender, EventArgs e)
        {
            ResteTxtBox.Text= remainingBalance.ToString("C");
        }

        public void LoadFraisScolarite(int eleveId)
        {
            
            string query = "SELECT * FROM studentTab WHERE Id = @Id";
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", eleveId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ScolariteTxtBox.Text = reader["Scolarite"].ToString();


                        }

                    }
                }
                
            }
        }

        public void LoadReste(decimal remainingBalance) {


            ResteTxtBox.Text = remainingBalance.ToString("C");

        }





        private void ScolariteTxtBox_TextChanged(object sender, EventArgs e)
        {
          
      
                            
        }

        private void ResteTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayerButton_Click(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(MontantTxtBox.Text);
            if (montant>remainingBalance)
            {
                MessageBox.Show("Le montant payé dépasse le reste à payer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            { 
                conn.Open();
                string query = @"INSERT INTO payments_tab (EleveID, Amount, Date)
                VALUES (@EleveID, @Amount, @Date)";


                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@EleveID", eleveId);
                    cmd.Parameters.AddWithValue("@Amount", montant);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }


            remainingBalance -= montant;
            ResteTxtBox.Text = remainingBalance.ToString();
            MessageBox.Show("Paiement effectué avec succès !", "Succès", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
