using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;
using Projet_RMS_Final.View.ChefCuisinier;
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
    public partial class ListeCommande : Form
    {
        CommandeSqlDaoImpl commandeSqlDaoImpl = new CommandeSqlDaoImpl();
        ProduitSqlDaoImpl produitSqlDaoImpl = new ProduitSqlDaoImpl();
        LigneCommandeSqlDaoImpl ligneCommandeSqlDaoImpl = new LigneCommandeSqlDaoImpl();

        LigneCommande ligneCommande = new LigneCommande();
        Produit selectedProduit;
        Commande selectedCommande;
        public ListeCommande()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //LoadLigneCommande();
            LoadLinkedData();
            dataGridView.Columns["Id"].Width = 60;
            dataGridView.Columns["ProduitPrix"].Width = 100;
            dataGridView.Columns["CommandeDate"].Width = 300;
        }

        private void LoadLinkedData()
        {
            List<Tuple<Commande, Client, Produit, LigneCommande>> linkedData = ligneCommandeSqlDaoImpl.GetAllLinkedData();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            //dataTable.Columns.Add("ProduitId");
            dataTable.Columns.Add("ProduitNom");
            dataTable.Columns.Add("ProduitPrix");

            dataTable.Columns.Add("Quantite");
            dataTable.Columns.Add("MontantTotalCommande");

            dataTable.Columns.Add("CommandeDate");
            dataTable.Columns.Add("CommandeStatus");
            //dataTable.Columns.Add("ClientId");
            dataTable.Columns.Add("ClientNom");
            dataTable.Columns.Add("ClientPrenom");
            dataTable.Columns.Add("ClientEmail");


            //MontantTotalCommande

            foreach (var tuple in linkedData)
            {
                dataTable.Rows.Add(
                    tuple.Item4.Id,
                    //tuple.Item3.Id,
                    tuple.Item3.Intitule,
                    tuple.Item3.Prix,
                    tuple.Item4.Quantite,
                    tuple.Item1.MontantTotalCommande,

                    tuple.Item1.Date,
                    tuple.Item1.Status,
                    //tuple.Item2.Id,
                    tuple.Item2.Nom,
                    tuple.Item2.Prenom,
                    tuple.Item2.Email



                );
            }

            dataGridView.DataSource = dataTable;
        }

        private void LoadLigneCommande()
        {
            List<LigneCommande> ligneCommande = ligneCommandeSqlDaoImpl.List();
            //List<Commande> ligneCommande = commandeSqlDaoImpl.List();
            dataGridView.DataSource = ligneCommande;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            this.Hide();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtenez la ligne de commande sélectionnée dans le DataGridView
                int idLigneCommande = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                
                LigneCommande selectedLigneCommande = ligneCommandeSqlDaoImpl.Read(idLigneCommande);
                
                // Passez la ligne de commande à la fenêtre FormPaiement
                FormPaiement formPaiement = new FormPaiement(selectedLigneCommande);
                DialogResult dialogResult = formPaiement.ShowDialog();
                _ = dialogResult;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande pour effectuer le paiement.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            this.Hide();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.Deconnexion(this);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.quitter();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduits listeProduits = new ListeProduits();
            listeProduits.Show();
            this.Hide();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeCommande listeCommande = new ListeCommande();
            listeCommande.Show();
            this.Hide();
        }

        private void paiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesPaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePaiement listePaiement = new ListePaiement();
            listePaiement.Show();
            this.Hide();
        }

        private void recetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListePaiement recette = new ListePaiement();
            recette.Show();
            this.Hide();
        }

        private void listeDesRecettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    // Obtenez l'ID de la commande sélectionnée dans le DataGridView
                    int commandeId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);

                    // Appelez la méthode de suppression de la commande
                    commandeSqlDaoImpl.Delete1(commandeId);

                    // Rechargez les données pour mettre à jour la liste
                    LoadLinkedData();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une commande à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
