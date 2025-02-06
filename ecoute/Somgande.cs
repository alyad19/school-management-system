using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecoute
{
    public partial class Somgande : Form
    {
        public Somgande()
        {
            InitializeComponent();
        }

        private void InscriptionButton_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.MdiParent = this;
            inscription.Show();
        }

        private void ElevesButton_Click(object sender, EventArgs e)
        {
            Eleves eleves = new Eleves();
            eleves.MdiParent = this;
            eleves.Show();
           
        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
