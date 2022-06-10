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
    public partial class frm_gereruser : Form
    {
        public frm_gereruser()
        {
            InitializeComponent();
        }

        private void gereruser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowClick(object sender, DataGridViewCellEventArgs e)
        {
              

        }
        void populate()
        {
            DGV_user.Rows.Clear();
            List<Compte> lesComptes = ORMmysql.Get_All_User();
            foreach (Compte a in lesComptes)
            {
                string[] row;
                row = new string[]
                {
                a.GetIdUser(),
                a.GetNom(),
                a.GetPrenom(),
                a.GetPass(),
                a.GetTel(),
                };
                DGV_user.Rows.Add(row);
                this.DGV_user.Refresh();

            }

        }
        private void btn_ajout_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(txt_iduser.Text))
            {
                    MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nom.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_tel.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_mdp.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (ORMmysql.Ajout_User(txt_iduser.Text, txt_nom.Text, txt_prenom.Text, txt_tel.Text, txt_mdp.Text))
            {
                MessageBox.Show(" Utilisateur a été bien AJOUTE ");
                populate();
            }
            else
            {
                MessageBox.Show(" Echec, l'ajout a échoué, veillez réeseyer plus tard ");
            }

           
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrWhiteSpace(txt_iduser.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (ORMmysql.Supprimer_User(txt_iduser.Text)) { 
                MessageBox.Show(" Utilisateur a été bien SUPRIME ");
                populate();
            }
            else { 
                MessageBox.Show(" ERROR, la suppression a échoué, veillez réeseyer plus tard ");
            }

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(txt_iduser.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nom.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_prenom.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_tel.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_mdp.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (ORMmysql.Modifier_User(txt_iduser.Text, txt_nom.Text, txt_prenom.Text, txt_tel.Text, txt_mdp.Text)) { 
                MessageBox.Show(" Utilisateur a été bien MODIFIER ");
                populate();
            }
            else { 
                MessageBox.Show(" ERROR, l'ajout a échoué, veillez réeseyer plus tard ");
            }
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void txt_mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_user_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DGV_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_user.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_user.CurrentRow.Selected = true;
                    txt_iduser.Text = DGV_user.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txt_nom.Text = DGV_user.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_prenom.Text = DGV_user.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_mdp.Text = DGV_user.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txt_tel.Text = DGV_user.Rows[e.RowIndex].Cells[4].Value.ToString();


                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
