namespace Inventaire
{
    partial class frm_gererCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_client = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_idCommande = new System.Windows.Forms.TextBox();
            this.txt_idClient = new System.Windows.Forms.TextBox();
            this.DGV_produit = new System.Windows.Forms.DataGridView();
            this.IdP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_qteCommande = new System.Windows.Forms.Button();
            this.DGV_commande = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nb_quantite = new System.Windows.Forms.NumericUpDown();
            this.txt_idproduit = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_produit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_quantite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(776, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(817, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "X";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(851, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 25);
            this.exit.TabIndex = 11;
            this.exit.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "SYSTEME DE GESTION D\'INVENTAIRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Commandes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "List des clients";
            // 
            // DGV_client
            // 
            this.DGV_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_client.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nom,
            this.Tel});
            this.DGV_client.Location = new System.Drawing.Point(12, 130);
            this.DGV_client.Name = "DGV_client";
            this.DGV_client.RowTemplate.Height = 25;
            this.DGV_client.Size = new System.Drawing.Size(353, 193);
            this.DGV_client.TabIndex = 35;
            this.DGV_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_client_CellClick);
            this.DGV_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_client_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // txt_idCommande
            // 
            this.txt_idCommande.Location = new System.Drawing.Point(12, 341);
            this.txt_idCommande.Multiline = true;
            this.txt_idCommande.Name = "txt_idCommande";
            this.txt_idCommande.PlaceholderText = "idCommande";
            this.txt_idCommande.Size = new System.Drawing.Size(153, 27);
            this.txt_idCommande.TabIndex = 36;
            // 
            // txt_idClient
            // 
            this.txt_idClient.Location = new System.Drawing.Point(12, 374);
            this.txt_idClient.Multiline = true;
            this.txt_idClient.Name = "txt_idClient";
            this.txt_idClient.PlaceholderText = "idClient";
            this.txt_idClient.Size = new System.Drawing.Size(153, 27);
            this.txt_idClient.TabIndex = 37;
            // 
            // DGV_produit
            // 
            this.DGV_produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_produit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_produit.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_produit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdP,
            this.NomP,
            this.prixP,
            this.descriptionP,
            this.CatP});
            this.DGV_produit.Location = new System.Drawing.Point(371, 130);
            this.DGV_produit.Name = "DGV_produit";
            this.DGV_produit.RowTemplate.Height = 25;
            this.DGV_produit.Size = new System.Drawing.Size(400, 193);
            this.DGV_produit.TabIndex = 40;
            this.DGV_produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_produit_CellClick);
            this.DGV_produit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_produit_CellContentClick);
            // 
            // IdP
            // 
            this.IdP.HeaderText = "Id";
            this.IdP.Name = "IdP";
            // 
            // NomP
            // 
            this.NomP.HeaderText = "Nom";
            this.NomP.Name = "NomP";
            // 
            // prixP
            // 
            this.prixP.HeaderText = "Prix";
            this.prixP.Name = "prixP";
            // 
            // descriptionP
            // 
            this.descriptionP.HeaderText = "Description";
            this.descriptionP.Name = "descriptionP";
            // 
            // CatP
            // 
            this.CatP.HeaderText = "Categorie";
            this.CatP.Name = "CatP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(341, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Quantité";
            // 
            // btn_qteCommande
            // 
            this.btn_qteCommande.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_qteCommande.Location = new System.Drawing.Point(517, 332);
            this.btn_qteCommande.Name = "btn_qteCommande";
            this.btn_qteCommande.Size = new System.Drawing.Size(75, 23);
            this.btn_qteCommande.TabIndex = 44;
            this.btn_qteCommande.Text = "Ajouter";
            this.btn_qteCommande.UseVisualStyleBackColor = false;
            this.btn_qteCommande.Click += new System.EventHandler(this.btn_qteCommande_Click);
            // 
            // DGV_commande
            // 
            this.DGV_commande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_commande.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.date,
            this.quantite,
            this.prixCommande,
            this.id_client,
            this.id_produit});
            this.DGV_commande.Location = new System.Drawing.Point(214, 357);
            this.DGV_commande.Name = "DGV_commande";
            this.DGV_commande.RowTemplate.Height = 25;
            this.DGV_commande.Size = new System.Drawing.Size(557, 207);
            this.DGV_commande.TabIndex = 45;
            this.DGV_commande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_commande_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            // 
            // prixCommande
            // 
            this.prixCommande.HeaderText = "Prix";
            this.prixCommande.Name = "prixCommande";
            // 
            // id_client
            // 
            this.id_client.HeaderText = "Id_client";
            this.id_client.Name = "id_client";
            // 
            // id_produit
            // 
            this.id_produit.HeaderText = "Id_Produit";
            this.id_produit.Name = "id_produit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-45, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 16);
            this.panel2.TabIndex = 46;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 539);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Date Commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(598, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(679, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(517, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "List des produits";
            // 
            // nb_quantite
            // 
            this.nb_quantite.Location = new System.Drawing.Point(415, 331);
            this.nb_quantite.Name = "nb_quantite";
            this.nb_quantite.Size = new System.Drawing.Size(96, 23);
            this.nb_quantite.TabIndex = 53;
            this.nb_quantite.ValueChanged += new System.EventHandler(this.txt_quantite_ValueChanged);
            // 
            // txt_idproduit
            // 
            this.txt_idproduit.Location = new System.Drawing.Point(12, 407);
            this.txt_idproduit.Multiline = true;
            this.txt_idproduit.Name = "txt_idproduit";
            this.txt_idproduit.PlaceholderText = "idproduit";
            this.txt_idproduit.Size = new System.Drawing.Size(153, 27);
            this.txt_idproduit.TabIndex = 54;
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_total.Location = new System.Drawing.Point(55, 476);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(26, 29);
            this.txt_total.TabIndex = 55;
            this.txt_total.Text = "0";
            // 
            // frm_gererCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_idproduit);
            this.Controls.Add(this.nb_quantite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGV_commande);
            this.Controls.Add(this.btn_qteCommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_produit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txt_idClient);
            this.Controls.Add(this.txt_idCommande);
            this.Controls.Add(this.DGV_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_gererCommande";
            this.Text = "gererCommande";
            this.Load += new System.EventHandler(this.gererCommande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_produit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_commande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_quantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Label exit;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView DGV_client;
        private TextBox txt_idCommande;
        private TextBox txt_idClient;
        private DataGridView DGV_produit;
        private Label label5;
        private Button btn_qteCommande;
        private DataGridView DGV_commande;
        private Panel panel2;
        private Label label6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn IdP;
        private DataGridViewTextBoxColumn NomP;
        private DataGridViewTextBoxColumn prixP;
        private DataGridViewTextBoxColumn descriptionP;
        private DataGridViewTextBoxColumn CatP;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn quantite;
        private DataGridViewTextBoxColumn prixCommande;
        private DataGridViewTextBoxColumn id_client;
        private DataGridViewTextBoxColumn id_produit;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label8;
        private NumericUpDown nb_quantite;
        private TextBox txt_idproduit;
        private Label txt_total;
    }
}