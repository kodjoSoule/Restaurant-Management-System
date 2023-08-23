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
    public partial class ListeProduitRestauranteur : Form
    {
        ProduitSqlDaoImpl produitSqlDao = new ProduitSqlDaoImpl();
        Produit selectedProduit;
        public ListeProduitRestauranteur()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadProducts();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            this.Hide();
        }
        private void LoadProducts()
        {
            List<Produit> produits = produitSqlDao.List();
            dataGridView.DataSource = produits;

            // Masquer la colonne de l'image
            dataGridView.Columns["Image"].Visible = false;

        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            FormCommande formCommande = new FormCommande(selectedProduit);
            formCommande.Show();
            this.Hide();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0) // Vérifie si au moins une ligne est sélectionnée
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0]; // Récupère la première ligne sélectionnée

                if (selectedRow.DataBoundItem is Produit selectedProduct) // Vérifie si l'objet lié à la ligne est de type Produit
                {
                    selectedProduit = selectedProduct; // Stocke le produit sélectionné dans la variable selectedProduit

                    // Affichez les détails du produit dans les contrôles appropriés


                    pictureBox1.Image = ConvertBytesToImage(selectedProduct.Image);
                }
            }
        }

        private Image ConvertBytesToImage(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selle
        }

        private void ListeProduitRestauranteur_Load(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.quitter();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.Deconnexion(this);
        }
    }
}
