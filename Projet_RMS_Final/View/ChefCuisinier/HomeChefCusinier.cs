using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_RMS_Final.View.ChefCuisinier
{
    public partial class HomeChefCusinier : Form
    {
        public HomeChefCusinier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowFormProduitUI();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e)
        {

            RMSApplication.Instance.ShowListProduits();
            this.Hide();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowHomeChefCuisinier();
            this.Hide();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowAuthentificationUI();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
