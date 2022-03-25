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
            gererCommande commande = new gererCommande();
            commande.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_produit_Click(object sender, EventArgs e)
        {
            gererProduit prod = new gererProduit();
            prod.Show();
            this.Hide();
        }

        private void pictureBox_Utilisateurs_Click(object sender, EventArgs e)
        {
            gereruser user = new gereruser();
            user.Show();
            this.Hide();
        }

        private void pictureBox_categories_Click(object sender, EventArgs e)
        {
            gererCategories cat = new gererCategories();
            cat.Show();
            this.Hide();
        }

        private void pictureBox_Client_Click(object sender, EventArgs e)
        {
            gererclient client = new gererclient();
            client.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
