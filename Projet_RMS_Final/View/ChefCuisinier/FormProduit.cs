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
    public partial class FormProduit : Form
    {
        private string imageFilePath;
        private Produit currentProduit;
        public FormProduit(Produit produit)
        {
            InitializeComponent();
            comboBoxCategorie.DataSource = Enum.GetValues(typeof(CategorieType));
            
            iconButtonModifier.Show();
            iconButtonModifier.Enabled = true;
            iconButtonValider.Hide();
            iconButtonValider.Enabled = false;

            if (produit != null)
            {
                currentProduit = produit;
                SetProduitDetails(produit);
            }

        }

        private void SetProduitDetails(Produit produit)
        {
            textBoxIntitule.Text = produit.Intitule;
            textBoxPrix.Text = produit.Prix.ToString();
            textBoxDescription.Text = produit.Description;
            comboBoxCategorie.SelectedItem = produit.Categorie;
            // Affichez l'image du produit dans le PictureBox si elle existe
            if (produit.Image != null && produit.Image.Length > 0)
            {
                pictureBoxImage.Image = ConvertBytesToImage(produit.Image);
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
        public FormProduit()
        {
            InitializeComponent();
            iconButtonModifier.Hide();
            iconButtonModifier.Enabled = false;
            iconButtonValider.Show();
            iconButtonValider.Enabled = true;
            comboBoxCategorie.DataSource = Enum.GetValues(typeof(CategorieType));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormProduit_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowHomeChefCuisinier();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (ValidateProductProperties())
            {
                // Créez un objet Produit à partir des informations du formulaire
                Produit produit = new Produit();

                produit.Intitule = textBoxIntitule.Text;
                produit.Prix = Convert.ToDouble(textBoxPrix.Text);
                //QuantiteStock = Convert.ToInt32(textBoxQuantiteStock.Text),
                produit.Description = textBoxDescription.Text;
                if (imageFilePath != null)
                    produit.Image = GetImageBytesFromFilePath(imageFilePath);
                produit.Categorie = comboBoxCategorie.Text;


                // Enregistrez le produit dans la base de données à l'aide de votre DAO ou gestionnaire de données
                // Ne spécifiez pas l'ID ici, car il sera généré automatiquement par la base de données
                ProduitSqlDaoImpl produitDao = new ProduitSqlDaoImpl();
                produitDao.Create(produit);

                // Affichez un message de confirmation
                MessageBox.Show("Produit enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Voulez-vous ajouter encore de produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CleanForm();
                }
                else {
                    RMSApplication.Instance.ShowListProduits();
                    this.Hide();
                    
                }
                
            }
        }


        private byte[] GetImageBytesFromFilePath(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    return File.ReadAllBytes(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la conversion de l'image en bytes : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CleanForm();
        }
        public void CleanForm()
        {
            textBoxIntitule.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            textBoxPrix.Text = string.Empty;
            // Pour désélectionner l'élément actuellement sélectionné
            comboBoxCategorie.SelectedIndex = -1;
            // Réinitialiser le PictureBox pour supprimer l'image affichée
            pictureBoxImage.Image = null;

            // Réinitialiser le chemin du fichier d'image
            imageFilePath = null;
        }

        public bool ValidateProductProperties()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxIntitule.Text))
            {
                errorMessage += "\nEntrez un intitulé valide pour le produit.";
            }
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                errorMessage += "\nEntrez une description valide pour le produit.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPrix.Text))
            {
                errorMessage += "\nEntrez un prix valide pour le produit.";
            }
            if (string.IsNullOrWhiteSpace(comboBoxCategorie.Text))
            {
                errorMessage += "\nSelectioner une categorie du produit.";
            }



            if (errorMessage.Length == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage.ToString(), "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            // Ouvrir une boîte de dialogue pour permettre à l'utilisateur de sélectionner une image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choisir une image";
                openFileDialog.Filter = "Images (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFilePath = openFileDialog.FileName;

                    try
                    {
                        // Afficher l'image sélectionnée dans un PictureBox
                        Image image = Image.FromFile(imageFilePath);
                        pictureBoxImage.Image = image;
                    }
                    catch (Exception ex)
                    {
                        // Gérer l'exception en cas d'erreur de chargement d'image
                        MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void iconButtonModifier_Click(object sender, EventArgs e)
        {
            if (currentProduit != null)
            {
                if (ValidateProductProperties())
                {
                    // Mettez à jour les propriétés du produit actuellement chargé dans le formulaire
                    currentProduit.Intitule = textBoxIntitule.Text;
                    currentProduit.Prix = Convert.ToDouble(textBoxPrix.Text);
                    currentProduit.Description = textBoxDescription.Text;
                    currentProduit.Categorie = comboBoxCategorie.Text;

                    if (imageFilePath != null)
                        currentProduit.Image = GetImageBytesFromFilePath(imageFilePath);

                    // Mettez à jour le produit dans la base de données à l'aide de votre DAO ou gestionnaire de données
                    ProduitSqlDaoImpl produitDao = new ProduitSqlDaoImpl();
                    produitDao.Update(currentProduit);

                    // Affichez un message de confirmation
                    MessageBox.Show("Produit mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RMSApplication.Instance.ShowListProduits();
                }
            }
            else
            {
                MessageBox.Show("Aucun produit à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
