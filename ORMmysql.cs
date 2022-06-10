using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;



namespace Inventaire
{
    public static class ORMmysql
    {
        private static String cs = @"server=localhost;userid=root;password=mysql;database=inventaire";
        private static MySqlConnection conn;
        public static Compte Comptecourrant;

        public static bool Connexion()
        {
            conn = new MySqlConnection(cs);
            conn.Open();
            return (conn.State == ConnectionState.Open);
        }

        public static bool Deconnexion()
        {
            if (conn != null)
            {
                conn.Close();
                return (conn.State == ConnectionState.Closed);
            }
            else
            {
                return true;
            }
        }

        /*---------------------------------------------SECTION USER----------------------------------------------------------------------------------------------------------------------------------------*/
        public static Compte Connexion_User(String idUser, String mdp)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM user WHERE idUser = '{idUser}' AND mdpUser = '{mdp}'";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            Compte p= null ;
            if (rdr.Read())
            {
                p = new Compte((String)rdr["idUser"], (String)rdr["nomUser"], (String)rdr["prenomUser"], (String)rdr["mdpUser"],(String)rdr["telUser"] );
            }

            rdr.Close();
            return p;


        }
        public static bool Ajout_User(string idUser, string nomUser, string prenomUser, string telUser, string mdpUser)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO user VALUES(\"{idUser}\",'{nomUser}',\"{prenomUser}\",\"{telUser}\",\"{mdpUser}\")";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static bool Supprimer_User(string idUser)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM user WHERE idUser = '{idUser}' ";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool Modifier_User(string idUser, String Nom, String Prenom, String mdp, string NoTel)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE user SET nomUser = '{Nom}',prenomUser = '{Prenom}',mdpUser = '{mdp}',telUser = '{NoTel}' WHERE idUser = '{idUser}' ";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();

            if (nbMaj == 0)
            {
                return false;
            }

            return true;
        }

