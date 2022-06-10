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
    public partial class frm_gererProduit : Form
    {
        public frm_gererProduit()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txt_idProduit.Text))
            {
                MessageBox.Show("Veuiller rentré un Identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nomProduit.Text))
            {
                MessageBox.Show("Veuiller rentré un Mom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_prixProduit.Text))
            {
                MessageBox.Show("Veuiller rentré un Prix Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_desProduit.Text))
            {
                MessageBox.Show("Veuiller rentré une Description Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /* //////////////////////////////////////////////////////////////////
             * Pour la categorie sachant qu'il ya toujours une valeur dans le menu deroulant (defaut)
            if (String.IsNullOrWhiteSpace(txt_iduser.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            if (ORMmysql.Ajout_Produit(int.Parse(txt_idProduit.Text), txt_nomProduit.Text, float.Parse(txt_prixProduit.Text), txt_desProduit.Text ,  comboBox1.Text ))
            {
                MessageBox.Show(" Le produit a été bien AJOUTE ");
                populate();
            }
            else
            {
                MessageBox.Show(" Echec, l'ajout a échoué, veillez réeseyer plus tard ");
            }
        }

        /*
         * BTN SUPPRIMER
         */
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idProduit.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (ORMmysql.Supprimer_Produit(int.Parse(txt_idProduit.Text)))
            {
                MessageBox.Show(" Utilisateur a été bien SUPRIME ");
                populate();
            }
            else
            {
                MessageBox.Show(" ERROR, la suppresion a échoué, veillez réeseyer plus tard ");
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idProduit.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (ORMmysql.Modifier_Produit(int.Parse(txt_idProduit.Text), txt_nomProduit.Text, float.Parse(txt_prixProduit.Text), txt_desProduit.Text, comboBox1.Text ))
            {
                MessageBox.Show(" Utilisateur a été bien MODIFIER ");
                populate();
            }
            else
            {
                MessageBox.Show(" ERROR, l'ajout a échoué, veillez Changer d'identifiant ");
            }
        }
        void populate()
        {
            DGV_produit.Rows.Clear();
            List<Produit> lesproduits = ORMmysql.Get_All_Produit();
            foreach (Produit a in lesproduits)
            {
                string[] row;
                row = new string[]
                {
                    a.GetIdProduit().ToString(),
                    a.GetNomProduit(),
                    a.GetPrixProduit().ToString(),
                    a.GetdescriptionProduit(),
                    a.GetCatProduit(),
                };
                DGV_produit.Rows.Add(row);


            }

        }
        private void frm_gererProduit_Load(object sender, EventArgs e)
        {
           
                populate();
            comboBox1.Items.Clear();
            List<Categorie> lescategories = ORMmysql.Get_All_Categorie();
            foreach (Categorie a in lescategories)
            {
                string row;
                row =
                    a.GetIdCat();


                comboBox1.Items.Add(row);


            }

        }

        private void DGV_produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index;
            index = e.RowIndex;

            DataGridViewRow row = DGV_produit.SelectedRows[0];

            txt_idProduit.Text   = row.Cells[0].Value.ToString();
            txt_nomProduit.Text  = row.Cells[1].Value.ToString();
            txt_prixProduit.Text = row.Cells[2].Value.ToString();
            txt_desProduit.Text  = row.Cells[3].Value.ToString();
            comboBox1.Text       = row.Cells[4].Value.ToString();
        }

        private void DGV_produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_produit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_produit.CurrentRow.Selected = true;
                    txt_idProduit.Text = DGV_produit.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txt_nomProduit.Text = DGV_produit.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_prixProduit.Text = DGV_produit.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_desProduit.Text = DGV_produit.Rows[e.RowIndex].Cells[3].Value.ToString();
                    comboBox1.Text = DGV_produit.Rows[e.RowIndex].Cells[4].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rechercheCat_Click(object sender, EventArgs e)
        {

        }
    }
}
