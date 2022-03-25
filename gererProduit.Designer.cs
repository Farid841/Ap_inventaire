namespace Inventaire
{
    partial class gererProduit
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
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_desProduit = new System.Windows.Forms.TextBox();
            this.txt_prixProduit = new System.Windows.Forms.TextBox();
            this.txt_nomProduit = new System.Windows.Forms.TextBox();
            this.txt_idProduit = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_produit = new System.Windows.Forms.DataGridView();
            this.cb_choixCategorie = new System.Windows.Forms.ComboBox();
            this.btn_rechercheCat = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Produits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(773, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 15);
            this.panel2.TabIndex = 28;
            // 
            // txt_desProduit
            // 
            this.txt_desProduit.Location = new System.Drawing.Point(12, 267);
            this.txt_desProduit.Multiline = true;
            this.txt_desProduit.Name = "txt_desProduit";
            this.txt_desProduit.PlaceholderText = "Description";
            this.txt_desProduit.Size = new System.Drawing.Size(153, 27);
            this.txt_desProduit.TabIndex = 27;
            // 
            // txt_prixProduit
            // 
            this.txt_prixProduit.Location = new System.Drawing.Point(12, 224);
            this.txt_prixProduit.Multiline = true;
            this.txt_prixProduit.Name = "txt_prixProduit";
            this.txt_prixProduit.PlaceholderText = "Prix Produit";
            this.txt_prixProduit.Size = new System.Drawing.Size(153, 27);
            this.txt_prixProduit.TabIndex = 26;
            // 
            // txt_nomProduit
            // 
            this.txt_nomProduit.Location = new System.Drawing.Point(12, 182);
            this.txt_nomProduit.Multiline = true;
            this.txt_nomProduit.Name = "txt_nomProduit";
            this.txt_nomProduit.PlaceholderText = "Nom Produit";
            this.txt_nomProduit.Size = new System.Drawing.Size(153, 27);
            this.txt_nomProduit.TabIndex = 25;
            // 
            // txt_idProduit
            // 
            this.txt_idProduit.Location = new System.Drawing.Point(12, 131);
            this.txt_idProduit.Multiline = true;
            this.txt_idProduit.Name = "txt_idProduit";
            this.txt_idProduit.PlaceholderText = "idProduit";
            this.txt_idProduit.Size = new System.Drawing.Size(153, 27);
            this.txt_idProduit.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 23);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Categories Produits";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Gray;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Location = new System.Drawing.Point(50, 414);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(78, 30);
            this.btn_home.TabIndex = 33;
            this.btn_home.Text = "Accueil";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_supprimer.Location = new System.Drawing.Point(12, 378);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(78, 30);
            this.btn_supprimer.TabIndex = 32;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modifier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_modifier.Location = new System.Drawing.Point(96, 378);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(69, 30);
            this.btn_modifier.TabIndex = 31;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ajout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_ajout.Location = new System.Drawing.Point(12, 342);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(153, 30);
            this.btn_ajout.TabIndex = 30;
            this.btn_ajout.Text = "Ajout";
            this.btn_ajout.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(362, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "Liste des Produits";
            // 
            // DGV_produit
            // 
            this.DGV_produit.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_produit.Location = new System.Drawing.Point(219, 201);
            this.DGV_produit.Name = "DGV_produit";
            this.DGV_produit.RowTemplate.Height = 25;
            this.DGV_produit.Size = new System.Drawing.Size(539, 423);
            this.DGV_produit.TabIndex = 34;
            // 
            // cb_choixCategorie
            // 
            this.cb_choixCategorie.FormattingEnabled = true;
            this.cb_choixCategorie.Location = new System.Drawing.Point(316, 172);
            this.cb_choixCategorie.Name = "cb_choixCategorie";
            this.cb_choixCategorie.Size = new System.Drawing.Size(153, 23);
            this.cb_choixCategorie.TabIndex = 36;
            this.cb_choixCategorie.Text = "Choisir Categorie";
            // 
            // btn_rechercheCat
            // 
            this.btn_rechercheCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_rechercheCat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_rechercheCat.Location = new System.Drawing.Point(468, 170);
            this.btn_rechercheCat.Name = "btn_rechercheCat";
            this.btn_rechercheCat.Size = new System.Drawing.Size(78, 25);
            this.btn_rechercheCat.TabIndex = 37;
            this.btn_rechercheCat.Text = "Recherche";
            this.btn_rechercheCat.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_refresh.Location = new System.Drawing.Point(548, 170);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(78, 25);
            this.btn_refresh.TabIndex = 38;
            this.btn_refresh.Text = "Actualiser";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gererProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_rechercheCat);
            this.Controls.Add(this.cb_choixCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_produit);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_desProduit);
            this.Controls.Add(this.txt_prixProduit);
            this.Controls.Add(this.txt_nomProduit);
            this.Controls.Add(this.txt_idProduit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gererProduit";
            this.Text = "gererProduit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private TextBox txt_desProduit;
        private TextBox txt_prixProduit;
        private TextBox txt_nomProduit;
        private TextBox txt_idProduit;
        private ComboBox comboBox1;
        private Button btn_home;
        private Button btn_supprimer;
        private Button btn_modifier;
        private Button btn_ajout;
        private Label label4;
        private DataGridView DGV_produit;
        private ComboBox cb_choixCategorie;
        private Button btn_rechercheCat;
        private Button btn_refresh;
    }
}