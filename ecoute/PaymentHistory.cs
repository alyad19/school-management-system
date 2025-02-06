using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ecoute
{
    public partial class PaymentHistory : Form
    {
        public int EleveID { get; set; }

        public PaymentHistory(int eleveId)
        {
            InitializeComponent();
            EleveID = eleveId;
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            LoadPaymentHistory();

            if (dataGridViewHistorique.Columns["Montant"] != null)
            {
                dataGridViewHistorique.Columns["Montant"].HeaderText = "Montant Payé";
                dataGridViewHistorique.Columns["Montant"].DefaultCellStyle.Format = "C"; // Currency format
            }

            if (dataGridViewHistorique.Columns["Date"] != null)
            {
                dataGridViewHistorique.Columns["Date"].HeaderText = "Date du Paiement";
                dataGridViewHistorique.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Date format
            }

        }

        private void LoadPaymentHistory()
        {
            string connectionString = @"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True";
            string query = @"
            SELECT Amount, Date
            FROM payments_tab
            WHERE EleveID = @EleveID
            ORDER BY Date DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EleveID", EleveID);
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        conn.Open();
                        adapter.Fill(dataTable);

                        dataGridViewHistorique.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No payment history found for this student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading payment history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

    }
}


