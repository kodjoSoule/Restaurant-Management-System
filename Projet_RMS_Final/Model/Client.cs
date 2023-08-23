using System;
using System.Collections.Generic;

namespace Projet_RMS_Final.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public List<Commande> Commandes { get; set; } = new List<Commande>();

        public Client()
        {
            Id = 0;
            Nom = "";
            Prenom = "";
            Adresse = "";
            Email = "";
            Telephone = "";
        }

        public void AddCommande(Commande commande)
        {
            Commandes.Add(commande);
        }

        public void RemoveCommande(Commande commande)
        {
            Commandes.Remove(commande);
            commande.Client = null;
        }

        public string GetNomComplet()
        {
            return Nom + " " + Prenom;
        }
    }
}
