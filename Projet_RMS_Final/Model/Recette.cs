using System;

namespace Projet_RMS_Final.Model
{
    public class Recette
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Montant { get; set; }
        public string Produit { get; set; }
        public int Quantite { get; set; }

        public Commande Commande { get; set; }

        public Recette()
        {
            Date = DateTime.Now;
        }

        public Recette(DateTime date, string produit, int quantite, double montant)
        {
            Date = date;
            Produit = produit;
            Quantite = quantite;
            Montant = montant;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public DateTime GetDateCreation()
        {
            return Date;
        }

        public void SetDateCreation(DateTime dateCreation)
        {
            Date = dateCreation;
        }

        public double GetMontantTotal()
        {
            return Montant;
        }

        public void SetMontantTotal(double montantTotal)
        {
            Montant = montantTotal;
        }

        // Autres méthodes utiles pour la gestion de la recette...
    }
}