        public static List<Compte> Get_All_User()
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM user";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            List<Compte> lescomptes = new List<Compte>();
            while (rdr.Read())
            {
                Compte a = new Compte( (String)rdr["idUser"], (String)rdr["nomUser"], (String)rdr["prenomUser"], (String)rdr["mdpUser"], (String)rdr["telUser"] );
                lescomptes.Add(a);
            }
            rdr.Close();
            return lescomptes;

        }



        /*----------------------------------------------FIN SECTION USER--------------------------------------------------------------------------------------------------------------------------------------------*/





        /*--------------------------------------------SECTION PRODUIT----------------------------------------------------------------------------------------------------------------------------------------*/

        public static bool Ajout_Produit(int idProduit, string nomProduit, float prixProduit, string descriptionProduit, string catProduit)
        {
            
                MySqlCommand objCmd;
                objCmd = conn.CreateCommand();

                String reqI = $"INSERT INTO produits VALUES('{idProduit}','{nomProduit}','{prixProduit}','{descriptionProduit}','{catProduit}')";
                objCmd.CommandText = reqI;
                int nbMaj = objCmd.ExecuteNonQuery();
                return (nbMaj == 1);
           

        }

        public static bool Supprimer_Produit(int idProduit)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM produits WHERE idProduit = {idProduit}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        
           

        public static bool Modifier_Produit(int idProduit, string nomProduit, float prixProduit, string descriptionProduit, string catProduit)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE produits SET nomProduit = '{nomProduit}',prixProduit = '{prixProduit}',descriptionProduit = '{descriptionProduit}',catProduit = '{catProduit}' WHERE idProduit = '{idProduit}' ";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();

            if (nbMaj == 0)
            {
                return false;
            }

            return true;
        }

        public static List<Produit> Get_All_Produit()
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM produits";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            List<Produit> lesproduits = new List<Produit>();
            while (rdr.Read())
            {
                Produit a = new Produit((int)rdr["idProduit"], (String)rdr["nomProduit"], (float)rdr["prixProduit"], (String)rdr["descriptionProduit"], (String)rdr["catProduit"]);
                lesproduits.Add(a);
            }
            rdr.Close();
            return lesproduits;

        }
        /*-------------------------------------------FIN SECTION PRODUIT-----------------------------------------------------------------------------------------------------------------*/



        /*--------------------------------------------SECTION CLIENT----------------------------------------------------------------------------------------------------------------------------------------*/

        public static bool Ajout_Client(int idClient, string nomClient, int telClient)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO client VALUES(\"{idClient}\",\"{nomClient}\",\"{telClient}\")";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static bool Supprimer_Client(int idClient)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM client WHERE idClient = {idClient}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool Modifier_Client(int idClient, string nomClient, int telClient)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE client SET nomClient = '{nomClient}',telClient = '{telClient}' WHERE idClient = '{idClient}' ";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();

            if (nbMaj == 0)
            {
                return false;
            }

            return true;
        }

        public static List<Client> Get_All_Client()
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM client";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            List<Client> lesclients = new List<Client>();
            while (rdr.Read())
            {
                Client a = new Client((int)rdr["idClient"], (String)rdr["nomClient"], (int)rdr["telClient"]);
                lesclients.Add(a);
            }
            rdr.Close();
            return lesclients;

        }

        /*---------------------------FIN SECTION CLIENT-----------------------------------------------------------------------------------------------------------------*/



        /*--------------------------------------------SECTION CATEGORIE----------------------------------------------------------------------------------------------------------------------------------------*/

        public static bool Ajout_Cat(string idCat, string nomCat)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO categories VALUES(\"{idCat}\",\"{nomCat}\")";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static bool Supprimer_Cat(String idCat)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM categorie WHERE idCat = {idCat}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool Modifier_Cat(string idCat, string nomCat)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE categories SET nomCat = '{nomCat}' WHERE idClient = '{idCat}' ";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();

            if (nbMaj == 0)
            {
                return false;
            }

            return true;
        }

        public static List<Categorie> Get_All_Categorie()
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM categories";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            List<Categorie> lescategories = new List<Categorie>();
            while (rdr.Read())
            {
                Categorie a = new Categorie((string)rdr["id"], (String)rdr["nomCat"]);
                lescategories.Add(a);
            }
            rdr.Close();
            return lescategories;

        }




        /*---------------------------FIN SECTION CATEGORIE-----------------------------------------------------------------------------------------------------------------*/


        /*---------------------------SECTION COMMANDE-----------------------------------------------------------------------------------------------------------------*/


        public static bool Ajout_Commade( int quantite, float prix, int id_client, int id_produit)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqI = $"INSERT INTO commande(`date`,`quantite`, `prixCommande`, `id_client`, `id_produit`)  VALUES(  CURRENT_DATE, '{quantite}','{prix}','{id_client}','{id_produit}')";
            objCmd.CommandText = reqI;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);

        }

        public static bool Supprimer_Commande(int idCommande)
        {
            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();

            String reqCount = $"DELETE FROM commande WHERE idClient = {idCommande}";
            objCmd.CommandText = reqCount;
            int nbMaj = objCmd.ExecuteNonQuery();
            return (nbMaj == 1);
        }

        public static bool Modifier_Commande(int id_commande, int quantite, float prix, int id_client, int id_produit)
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            String reqU = $"UPDATE commande SET quantite = {quantite},prixCommande = {prix}, id_client ={id_client}, id_produit ={id_produit}  WHERE id = '{id_commande}' ";
            objCmd.CommandText = reqU;
            int nbMaj = objCmd.ExecuteNonQuery();

            if (nbMaj == 0)
            {
                return false;
            }

            return true;
        }

        public static List<Commande> Get_All_Commande()
        {

            MySqlCommand objCmd;
            objCmd = conn.CreateCommand();
            MySqlDataReader rdr;

            String reqCount = $"SELECT * FROM commande";
            objCmd.CommandText = reqCount;
            rdr = objCmd.ExecuteReader();
            List<Commande> lescommandes = new List<Commande>();
            while (rdr.Read())
            {
                Commande a = new Commande( (int)rdr["id"], (DateTime)rdr["date"], (int)rdr["quantite"], (float)rdr["prixCommande"], (int)rdr["id_client"], (int)rdr["id_produit"]);
                lescommandes.Add(a);
            }
            rdr.Close();
            return lescommandes;

        }






        /*---------------------------FIN SECTION COMMANDE-----------------------------------------------------------------------------------------------------------------*/

    }
}
