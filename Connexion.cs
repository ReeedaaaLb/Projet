using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Projet
{
    
    public class Connexion
    {
        //declaration des objets Sql
        
        private SqlConnection con;
        private SqlCommand cmd;
        public DataSet ds = new DataSet();
        public SqlDataAdapter dp;
        //private SqlDataReader dr;
        public DataTable dt;
        internal static readonly Connexion cnx;

        //declaration de la methode connecter
        /*public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=DESKTOP-1RF3GVP\\SQLEXPRESS;Initial Catalog=gestionstock;Integrated Security=True";
                con.Open();
            }
        }
        //declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {

                con.Close();
            }
        }*/
        public Boolean Connecter()
        {
            String chaine;
            try
            {
                chaine = "Data Source=DESKTOP-1RF3GVP\\SQLEXPRESS;Initial Catalog=gestionstock;Integrated Security=True";
                con = new SqlConnection(chaine);
                con.Open();
                return true;
            }
            catch (Exception s)
            {
                return false;
            }
        }
       
        public int Executer(String chaine_sql) //insert, update et delete
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteNonQuery(); //le nb de lignes traitées
        }
        public String Executer_valeur(String chaine_sql)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            return cmd.ExecuteScalar().ToString(); //un scalaire : valeur de fonctions d’agrégation
        }
        
        public void Executer_liste_deconnecté(String chaine_sql) //plusieurs lignes : select * …..
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = chaine_sql;
            dp.Fill(ds, cmd.CommandText);
            dt = ds.Tables[chaine_sql];   
        }
    }

}



