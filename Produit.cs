using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Projet
{

    public class Produit
    {
        //private DataTable dt;
        private String id_Produit;
        private String Nom_Produit;
        private int Prix_Produit;
        private int Quantité_produit;
        private string categories;
        Categorie categorie;
        //private string Categorie;
        
        Connexion con;
        


        public Produit(Connexion con)
        {
            this.con = con;
        }

        public Produit(String id_Produit, Connexion con)
        {
            this.id_Produit = id_Produit;
            this.con = con;
        }
        public Produit(String id_Produit, String Nom_Produit, int Prix_Produit, int Quantité_produit,Categorie categorie, Connexion con)
        {
            this.id_Produit = id_Produit;
            this.Nom_Produit = Nom_Produit;
            this.Prix_Produit = Prix_Produit;
            this.Quantité_produit = Quantité_produit;
            this.categories = categories;
            //this.nom_categorie = nom_categorie;
            this.con = con;
        }
        public Connexion Getconnexion() //les get de connexion
        {
            return con;
        }
        public String Getid_Produit() //get de la clé primaire
        {
            return id_Produit;
        }

        public Boolean Existence_id_Produit()
        {
            if (con.Executer_valeur("select count(*) from Produit where matricule='" + id_Produit + "'") == "0")
                return false;
            else
                return true;
        }
        
        public int Ajout()
        {
            return con.Executer("insert into Produit values('" + id_Produit + "','" + Nom_Produit + "','" + Prix_Produit + "','" +
            Quantité_produit + "','" + categorie.Getnom_categorie()+"'");


        }
        public int Supprimer()
        {
            return con.Executer("delete from Produit where Produit='" + id_Produit + "'");
        }
        public int Modifier()
        {
            return con.Executer("update Produit set Nom_Produit='" + Nom_Produit + "', Prix_Produit='" + Prix_Produit + "'," +
                "Quantité_produit='" + Quantité_produit + "'categories='" + categorie.Getnom_categorie() + "'");
        }
        public void Lister() //lister
        {

            con.Executer_liste_deconnecté("select * from Produit");

        }
        public void Rechercher_id_Produit()
        {
            con.Executer_liste_deconnecté("select * from Produit where id_Produit='" + id_Produit + "'");
        }
        public void Rechercher_nom(String nom_recherché)
        {
            con.Executer_liste_deconnecté("select * from Produit where id_Produit like '" + nom_recherché + "%'");
        }
    }
}
