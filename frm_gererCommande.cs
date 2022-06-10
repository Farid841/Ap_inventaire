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
    public partial class frm_gererCommande : Form
    {
        public frm_gererCommande()
        {
            InitializeComponent();
        }
        void populateCom()
        {
            DGV_commande.Rows.Clear();
            List<Commande> lescommandes = ORMmysql.Get_All_Commande();
            foreach (Commande a in lescommandes)
            {
                string[] row;
                row = new string[]
                {
                    a.GetIdCommande().ToString(),
                    a.GetDateCommande(),
                    a.GetQuantiteCommande().ToString(),
                    a.GetPrixCommande().ToString(),
                    a.GetIdCliCommande().ToString(),
                    a.GetIdProdCommande().ToString(),

                };
                DGV_commande.Rows.Add(row);


            }
        }

        private void gererCommande_Load(object sender, EventArgs e)
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
            populateCom();

        }
       

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((count != 0) && (prixprod != 0))
            {
                total = count * prixprod;
                txt_total.Text = total.ToString();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if ((count != 0) && (prixprod != 0))
            {
                total = count * prixprod;
                txt_total.Text = total.ToString();
            }
        }
        public float prixprod;
        private void DGV_produit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                

        }

        private void DGV_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_qteCommande_Click(object sender, EventArgs e)

        {
             
            if (String.IsNullOrWhiteSpace(txt_idClient.Text))
            {
                MessageBox.Show("Veuiller selectiionné un client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (String.IsNullOrWhiteSpace(txt_idproduit.Text))
            {
                MessageBox.Show("Veuiller selectionné un produit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                else if (!String.IsNullOrWhiteSpace(nb_quantite.Text))
                {
                    count = Convert.ToInt32(Math.Round(nb_quantite.Value, 1));
                }


                if (ORMmysql.Ajout_Commade(count, 10, Convert.ToInt32(txt_idClient.Text), Convert.ToInt32(txt_idproduit.Text) ) )
            {
                MessageBox.Show(" La commande est bien enregistré ");
                populateCom();
            }
            else
            {
                MessageBox.Show(" ERROR, la commande a échoué, veillez réeseyer plus tard ");
            }
        
   

        }
        public int count;
        public float total;
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (String.IsNullOrWhiteSpace(txt_idCommande.Text))
                {
                    MessageBox.Show("Veuiller selectiionné la commande que vous voulez mofifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (String.IsNullOrWhiteSpace(txt_idClient.Text))
                {
                    MessageBox.Show("Veuiller selectiionné un client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (String.IsNullOrWhiteSpace(txt_idproduit.Text))
                {
                    MessageBox.Show("Veuiller selectionné un produit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!String.IsNullOrWhiteSpace(nb_quantite.Text))
                {
                    count = Convert.ToInt32(Math.Round(nb_quantite.Value, 1));
                }

                if (ORMmysql.Modifier_Commande(Convert.ToInt32(txt_idCommande.Text),count, total, Convert.ToInt32(txt_idClient.Text), Convert.ToInt32(txt_idproduit.Text)))
                {
                    MessageBox.Show(" La modification de la commande est bien enregistré ");
                    populateCom();
                }
                else
                {
                    MessageBox.Show(" ERROR, la modification a échoué, veillez réeseyer plus tard ");
                }
            
           
}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace((txt_idCommande.Text) ))
                {
                    MessageBox.Show("Veuiller selectiionné la commande que vous voulez mofifier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ORMmysql.Supprimer_Commande(int.Parse(txt_idCommande.Text)))
                    {
                        MessageBox.Show(" La suppression est bien enregistré ");
                        populateCom();
                    }
                    else
                    {
                        MessageBox.Show(" ERROR, la commande a échoué, veillez réeseyer plus tard ");
                    }

                }
            }catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }

        }

        private void txt_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void DGV_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_client.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_client.CurrentRow.Selected = true;

                    txt_idClient.Text = DGV_client.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch
            {

            }
        }

        private void DGV_produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_produit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_produit.CurrentRow.Selected = true;
                    txt_idproduit.Text = DGV_produit.Rows[e.RowIndex].Cells[0].Value.ToString();

                    float prixprod = float.Parse(DGV_produit.Rows[e.RowIndex].Cells[3].ToString());

                    
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);    
            }
        }

        private void DGV_commande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_commande.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DGV_commande.CurrentRow.Selected = true;

                    txt_idCommande.Text = DGV_commande.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch
            {

            }
        }

        private void txt_quantite_ValueChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(nb_quantite.Text)&& ((prixprod != 0))) )
            {
                float total= count * prixprod;
                txt_total.Text = total.ToString();
            }
        }
    }
}
