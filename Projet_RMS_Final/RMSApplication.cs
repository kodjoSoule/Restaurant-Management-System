
using Projet_RMS_Final.Authentification;
using Projet_RMS_Final.View.Administrateur;
using Projet_RMS_Final.View.ChefCuisinier;
using Projet_RMS_Final.View.Restauranteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_RMS_Final
{

    

    internal class RMSApplication
    {
        //
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Form1());
            //Application.Run(new Authentification.AuthentificationUI());
            
            RMSApplication.Instance.Run();
            //RMSApplication.instance.ShowFormProduitUI();

        }
        //
        private static RMSApplication instance = null;
        public static RMSApplication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RMSApplication();
                }
                return instance;
            }
        }
        // Ajoutez des méthodes pour lancer d'autres fenêtres si nécessaire
        public void ShowAuthentificationUI()
        {
            AuthentificationUI authentificationUI = new AuthentificationUI();
            authentificationUI.Show();
        }
        public void ShowHomeAdministrateurUI()
        {
            HomeAdministrateur homeAdministrateur = new HomeAdministrateur();
            homeAdministrateur.Show();
        }
        public void ShowListeUtilisateurUI()
        {
            ListeUtilisateurForm listeUtilisateurFormUI = new ListeUtilisateurForm();
            listeUtilisateurFormUI.Show();
        }
        public void Run()
        {
            // Lancer la première fenêtre de votre application ici
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthentificationUI()); // Remplacez VotreFenetrePrincipale par le nom de votre fenêtre principale
            //Application.Run(new HomeAdministrateur());
        }
        public void ShowHomeRestaurateurUI()
        {
            HomeRestauranteur homeRestauranteur = new HomeRestauranteur();
            homeRestauranteur.Show();
        }
        public void ShowHomeChefCuisinier()
        {
            HomeChefCusinier homeChefCusinier = new HomeChefCusinier();
            homeChefCusinier.Show();
        }

        internal void ShowListProduits()
        {
            ListeProduits listeProduits = new ListeProduits();
            listeProduits.Show();
        }

        internal void ShowFormProduitUI()
        {
            FormProduit formProduit = new FormProduit();
            formProduit.Show();
        }
        internal void Deconnexion(Form? f)
        {
            RMSApplication.Instance.ShowAuthentificationUI();
            if(f!= null ) 
            f.Close();
        }
        internal void quitter()
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
