using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;

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
            dataGridView.Columns["QuantiteStock"].Visible = false;

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
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowFormProduitUI();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedProduit != null)
            {
                // Ouvrir un formulaire de modification avec les détails du produit sélectionné
                // Utilisez le formulaire approprié pour effectuer la modification
                FormProduit formModification = new FormProduit(selectedProduit);
                formModification.Show();
                Close();
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
                string searchText = textBoxSearch.Text.ToLower();

                try
                {
                    List<Produit> produits = produitSqlDao.List();

                    List<Produit> filteredProduits = produits.Where(p =>
                        p.Intitule.ToLower().Contains(searchText) ||
                        p.Description.ToLower().Contains(searchText) ||
                        p.Categorie.ToString().ToLower().Contains(searchText))
                        .ToList();

                    dataGridView.DataSource = filteredProduits;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors du filtrage des produits : " + ex.Message,
                                    "Erreur de filtrage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void categorieProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aProposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void labelCategorie_Click(object sender, EventArgs e)
        {
        }
    }
}
