using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaire
{
    public class Categorie
    {

        private string id;
        private string nom;

        public Categorie(string id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public string GetIdCat()
        {
             return this.id; 
        }

        public string GetNomCat()
        {
            return this.nom;
        }
    }
}
