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
    public partial class frm_gererclient : Form
    {
        public frm_gererclient()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
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

            DGV_client.Rows.Clear();
            List<Client> lesclients = ORMmysql.Get_All_Client();
            foreach (Client a in lesclients)
            {
                string[] row;
                row = new string[]
                {
                    a.GetIdClient().ToString(),
                    a.GetNomClient(),
                    a.GetTelClient().ToString(),

                };
                DGV_client.Rows.Add(row);


            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nomClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_telClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Tel Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
      
            if ( ORMmysql.Ajout_Client( int.Parse(txt_idClient.Text), txt_nomClient.Text, int.Parse(txt_telClient.Text) ) )
            {
                MessageBox.Show(" Le CLIENT a été bien AJOUTE ");
                populate();
            }
            else
            {
                MessageBox.Show(" Echec, l'ajout a échoué, veillez réeseyer plus tard ");
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_nomClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Nom Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (String.IsNullOrWhiteSpace(txt_telClient.Text))
            {
                MessageBox.Show("Veuiller rentré un Tel Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (ORMmysql.Modifier_Client(int.Parse(txt_idClient.Text), txt_nomClient.Text, int.Parse(txt_telClient.Text)))
            {
                MessageBox.Show(" le client a été bien MODIFIER ");
                populate();
            }
            else
            {
                MessageBox.Show(" ERROR, l'ajout a échoué, veillez réeseyer plus tard ");
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_idClient.Text))
            {
                MessageBox.Show("Veuiller rentré un identifiant Valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            if (ORMmysql.Supprimer_Client(int.Parse(txt_idClient.Text) ))
            {
                MessageBox.Show(" Utilisateur a été bien SUPRIME ");
                populate();
            }
            else
            {
                MessageBox.Show(" ERROR, la suppression a échoué, veillez réeseyer plus tard ");
            }
        }

        private void frm_gererclient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DGV_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_client.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_client.CurrentRow.Selected = true;
                    txt_idClient.Text   = DGV_client.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txt_nomClient.Text  = DGV_client.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_telClient.Text = DGV_client.Rows[e.RowIndex].Cells[2].Value.ToString();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
