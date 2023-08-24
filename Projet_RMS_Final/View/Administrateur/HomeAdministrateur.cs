using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.View.Administrateur
{
    public partial class HomeAdministrateur : Form
    {
        Utilisateur utilisateur;
        public HomeAdministrateur()
        {
            InitializeComponent();
            labelUtilisateur.Text = RMSApplication.Instance.User.ToString();
        }

        internal void setUtilisateur(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            if (utilisateur != null)
            {
                labelUser.Text = this.utilisateur.Prenom + " " + utilisateur.Nom;
            }
        }

        private void HomeAdministrateur_Load(object sender, EventArgs e)
        {

        }

        private void labelUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowAuthentificationUI();
            this.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowListeUtilisateurUI();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowListeUtilisateurUI();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeAdministrateur homeAdministrateur = new HomeAdministrateur();
            homeAdministrateur.Show();
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

        private void listesDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListeUtilisateurForm listeUtilisateurForm = new ListeUtilisateurForm();
            listeUtilisateurForm.Show();
            Close();
        }

        private void ajouterUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeUtilisateurForm listeUtilisateurForm = new ListeUtilisateurForm();
            listeUtilisateurForm.Show();
            Close();
        }

    }
}
