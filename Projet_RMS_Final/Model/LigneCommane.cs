using System;

namespace Projet_RMS_Final.Model
{
    public class LigneCommande
    {
        public int Id { get; set; }
        public Produit Produit { get; set; }
        public Commande Commande { get; set; }
        public int Quantite { get; set; } = 0;
        
        public void AddQuantite(int quantite)
        {
            Quantite += quantite;
        }
    }
}
