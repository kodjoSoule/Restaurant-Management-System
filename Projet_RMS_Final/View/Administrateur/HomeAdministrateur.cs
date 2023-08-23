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

namespace Projet_RMS_Final.View.Administrateur
{
    public partial class HomeAdministrateur : Form
    {
        Utilisateur utilisateur;
        public HomeAdministrateur()
        {
            InitializeComponent();
            if (utilisateur != null)
            {
                labelUtilisateur.Text = this.utilisateur.Prenom + " " + utilisateur.Nom;
            }
        }

        internal void setUtilisateur(Utilisateur utilisateur)
        {
            this.utilisateur = utilisateur;
            if (utilisateur != null)
            {
                labelUser.Text = this.utilisateur.Prenom + " " + utilisateur.Nom;
            }
        }

        private void HomeAdministrateur_Load(object sender, EventArgs e)
        {

        }

        private void labelUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowAuthentificationUI();
            this.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowListeUtilisateurUI();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowListeUtilisateurUI();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
