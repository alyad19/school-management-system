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
    public partial class EleveDetails : Form
    {
        public EleveDetails()
        {
            InitializeComponent();
        }

        private void EleveDetails_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadEleveDetails(int eleveId)
        {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
            string studentQuery = "SELECT * FROM studentTab WHERE Id = @Id";
            string paymentQuery = @"
        SELECT TOP 1 Amount, Date
        FROM payments_tab
        WHERE EleveID = @EleveID
        ORDER BY Date DESC";

            string paymentSumQuery = @"
        SELECT ISNULL(SUM(Amount), 0) AS TotalPaid
        FROM payments_tab
        WHERE EleveID = @EleveID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                decimal fraisScolarite = 0;
                decimal totalPaid = 0;
                using (SqlCommand cmd = new SqlCommand(studentQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", eleveId);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNom.Text = reader["Nom"].ToString();
                            lblPrenom.Text = reader["Prenom"].ToString();
                            lblDateNaissance.Text = Convert.ToDateTime(reader["DateNaissance"]).ToString("dd/MM/yyyy");
                            lblGenre.Text = reader["Genre"].ToString();
                            lblParent.Text = reader["Parent"].ToString();
                            lblNumTel.Text = reader["NumTel"].ToString();
                            lblClasse.Text = reader["Classe"].ToString();
                            lblScolarite.Text = reader["Scolarite"].ToString();
                            lblID.Text = reader["ID"].ToString();

                            fraisScolarite = Convert.ToDecimal(reader["Scolarite"]);
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(paymentQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EleveID", eleveId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                           
                            lblDernierPaiement.Text = Convert.ToDateTime(reader["Date"]).ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            
                            lblDernierPaiement.Text = "N/A";
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(paymentSumQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EleveID", eleveId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalPaid = Convert.ToDecimal(reader["TotalPaid"]);
                        }
                    }
                }

                decimal remainingBalance = fraisScolarite - totalPaid;
                lblReste.Text = remainingBalance.ToString("C");
                lblPaye.Text = totalPaid.ToString("C");
            }


        }



        private void lblParent_Click(object sender, EventArgs e)
        {

        }

        private void buttonPaiement_Click(object sender, EventArgs e)
        {
            int eleveId=int.Parse(lblID.Text);
            decimal remainingBalance=decimal.Parse(lblReste.Text, System.Globalization.NumberStyles.Currency);
            Paiement paiement=new Paiement(remainingBalance, eleveId);
            paiement.LoadReste(remainingBalance);
            paiement.LoadFraisScolarite(eleveId);
            paiement.ShowDialog();
            LoadEleveDetails(eleveId);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_frais_scolarite_Click(object sender, EventArgs e)
        {

        }

        private void voir_histo_payment_Click(object sender, EventArgs e)
        {
            int eleveId = Convert.ToInt32(lblID.Text);

            PaymentHistory historiqueForm = new PaymentHistory(eleveId);
            historiqueForm.ShowDialog();
        }

        private void lblReste_Click(object sender, EventArgs e)
        {

        }
    }
}
