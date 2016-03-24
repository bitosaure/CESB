using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;




namespace CESB
{
    public static class ConnexionDataSource
    {
        private static MySqlConnection connection = new MySqlConnection();

        public static bool SeConnecter()
        {
            connection.ConnectionString = ("Server=localhost; Uid=test; Database=cesb_db; Pwd=test;");
            connection.Open();
            return (connection.State == ConnectionState.Open);
        }
        /*
         String com = "SELECT * FROM x_artiste WHERE lower(nom) = ?artiste";
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = new MySqlCommand(com, Connection);
            MyAdapter.SelectCommand.Parameters.Add("?artiste", Artiste);
            DataSet ds = new DataSet();
            MyAdapter.Fill(ds);
            Connection.Close(); 
        */
        public static void connexionUtilisateur(string login, string mdp)
        {
            MySqlCommand requete = new MySqlCommand("select * from personne where login=?login and mdp=?mdp");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?login", login);
            requete.Parameters.AddWithValue("?mdp", mdp);
            MySqlDataReader dr =  requete.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter();
                    Personne pers = new Personne(Convert.ToInt16(dr[0]), (string)dr[2], (string)dr[3], (string)dr[4], (string)dr[6]);
                    Proxy.PersonneConnecte = pers;
                    
                }
                dr.Close();
                
            }
            else
            {
                dr.Close();
                throw new ConnectionException("Utilisateur ou mot de passe incorrect");
            }
            

        }
        public static void GetMagasinPersonne(Personne pers)
        {
            MySqlCommand requete = new MySqlCommand("select m.codemag,m.nom, m.adresse, m.numcompte,m.soldecompte from magasin m,"+
                "personne p where m.codemag=p.codemag and p.matricule=?mat group by m.codemag");
            requete.Parameters.AddWithValue("?mat", pers.Matricule);
            MySqlDataReader reader = requete.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Magasin m = new Magasin((string)reader[0], (string)reader[1], (string)reader[2], Convert.ToInt64(reader[3]), Convert.ToInt64(reader[4]));
                    pers.Mag = m;
                }
                reader.Close();
            }
            
        }
        public static List<Personne> GetListePersonnes()
        {
            List<Personne> listePersonnes = new List<Personne>();
            MySqlCommand com = new MySqlCommand("select * from personne");
            com.Connection = connection;
            MySqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Personne p = new Personne(Convert.ToInt16(dr[0]), (string)dr[2], (string)dr[3], (string)dr[4], (string)dr[6]);
                    listePersonnes.Add(p);
                }
            }
            //listePersonnes.Remove(Proxy.PersonneConnecte);
            dr.Close();
            return listePersonnes;
        }
        public static List<Produit> GetListeProduit()
        {
            List<Produit> listeProduit = new List<Produit>();
            MySqlCommand com = new MySqlCommand("select * from produit");
            com.Connection = connection;
            MySqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Produit p = new Produit((string)(dr[0]), (string)dr[2], Convert.ToDouble(dr[3]), new FamilleProduit((string)dr[1]));
                    listeProduit.Add(p);
                }
            }
            //listePersonnes.Remove(Proxy.PersonneConnecte);
            dr.Close();
            return listeProduit;
        }
        public static List<string> GetTypesUtilisateurs()
        {
            List<string> listeTypes = new List<string>();
            MySqlCommand com = new MySqlCommand("select codetype from type");
            com.Connection = connection;
            MySqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listeTypes.Add((string)dr[0]);
                }
            }
            dr.Close();
            return listeTypes;
        }
        public static CentraleAchat getCentrale(Magasin m)
        {
            CentraleAchat centrale = null;
            MySqlCommand com = new MySqlCommand("select codetype from centraleachat c, ingredient i");

            return centrale;
        }
        public static void acheterIngredients(Dictionary<Ingredient, Int16> list)
        {
            
        }
        
        public static List<Magasin> GetMagasins()
        {
            List<Magasin> listeMag = new List<Magasin>();
            MySqlCommand com = new MySqlCommand("select * from magasin");
            com.Connection = connection;
            MySqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Magasin m = new Magasin((string)dr[0], (string)dr[1], (string)dr[2], Convert.ToInt64(dr[3]), Convert.ToInt64(dr[4]));
                    listeMag.Add(m);
                }
            }
            dr.Close();
            return listeMag;
        }
        public static void CreerProduit(Produit p)
        {


            MySqlCommand requete = new MySqlCommand("select * from produit where codeproduit=?code ");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?code", p.Code);
            
            MySqlDataReader dr = requete.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                throw new UtilisateurExistantException("Un produit existe déjà sous cette identité");
            }
            else
            {
                dr.Close();
                MySqlCommand req = new MySqlCommand("insert into produit(codeproduit,codefamille,nom,prix) values(?codepro,?codefam,?nom,?prix)");
                req.Connection = connection;
                req.Parameters.AddWithValue("?codepro", p.Code);
                req.Parameters.AddWithValue("?codefam", p.Famille.Code);
                req.Parameters.AddWithValue("?nom", p.Nom);
                req.Parameters.AddWithValue("?prix", p.Prix);

                req.ExecuteNonQuery();
            }
        }
        public static void CreerPersonne(Personne p)
        {
          

            MySqlCommand requete = new MySqlCommand("select * from personne where nom=?nom and prenom=?prenom");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?nom", p.Nom);
            requete.Parameters.AddWithValue("?prenom", p.Prenom);
            MySqlDataReader dr = requete.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                throw new UtilisateurExistantException("Un utilisateur existe déjà sous cette identité");
            }
            else
            {
                dr.Close();
                MySqlCommand req = new MySqlCommand("insert into personne(codemag,codetype,nom,prenom,numtel,login,mdp) values(?codemag,?codeType,?nom,?prenom,?num,?login,?mdp)");
                req.Connection = connection;
                req.Parameters.AddWithValue("?codemag", p.Mag.CodeMag);
                req.Parameters.AddWithValue("?codeType", p.CodeType);
                req.Parameters.AddWithValue("?nom", p.Nom);
                req.Parameters.AddWithValue("?prenom", p.Prenom);
                req.Parameters.AddWithValue("?num", p.Numtel);
                req.Parameters.AddWithValue("?login", p.Login);
                req.Parameters.AddWithValue("?mdp", p.MotDePasse);
                req.ExecuteNonQuery();
            }
        }
        public static List<FamilleProduit> GetFamilleProduit()
        {
            List<FamilleProduit> listFam = new List<FamilleProduit>();
            MySqlCommand com = new MySqlCommand("select * from familleproduit");


            com.Connection = connection;
            MySqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    FamilleProduit m = new FamilleProduit((string)dr[0], (string)dr[1]);
                    listFam.Add(m);


                }
            }

            dr.Close();
            return listFam;
        }
        public static void SupprimerPersonne(Personne p)
        {
            MySqlCommand requete = new MySqlCommand("select * from personne where nom=?nom and prenom=?prenom");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?nom", p.Nom);
            requete.Parameters.AddWithValue("?prenom", p.Prenom);
            MySqlDataReader dr = requete.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                throw new UtilisateurExistantException("La personne que vous souhaitez supprimer n'existe pas");
            }
            else
            {
                dr.Close();
                MySqlCommand req = new MySqlCommand("delete from personne where matricule=?mat");
                req.Connection = connection;
                req.Parameters.AddWithValue("?mat", p.Matricule);
                req.ExecuteNonQuery();
            }
        }
        public static void SupprimerProduit(Produit p)
        {
            MySqlCommand requete = new MySqlCommand("select * from produit where codeproduit=?code");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?code", p.Code);
   
            MySqlDataReader dr = requete.ExecuteReader();
            if (!dr.HasRows)
            {
                dr.Close();
                throw new UtilisateurExistantException("Le produit que vous souhaitez supprimer n'existe pas");
            }
            else
            {
                dr.Close();
                MySqlCommand req = new MySqlCommand("delete from produit where codeproduit=?code");
                req.Connection = connection;
                req.Parameters.AddWithValue("?code", p.Code);
                req.ExecuteNonQuery();
            }
        }
    }
}
