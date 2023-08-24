namespace Projet_RMS_Final.Model
{
    public class Produit
    {
        public int Id { get; set; }
        public string Intitule { get; set; }
        public double Prix { get; set; }
        public int QuantiteStock { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public List<Commande> Commandes { get; set; } = new List<Commande>();
        public string Categorie { get; set; }
        public Produit()
        {
            Id = 0;
            QuantiteStock = 0;

            Description = "";
            Prix = 0;
            Categorie = "";
            Image = null;

        }
        public override string ToString()
        {
            return $"{Id} | {Intitule}";
        }


    }
}
