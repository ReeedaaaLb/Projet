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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Connexion cnx = new Connexion();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1RF3GVP\\SQLEXPRESS;Initial Catalog=gestionstock;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select username,pswd from Admins where username = '" + usertxt.Text + "' and pswd ='" + pwdtxt.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()==true)
            {
                Admin_Page admin_Page = new Admin_Page();
                admin_Page.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("username or Password invalid");
            }
            con.Close();
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx.Connecter();
        }

        private void ShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowHide.Checked == true)
            {
                pwdtxt.UseSystemPasswordChar = true;
            }
            else
            {
                pwdtxt.UseSystemPasswordChar = false;
            }
        }

        private void BUser_Click(object sender, EventArgs e)
        {
            Client_Page user_Page = new Client_Page();
            user_Page.Show();
            this.Hide();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous Quittez ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
