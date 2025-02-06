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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ALYAPC\SQLEXPRESS;Initial Catalog=schooldb;Integrated Security=True");
            con.Open();
            string username=textBoxUsername.Text;
            string password=textBoxMdp.Text;
            SqlCommand cmd = new SqlCommand("select Username,Password from logintab where username='"+textBoxUsername.Text+"' and password='"+textBoxMdp.Text+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Somgande somgande = new Somgande();
                somgande.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou Mot de passe invalide");
            }
            con.Close();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
