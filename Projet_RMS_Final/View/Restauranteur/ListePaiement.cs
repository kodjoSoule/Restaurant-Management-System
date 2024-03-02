using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projet_RMS_Final.View.Restauranteur
{
    public partial class ListePaiement : Form
    {
        private PaiementSqlDaoImpl paiementDao = new PaiementSqlDaoImpl();
        private List<Paiement> paiements;

        public ListePaiement()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Ajoutez les éléments à la ComboBox
            comboBox1.Items.Add("Journalier");
            comboBox1.Items.Add("Hebdomadaire");
            comboBox1.Items.Add("Mensuel");

            LoadPaiements();
            dataGridView.Columns["DatePaiement"].Width = 300;
            //dataGridView.Columns["CommandeId"].
            // Masquer la colonne de l'image

        }

        private void ListePaiement_Load(object sender, EventArgs e)
        {
            LoadPaiements();
        }

        private void LoadPaiements()
        {
            try
            {
                paiements = paiementDao.List();

                // Assurez-vous d'avoir une DataGridView dans votre formulaire avec le nom dataGridViewPaiements
                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = paiements;
                //dataGridView.Columns["Commande_id"].Visible = false;

                // Calculer le total des paiements
                double totalPaiements = paiements.Sum(p => p.MontantPayer);

                // Afficher le total dans le label
                labelTotal.Text = "Total des paiements : " + totalPaiements + " FCFA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des paiements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            Close();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
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

        private void listeDesCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            Close();
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeCommande listeCommande = new ListeCommande();
            listeCommande.Show();
            Close();
        }

        private void listeDesPaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePaiement listePaiement = new ListePaiement();
            listePaiement.Show();
            Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Journalier")
            {
                // Chargez les paiements journaliers
                LoadPaiementsByDateRange(DateTime.Today, DateTime.Today);
            }
            else if (comboBox1.SelectedItem.ToString() == "Hebdomadaire")
            {
                // Calculez les dates de début et de fin de la semaine en cours
                DateTime today = DateTime.Today;
                DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                // Chargez les paiements hebdomadaires
                LoadPaiementsByDateRange(startOfWeek, endOfWeek);
            }
            else if (comboBox1.SelectedItem.ToString() == "Mensuel")
            {
                // Calculez les dates de début et de fin du mois en cours
                DateTime today = DateTime.Today;
                DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                // Chargez les paiements mensuels
                LoadPaiementsByDateRange(startOfMonth, endOfMonth);
            }
        }


        private void LoadPaiementsByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                paiements = paiementDao.GetPaiementsByDateRange(startDate, endDate);

                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = paiements;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du chargement des paiements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
