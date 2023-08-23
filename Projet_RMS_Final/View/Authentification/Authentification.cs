
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;
using Projet_RMS_Final.View.Administrateur;


namespace Projet_RMS_Final.Authentification
{
    public partial class AuthentificationUI : Form
    {
        Utilisateur utilisateur;
        public AuthentificationUI()
        {
            InitializeComponent();

        }

        private void AuthentificationUI_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool ValidateLoginFields()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                errorMessage += "\nEntrez un Login valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorMessage += "\nEntrez un Mot de passe valide.";
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
        public void testDao()
        {
            // Création d'un nouvel utilisateur
            Utilisateur newUser = new Utilisateur("chef", "chef", "john.doe@example.com", "123456789", Role.ChefCuisinier
                );

            // Création d'une instance du DAO pour les utilisateurs
            UtilisateurSqlDaoImpl utilisateurDao = new UtilisateurSqlDaoImpl();

            try
            {
                // Appel de la méthode Create pour insérer l'utilisateur dans la base de données
                utilisateurDao.Create(newUser);

                MessageBox.Show("Utilisateur créé avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la création de l'utilisateur : " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateLoginFields())
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                utilisateur = new Utilisateur(login, password);

                try
                {
                    if (utilisateur.Authenticate())
                    {
                        //MessageBox.Show(utilisateur.ToString());
                        switch (utilisateur.Role)
                        {
                            case "Administrateur":
                                // Remplacez ceci par la logique de votre interface administrateur
                                //MessageBox.Show("Interface Administrateur est affichée.", "Connexion réussie");
                                //HomeAdministrateur homeAdministrateur = new HomeAdministrateur();
                                //homeAdministrateur.Show();
                                //homeAdministrateur.setUtilisateur(utilisateur);
                                RMSApplication.Instance.ShowHomeAdministrateurUI();
                                this.cleanForm();
                                this.Hide();
                                break;
                            case "Restauranteur":
                                // Remplacez ceci par la logique de votre interface restaurateur
                                RMSApplication.Instance.ShowHomeRestaurateurUI();
                                this.cleanForm();
                                this.Hide();
                                break;
                            case "ChefCuisinier":
                                // Remplacez ceci par la logique de votre interface chef cuisinier
                                RMSApplication.Instance.ShowHomeChefCuisinier();
                                this.cleanForm();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Nom utlisateur ou mot de passe incorrect", "Échec de la connexion");
                                cleanForm();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nom utlisateur ou mot de passe incorrect", "Échec de la connexion");
                        cleanForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : ", "Erreur");
                    cleanForm();
                }

            }
        }

        private void cleanForm()
        {
            this.textBoxLogin.Text = "";
            this.textBoxPassword.Text = "";
            utilisateur = null;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
