using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaire
{
    public class Produit
    {
        private int idProduit;
        private string nomProduit;
        private float prixProduit;
        private string descriptionProduit;
        private string catProduit;
        

        public Produit(int v1, string v2, float v3, string v4, string v5)
        {
            this.idProduit = v1;
            this.nomProduit = v2;
            this.prixProduit = v3;
            this.descriptionProduit = v4;
            this.catProduit = v5;
        }

        public int GetIdProduit()
        {
            return  idProduit;
        }
        public float GetPrixProduit()
        {

            return prixProduit;
        }
        public string GetNomProduit()
        {
            return nomProduit;
        }
        public string GetdescriptionProduit()
        {
            return descriptionProduit;
        }
        public string GetCatProduit()
        {
            return catProduit;
        }
    }
}
