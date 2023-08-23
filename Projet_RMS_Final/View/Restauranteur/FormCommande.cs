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
    public partial class FormCommande : Form
    {
        Produit produit;
        Commande commande;
        Client client;
        LigneCommande ligneCommande;
        //
        CommandeSqlDaoImpl commandeDao = new CommandeSqlDaoImpl();
        ClientSqlDaoImpl clientSqlDaoImpl = new ClientSqlDaoImpl();
        LigneCommandeSqlDaoImpl ligneCommandeSqlDao = new LigneCommandeSqlDaoImpl();


        public FormCommande(Produit produit)
        {
            InitializeComponent();
            setProduit(produit);
        }
        public FormCommande()
        {
            InitializeComponent();
        }

        private void FormCommande_Load(object sender, EventArgs e)
        {

        }
        private void setProduit(Produit produit)
        {
            textBoxProduit.Text = produit.ToString();
            textBoxPrix.Text = produit.Prix.ToString();
        }
        private void cleanFormCommande()
        {
            textBoxProduit.Text = string.Empty;
            textBoxPrix.Text = string.Empty;
            textBoxQuantite.Text = string.Empty;
            dateTimePickerDate.Text = string.Empty;
            comboBoxStatut.Text = string.Empty;
            textBoxNomClient.Text = string.Empty;
            textBoxPrenomClient.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxTelephone.Text = string.Empty;
            textBoxAddresse.Text = string.Empty;

        }
        public bool ValidateCommandFields()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxProduit.Text))
            {
                errorMessage += "\nEntrez un nom de produit valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPrix.Text) || !decimal.TryParse(textBoxPrix.Text, out _))
            {
                errorMessage += "\nEntrez un prix valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxQuantite.Text) || !int.TryParse(textBoxQuantite.Text, out _))
            {
                errorMessage += "\nEntrez une quantité valide.";
            }

            if (dateTimePickerDate.Value > DateTime.Now)
            {
                errorMessage += "\nLa date ne peut pas être dans le futur.";
            }

            if (string.IsNullOrWhiteSpace(comboBoxStatut.Text))
            {
                errorMessage += "\nSélectionnez un statut valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxNomClient.Text))
            {
                errorMessage += "\nEntrez un nom de client valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPrenomClient.Text))
            {
                errorMessage += "\nEntrez un prénom de client valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !IsValidEmail(textBoxEmail.Text))
            {
                errorMessage += "\nEntrez un email valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxTelephone.Text))
            {
                errorMessage += "\nEntrez un numéro de téléphone valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxAddresse.Text))
            {
                errorMessage += "\nEntrez une adresse valide.";
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            cleanFormCommande();
        }

        private void buttonEnregistrer_Click_1(object sender, EventArgs e)
        {
            // Enregistrer une commande
            if (ValidateCommandFields())
            {
                try
                {

                    // Créer un nouveau client
                    client = new Client();
                    client.Nom = textBoxNomClient.Text;
                    client.Prenom = textBoxPrenomClient.Text;
                    client.Email = textBoxEmail.Text;
                    client.Telephone = textBoxTelephone.Text;
                    client.Adresse = textBoxAddresse.Text;
                    // Enregistrer le client dans la base de données
                    client = clientSqlDaoImpl.Create1(client);

                    // Créer une nouvelle commande
                    commande = new Commande();
                    commande.Date = dateTimePickerDate.Value;
                    commande.Status = comboBoxStatut.Text;
                    commande.MontantTotalProduits = Convert.ToDouble(textBoxPrix.Text) * Convert.ToInt32(textBoxQuantite.Text);
                    commande.Quantite = Convert.ToInt32(textBoxQuantite.Text);
                    // Ajouter le client à la commande
                    commande.Client = client;
                    
                    // Enregistrer la commande dans la base de données
                    commande = commandeDao.Create1(commande);


                    // Créer une ligne de commande
                    ligneCommande = new LigneCommande();
                    ligneCommande.Produit = produit;
                    ligneCommande.Quantite = Convert.ToInt32(textBoxQuantite.Text);
                    ligneCommande.Commande = commande;

                    // Enregistrer la ligne de commande dans la base de données
                    ligneCommandeSqlDao.Create(ligneCommande);

                    // Ajouter la ligne de commande à la commande
                    commande.LignesCommande.Add(ligneCommande);

                    //Mettre a jous la commande dans la base de données
                    commandeDao.Update(commande);

                    MessageBox.Show("La commande a été enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'enregistrement de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Nettoyer le formulaire
                cleanFormCommande();
            }
        }


        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ListeProduitRestauranteur listeProduitRestauranteur = new ListeProduitRestauranteur();
            listeProduitRestauranteur.Show();
            this.Hide();
        }

        private void comboBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
