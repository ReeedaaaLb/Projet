using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Categorie
    {
        private String nom_categorie;
        private Connexion con;
        public Categorie (Connexion con)
        {
            this.con = con;
        }
        public Categorie(String nom_categorie, Connexion con)
        {
            this.nom_categorie = nom_categorie;
            this.con = con;
        }
        public Connexion Getconnexion() //get de connexion
        {
            return con;
        }
        public String Getnom_categorie() //get de la clé primaire
        {
            return nom_categorie;
        }
    }
}

