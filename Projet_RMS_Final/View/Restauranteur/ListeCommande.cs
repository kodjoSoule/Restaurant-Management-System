using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;
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

            LoadLigneCommande();
        }
        private void LoadLigneCommande()
        {
            List<LigneCommande> ligneCommande = ligneCommandeSqlDaoImpl.List();
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
        }

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
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void paiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesPaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void recetteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesRecettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
    }
}
