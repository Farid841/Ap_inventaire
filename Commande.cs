using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaire
{
    public class Commande
    {
        private int id;
        private DateTime date;
        private int quantite;
        private float prix;
        private int id_client;
        private int id_produit;

       
        public Commande(int id, DateTime date, int quantite, float prix, int id_client, int id_produit)
        {
            this.id = id;
            this.date = date;
            this.quantite = quantite;
            this.prix = prix;
            this.id_client = id_client;
            this.id_produit = id_produit;
        }

        public string GetDateCommande()
        {
            return this.date.ToString();
        }

        public int GetIdCommande()
        {
            return this.id;
        }

        public int GetQuantiteCommande()
        {
            return this.quantite;
        }

        public float GetPrixCommande()
        {
            return this.prix;
            
        }

        public int GetIdCliCommande() { return this.id_client; }
        public int GetIdProdCommande() { return this.id_produit; }

    }
}
