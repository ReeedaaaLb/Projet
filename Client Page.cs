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
    public partial class Client_Page : Form
    {
        public Client_Page()
        {
            InitializeComponent();
        }
        Produit P;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1RF3GVP\\SQLEXPRESS;Initial Catalog=gestionstock;Integrated Security=True");
        public Connexion cnx = new Connexion();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Client_Page_Load(object sender, EventArgs e)
        {
            Remplircomboproduit();
            SqlDataAdapter dp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //dp.Fill(dt);
            //DataSet ds = new DataSet();
            //Liste.DataSource = dt;
        }
        public void Remplircomboproduit()
        {
            cnx.dp = new SqlDataAdapter("Select Nom_produit from Produit", con);
            cnx.dp.Fill(cnx.ds, "Nom_produit");
            comboproduit.DataSource = cnx.ds.Tables["Nom_produit"];
            comboproduit.DisplayMember = "Nom_produit";
            comboproduit.ValueMember = "Nom_produit";
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous Partir ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
        }

        private void Tteleclient_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
