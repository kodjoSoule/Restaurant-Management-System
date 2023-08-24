using Projet_RMS_Final.View.Restauranteur;

namespace Projet_RMS_Final.View.ChefCuisinier
{
    public partial class HomeChefCusinier : Form
    {
        public HomeChefCusinier()
        {
            InitializeComponent();
            labelUtilisateur.Text = RMSApplication.Instance.User.ToString();
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
            Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e)
        {

            RMSApplication.Instance.ShowListProduits();
            Close();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowHomeChefCuisinier();
            Close();
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

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
            Close();

        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduit formProduit = new FormProduit();
            formProduit.Show();
            Close();
        }
    }
}
