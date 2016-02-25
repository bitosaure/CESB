using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.OleDb;




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
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand requete = new MySqlCommand("select * from personne where login=?login and mdp=?mdp");
            requete.Connection = connection;
            requete.Parameters.AddWithValue("?login", login);
            requete.Parameters.AddWithValue("?mdp", mdp);
            //adapter.SelectCommand.Parameters.Add("?login", login);
            //adapter.SelectCommand.Parameters.Add("?mdp", mdp);
            MySqlDataReader dr =  requete.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter();
                    //MySqlCommand r = new MySqlCommand("select * from magasin where codemag=?code");
                    //r.Connection = connection;
                    //r.Parameters.AddWithValue("?code", dr["CODEMAG"]);
                    //adapt.SelectCommand.Parameters.Add("?code", dr["CODEMAG"]);
                    //MySqlDataReader read = r.ExecuteReader();
                    //Magasin m = new Magasin((string)dr[0], (string)dr[1], (string)dr[2], Convert.ToInt64(dr[3]), Convert.ToInt64(dr[4]));
                    Personne pers = new Personne(Convert.ToInt16(dr[0]), (string)dr[1], (string)dr[2], (string)dr[3], (string)dr[4]);
                    Proxy.PersonneConnecte = pers;
                    
                }
            }
            else
            {
                
            }
            

        }
    }
}
