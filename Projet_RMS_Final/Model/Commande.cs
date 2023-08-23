using System;
using System.Collections.Generic;

namespace Projet_RMS_Final.Model
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        //public int Quantite { get; set; }
        //public double MontantTotalProduits { get; set; }
        public double MontantTotalCommande { get; set; } = 0.0 ;

        public List<Produit> Produits { get; set; } = new List<Produit>();
        public Utilisateur Restauranteur { get; set; }
        public Paiement Paiement { get; set; }
        public Client Client { get; set; }
        

        public List<LigneCommande> LignesCommande { get; set; } = new List<LigneCommande>();

        
        public void addProduit(Produit produit)
        {
            //Produits.Add(produit);
            //MontantTotalCommande += produit;
        }

        public void RemoveProduit(Produit produit)
        {
            if (Produits.Contains(produit))
            {
                Produits.Remove(produit);
                produit.Commandes.Remove(this);
            }
        }

        public Commande()
        {
            Id = 0;
            Date = DateTime.Now;
            Status = "";
            //Quantite = 1;
            //MontantTotalProduits = 0;
            MontantTotalCommande = 0;
            Restauranteur = null;
        }

        public Commande(int id, DateTime date, string status, int quantite, Utilisateur restauranteur, List<Produit> produits)
        {
            Id = id;
            Date = date;
            Status = status;
            //Quantite = quantite;
            Restauranteur = restauranteur;
            Produits = produits;
        }

        public Commande(int id, DateTime date, string status, int quantite)
        {
            Id = id;
            Date = date;
            Status = status;
            //Quantite = quantite;
        }

        public Commande(int id, DateTime date, string status, int quantite, Utilisateur restauranteur)
        {
            Id = id;
            Date = date;
            Status = status;
            //Quantite = quantite;
            Restauranteur = restauranteur;
        }
    }
}
