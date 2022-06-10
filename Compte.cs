using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventaire
{
    public class Compte
    {
        
                    private string idUser;
                    private string nom;
                    private string prenom;
                    private string pass;
                    private string tel;

        public Compte(string idUser, string nom, string prenm, string pass, string tel)
                    {
                        this.idUser = idUser;
                        this.nom = nom;
                        this.prenom = prenm;
                        this.pass = pass;
                        this.tel = tel;

        }
            
            public string GetIdUser()
        {
            return this.idUser;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public string GetPrenom()
        {
            return this.prenom;
        }
        public string GetPass()
        {
            return this.pass;
        }
        public string GetTel()
        {
            return this.tel;
        }





    }
}
