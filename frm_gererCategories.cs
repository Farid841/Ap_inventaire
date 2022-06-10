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
    public partial class frm_gererCategories : Form
    {
        public frm_gererCategories()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
        void populate()
        {

            DGV_categorie.Rows.Clear();
            List<Categorie> lescategories = ORMmysql.Get_All_Categorie();
            foreach (Categorie a in lescategories)
            {
                string[] row;
                row = new string[]
                {
                    a.GetIdCat(),
                    a.GetNomCat(),

                };
                DGV_categorie.Rows.Add(row);


            }

        }
        private void btn_ajout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idCat.Text))
            {
                MessageBox.Show("Veuiller rentré un Identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nomCat.Text))
            {
                MessageBox.Show("Veuiller rentré une nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ORMmysql.Ajout_Cat(txt_idCat.Text, txt_nomCat.Text) )
            {
                MessageBox.Show(" La categotie a été bien AJOUTE ");
                populate();
            }
            else
            {
                MessageBox.Show(" Echec, l'ajout a échoué, veillez réeseyer plus tard ou verifier votre identifiant ");
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txt_idCat.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (ORMmysql.Supprimer_Produit(int.Parse(txt_idCat.Text)))
            {
                MessageBox.Show(" La categorie a été bien SUPRIME ");
                populate();
            }
            else
            {
                MessageBox.Show(" ERROR, la suppression a échoué, veillez réeseyer plus tard ou changez d'identifiant ");
            }
        }

        private void frm_gererCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DGV_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DGV_categorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_categorie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_categorie.CurrentRow.Selected = true;

                    txt_idCat.Text = DGV_categorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_nomCat.Text = DGV_categorie.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch
            {

            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idCat.Text))
            {
                MessageBox.Show("Veuiller rentré un Identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nomCat.Text))
            {
                MessageBox.Show("Veuiller rentré une nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (ORMmysql.Modifier_Cat(txt_idCat.Text, txt_nomCat.Text))
            {
                MessageBox.Show(" La categotie a été bien MODIFIER ");
                populate();
            }
            else
            {
                MessageBox.Show(" Echec, l'ajout a échoué, veillez réeseyer plus tard ou verifier votre identifiant ");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
