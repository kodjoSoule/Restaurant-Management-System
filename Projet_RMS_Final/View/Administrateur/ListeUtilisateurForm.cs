using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_RMS_Final.View.Administrateur
{
    public partial class ListeUtilisateurForm : Form
    {
        UtilisateurSqlDaoImpl utilisateurSqlDao;

        private Utilisateur selectedUtilisateur;

        public ListeUtilisateurForm()
        {
            InitializeComponent();

            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));

            utilisateurSqlDao = new UtilisateurSqlDaoImpl();

            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadUtilisateurs();
            ClearRegistrationFields();
        }
        private void loadUtilisateurs()
        {
            DataTable dataTable = utilisateurSqlDao.RetrieveDataFromDatabase();

            dataGridViewUsers.DataSource = dataTable;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUtilisateur != null)
            {

                selectedUtilisateur.Nom = textBoxNom.Text;
                selectedUtilisateur.Prenom = textBoxPrenom.Text;
                selectedUtilisateur.Login = textBoxLogin.Text;
                selectedUtilisateur.Password = textBoxPassword.Text;
                selectedUtilisateur.Email = textBoxEmail.Text;
                selectedUtilisateur.Telephone = textBoxTelephone.Text;
                selectedUtilisateur.Role = comboBoxRole.SelectedItem.ToString();

                // Mettre à jour l'utilisateur dans la base de données en utilisant le DAO approprié
                try
                {
                    UtilisateurSqlDaoImpl utilisateurDao = new UtilisateurSqlDaoImpl();
                    MessageBox.Show(selectedUtilisateur.ToString());
                    utilisateurDao.Update(selectedUtilisateur);
                    MessageBox.Show("Utilisateur mis à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rafraîchir la liste des utilisateurs affichée dans le DataGridView
                    loadUtilisateurs();

                    // Réinitialiser les champs du formulaire après la mise à jour
                    ClearRegistrationFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un utilisateur à mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateRegistrationFields()
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNom.Text))
            {
                errorMessage += "\nEntrez un Nom valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPrenom.Text))
            {
                errorMessage += "\nEntrez un Prénom valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                errorMessage += "\nEntrez un Nom d'utilisateur valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorMessage += "\nEntrez un Mot de passe valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorMessage += "\nEntrez une Adresse e-mail valide.";
            }

            if (string.IsNullOrWhiteSpace(textBoxTelephone.Text))
            {
                errorMessage += "\nEntrez un Numéro de téléphone valide.";
            }

            if (comboBoxRole.SelectedIndex == -1)
            {
                errorMessage += "\nSélectionnez un Rôle valide.";
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

        private void ClearRegistrationFields()
        {
            textBoxId.Text = "";
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxEmail.Text = "";
            textBoxTelephone.Text = "";
            comboBoxRole.SelectedIndex = -1;

            buttonValider.Enabled = true;
            buttonValider.Show();
            buttonUpdate.Enabled = false;
            buttonUpdate.Hide();
            selectedUtilisateur = null;
        }


        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            ClearRegistrationFields();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (ValidateRegistrationFields())
            {

                if (ValidateRegistrationFields())
                {
                    // Créer un nouvel utilisateur avec les données saisies
                    Utilisateur newUser = new Utilisateur
                    {
                        Nom = textBoxNom.Text,
                        Prenom = textBoxPrenom.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        Email = textBoxEmail.Text,
                        Telephone = textBoxTelephone.Text,
                        Role = comboBoxRole.SelectedItem.ToString() // Assurez-vous que Role est un enum
                    };

                    // Utiliser le DAO pour enregistrer le nouvel utilisateur
                    UtilisateurSqlDaoImpl utilisateurDao = new UtilisateurSqlDaoImpl();
                    try
                    {
                        utilisateurDao.Create(newUser);
                        MessageBox.Show("Utilisateur enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Réinitialiser les champs du formulaire après l'enregistrement
                        ClearRegistrationFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                //supprimer
            }

            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    UtilisateurSqlDaoImpl utilisateurDao = new UtilisateurSqlDaoImpl();
                    utilisateurDao.Delete(selectedUserId);

                    // Actualiser les données dans le DataGridView
                    loadUtilisateurs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression : " + ex.Message,
                                    "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un utilisateur à supprimer.",
                                "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();

            try
            {
                UtilisateurSqlDaoImpl utilisateurDao = new UtilisateurSqlDaoImpl();
                List<Utilisateur> utilisateurs = utilisateurDao.List();

                List<Utilisateur> filteredUtilisateurs = utilisateurs.Where(u =>
                    u.Nom.ToLower().Contains(searchText) ||
                    u.Prenom.ToLower().Contains(searchText) ||
                    u.Login.ToLower().Contains(searchText) ||
                    u.Role.ToLower().Contains(searchText))
                    .ToList();

                dataGridViewUsers.DataSource = filteredUtilisateurs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors du filtrage des utilisateurs : " + ex.Message,
                                "Erreur de filtrage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                int selectedUserId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                selectedUtilisateur = new Utilisateur
                {
                    Id = selectedUserId,
                    Nom = selectedRow.Cells["Nom"].Value.ToString(),
                    Prenom = selectedRow.Cells["Prenom"].Value.ToString(),
                    Login = selectedRow.Cells["Login"].Value.ToString(),
                    Password = selectedRow.Cells["Password"].Value.ToString(),
                    Email = selectedRow.Cells["Email"].Value.ToString(),
                    Telephone = selectedRow.Cells["Telephone"].Value.ToString(),
                    Role = selectedRow.Cells["Role"].Value.ToString()
                };
                UpdateUserDetailsForm(selectedUtilisateur);
            }
            else
            {
                MessageBox.Show("Sélectionnez un utilisateur .",
                                "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void UpdateUserDetailsForm(Utilisateur user)
        {
            textBoxId.Text = user.Id.ToString();
            textBoxNom.Text = user.Nom;
            textBoxPrenom.Text = user.Prenom;
            textBoxLogin.Text = user.Login;
            textBoxPassword.Text = user.Password;
            textBoxEmail.Text = user.Email;
            textBoxTelephone.Text = user.Telephone;
            int index = comboBoxRole.FindStringExact(user.Role);
            if (index != -1)
            {
                comboBoxRole.SelectedIndex = index;
            }

            // Afficher ou masquer les boutons en conséquence
            buttonUpdate.Show();
            buttonUpdate.Enabled = true;
            buttonValider.Hide();
            buttonValider.Enabled = false;
        }
        private void dataGridViewUsers_CellClick(object sender, EventArgs e)
        {
            //
            //
            ClearRegistrationFields();
        }
        
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            //ClearRegistrationFields();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RMSApplication.Instance.ShowHomeAdministrateurUI();
            this.Hide();
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
