using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaire
{
    public class Client
    {
        private int id;
        private string nom;
        private int tel;

        public Client (int id, string nom, int tel)
        {
            this.id = id;
            this.nom = nom;
            this.tel = tel;
        }

        public int GetIdClient()
        {
            return this.id;
        }
        public string GetNomClient()
        {
            return this.nom;
        }
        public int GetTelClient()
        {
            return this.tel;
        }



    }
}
