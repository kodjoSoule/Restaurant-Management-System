using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_RMS_Final.View.Restauranteur
{
    public partial class HomeRestauranteur : Form
    {
        public HomeRestauranteur()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            RMSApplication.Instance.ShowAuthentificationUI();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listeProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
