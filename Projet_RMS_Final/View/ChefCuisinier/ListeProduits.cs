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

namespace Projet_RMS_Final.View.ChefCuisinier
{
    public partial class ListeProduits : Form
    {
        ProduitSqlDaoImpl produitSqlDao = new ProduitSqlDaoImpl();
        Produit selectedProduit;
        public ListeProduits()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadProducts();

        }
        private void LoadProducts()
        {
            List<Produit> produits = produitSqlDao.List();
            dataGridView.DataSource = produits;

            // Masquer la colonne de l'image
            dataGridView.Columns["Image"].Visible = false;

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {

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



        private void iconButton1_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowHomeChefCuisinier();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowFormProduitUI();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedProduit != null)
            {
                // Ouvrir un formulaire de modification avec les détails du produit sélectionné
                // Utilisez le formulaire approprié pour effectuer la modification
                FormProduit formModification = new FormProduit(selectedProduit);
                formModification.Show();
                this.Hide();
                // Après la modification, rechargez la liste des produits
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit à modifier.",
                                "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListeProduits_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dataGridView.SelectedRows.Count > 0) // Vérifie si au moins une ligne est sélectionnée
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0]; // Récupère la première ligne sélectionnée

                if (selectedRow.DataBoundItem is Produit selectedProduct) // Vérifie si l'objet lié à la ligne est de type Produit
                {
                    // Affiche les détails du produit dans des contrôles appr  opriés (TextBox, Labels, etc.)
                    //textBoxIntitule.Text = selectedProduct.Intitule;B
                    //textBoxPrix.Text = selectedProduct.Prix.ToString();
                    //textBoxDescription.Text = selectedProduct.Description;
                    //comboBoxCategorie.SelectedItem = selectedProduct.Categorie; // Assurez-vous d'implémenter la méthode Equals dans votre enum

                    // Affiche l'image du produit dans le PictureBox
                    pictureBox1.Image = ConvertBytesToImage(selectedProduct.Image);
                }
            }
            */
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedProduit != null)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        produitSqlDao.Delete(selectedProduit.Id);
                        MessageBox.Show("Produit supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rechargez la liste des produits après la suppression
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                                        "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit à supprimer.",
                                "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
