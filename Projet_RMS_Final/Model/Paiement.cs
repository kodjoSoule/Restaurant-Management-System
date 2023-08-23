using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_RMS_Final.Model
{
    public class Paiement
    {
        public int Id { get; set; }
        public double MontantPayer { get; set; }
        public double MontantRecue { get; set; }
        public double MontantRendue { get; set; }
        public DateTime DatePaiement { get; set; }
        public string ModePaiement { get; set; }

        [ForeignKey("Commande")]
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public Paiement()
        {
            Id = 0;
            MontantPayer = 0;
            MontantRecue = 0;
            MontantRendue = 0;
            DatePaiement = DateTime.Now;
            ModePaiement = "";
            CommandeId = 0;
            Commande = null;
        }
    }
}
