using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet
{
   public partial class Admin_Page : Form
    {
        
        Produit P;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1RF3GVP\\SQLEXPRESS;Initial Catalog=gestionstock;Integrated Security=True");
        public Connexion cnx = new Connexion();
       
        private Categorie categorie;

        //private string nom_categorie;

        public void actualiser()
        {
        //DataTable dt = new DataTable();
             P = new Produit(Connexion.cnx); //Appel du 1er constructeur
            P.Lister(); //Appel de la méthode Lister()
            Liste.DataSource = P.Getconnexion() ; //Remplir DataGridView à partir de DataTable
            Tidproduit.Text = ""; // vider les zones
            Tnomproduit.Text = "";
            Tqnt.Text = "";
            Tprix.Text = "";
            combocategorie.SelectedValue = "";
            Tidproduit.Select(); //sélectionner Tidproduit
        }
        public Admin_Page()
        {
            InitializeComponent();
        }
        
        private void Admin_Page_Load(object sender, EventArgs e)
        {
            
            Categorie c = categorie;
            Remplircombocategorie();
            SqlDataAdapter dp = new SqlDataAdapter("Select * from Produit", con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            DataSet ds = new DataSet();
            Liste.DataSource = dt;
            
            
        }

        public void Remplircombocategorie()
        {
            cnx.dp = new SqlDataAdapter("Select * from Categorie",con);
            cnx.dp.Fill(cnx.ds, "nom_categorie");
            combocategorie.DataSource = cnx.ds.Tables["nom_categorie"];
            combocategorie.DisplayMember = "nom_categorie";
            combocategorie.ValueMember = "nom_categorie";
        }
        
        private void BAjouter_Click(object sender, EventArgs e)
        {
            if (Tidproduit.Text == "" || Tnomproduit.Text == "" || Tprix.Text == "" || Tqnt.Text == "" || combocategorie.Text == "")
            {
                MessageBox.Show("données non valide");
                return;
            }
            Categorie categories = new Categorie(Connexion.cnx);
            //P = new Produit(Tidproduit.Text, Tnomproduit.Text, int.Parse(Tprix.Text), int.Parse(Tqnt.Text), categorie.Getnom_categorie(),Connexion.cnx); //créer un PRODUIT à l'aide du
                                                                                  //3eme constructeur
            P.Ajout(); //appel de la méthode ajout
            DataTable dt = new DataTable();
            Liste.DataSource = dt;
            actualiser(); //appel de actualiser
            MessageBox.Show("ajout effectué");
        }

        private void combocategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BSupp_Click(object sender, EventArgs e)
        {
            if (Tidproduit.Text == "")
            {
                MessageBox.Show("id non valide");
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer le produit " + Tidproduit.Text, "Confirmer",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("suppression annulée");
                return;
            }
            P = new Produit(Tidproduit.Text, Connexion.cnx); //créer un employé à l'aide du 2eme constructeur
            P.Supprimer(); //appel de la méthode supprimer
            actualiser(); //appel de actualiser
            MessageBox.Show("suppression effectuée");
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("voulez vous se deconnecter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
    
}
