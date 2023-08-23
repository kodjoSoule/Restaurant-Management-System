using System;
using System.Collections.Generic;

namespace Projet_RMS_Final.Model
{
    public class Categorie
    {
        public int IdCategorie { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }

        // Spécifiez la visibilité de la propriété Produits
        public List<Produit> Produits { get; private set; } = new List<Produit>();
        public Categorie()
        {
            IdCategorie = 0;
            Libelle = "";
            Description = "";
        }

        public Categorie(string libelle)
        {
            Libelle = libelle;
        }

        public Categorie(int idCategorie, string libelle)
        {
            IdCategorie = idCategorie;
            Libelle = libelle;
        }

        public Categorie(int idCategorie, string libelle, string description)
        {
            IdCategorie = idCategorie;
            Libelle = libelle;
            Description = description;
        }

        public override string ToString()
        {
            return "Categorie [libelle=" + Libelle + "]";
        }
    }
}
