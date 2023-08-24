namespace Projet_RMS_Final.View.Restauranteur
{
    public partial class HomeRestauranteur : Form
    {
        public HomeRestauranteur()
        {
            InitializeComponent();

            labelUtilisateur.Text = RMSApplication.Instance.User.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListeCommande listeCommande = new ListeCommande();
            listeCommande.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeCommande listeCommande = new ListeCommande();
            listeCommande.Show();
            Close();
        }

        private void listeDesCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
            Close();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.Deconnexion(this);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.quitter();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
            Close();
        }

        private void listeDesPaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePaiement listePaiement = new ListePaiement();
            listePaiement.Show();
            Close();
        }
    }
}
