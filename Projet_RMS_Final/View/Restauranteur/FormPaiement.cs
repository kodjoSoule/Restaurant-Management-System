using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.View.Restauranteur
{
    public partial class FormPaiement : Form
    {
        private LigneCommande ligneCommande;
        double total;
        double montantRecue;
        double montantRendue;
        private bool isValidePayment = false;

        public FormPaiement(LigneCommande ligneCommande)
        {

            InitializeComponent();
            buttonPayer.Enabled = false;

            textBoxTotal.Enabled = false;
            ligneCommande = ligneCommande;

            this.ligneCommande = ligneCommande;
            labelCommande.Text = ligneCommande.Commande.Id.ToString();
            labelClient.Text = ligneCommande.Commande.Client.GetNomComplet();
            labelClientAddresse.Text = ligneCommande.Commande.Client.Adresse;
            dateTimePickerDateCommande.Text = ligneCommande.Commande.Date.ToString();
            dateTimePickerDateCommande.Enabled = false;
            dateTimePickerDatePaiement.Value = DateTime.Now;
            textBoxTotal.Text = ligneCommande.Commande.MontantTotalCommande.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormPaiement_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidatePayments())
            {
                // 1. Créer un objet Paiement
                Paiement paiement = new Paiement
                {
                    MontantRecue = montantRecue,
                    MontantRendue = montantRendue,
                    DatePaiement = dateTimePickerDatePaiement.Value,
                    MontantPayer = total,
                    Commande = ligneCommande.Commande
                };

                // 2. Enregistrer le paiement dans la base de données
                // Utilisez votre DAO pour les paiements pour enregistrer le paiement
                PaiementSqlDaoImpl paiementSqlDaoImpl = new PaiementSqlDaoImpl();
                paiementSqlDaoImpl.Create(paiement); // Remplacez par la méthode appropriée

                // 3. Mettre à jour le statut de la commande en "Payer"
                // Utilisez votre DAO pour les commandes pour mettre à jour le statut de la commande
                ligneCommande.Commande.Status = Statut.Payer.ToString();
                CommandeSqlDaoImpl commandeSqlDaoImpl = new CommandeSqlDaoImpl();
                commandeSqlDaoImpl.Update(ligneCommande.Commande); // Remplacez par la méthode appropriée
                MessageBox.Show("Paiement effectué avec succès.");
                Close();

            }
        }

        private bool ValidatePayments()
        {
            return isValidePayment;
        }

        private void textBoxMontantRecue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMontantRecue.Text, out int montantRecue))
            {
                total = ligneCommande.Commande.MontantTotalCommande;

                if (montantRecue >= total)
                {
                    buttonPayer.Enabled = true;
                    buttonPayer.Cursor = Cursors.Hand;
                    labelError.Text = "";
                    montantRendue = montantRecue - total;
                    textBoxMontanRendue.Text = montantRendue.ToString();
                    this.isValidePayment = true;
                }
                else
                {
                    labelError.Text = "Montant insuffisant";
                    labelError.ForeColor = Color.Red;
                    this.isValidePayment = false;
                }
            }
            else
            {
                labelError.Text = "Montant invalide";
                labelError.ForeColor = Color.Red;
            }
        }

    }
}
