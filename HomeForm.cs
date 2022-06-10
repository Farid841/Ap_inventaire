using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaire
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm_gererCommande commande = new frm_gererCommande();
            commande.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_produit_Click(object sender, EventArgs e)
        {
            frm_gererProduit prod = new frm_gererProduit();
            prod.Show();
            this.Hide();
        }

        private void pictureBox_Utilisateurs_Click(object sender, EventArgs e)
        {
            frm_gereruser user = new frm_gereruser();
            user.Show();
            this.Hide();
        }

        private void pictureBox_categories_Click(object sender, EventArgs e)
        {
            frm_gererCategories cat = new frm_gererCategories();
            cat.Show();
            this.Hide();
        }

        private void pictureBox_Client_Click(object sender, EventArgs e)
        {
            frm_gererclient client = new frm_gererclient();
            client.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( ORMmysql.Deconnexion())
            {
                connexion f1 = new connexion();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La deconexion a echoué réesayer plus tard");
            }
        }
    }
}
