namespace Inventaire
{
    partial class HomeForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_produit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Utilisateurs = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_categories = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_Client = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_Commandes = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Utilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Commandes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 100);
            this.panel1.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(190, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "SYSTEME DE GESTION D\'INVENTAIRE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(-37, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 18);
            this.panel2.TabIndex = 29;
            // 
            // pictureBox_produit
            // 
            this.pictureBox_produit.Location = new System.Drawing.Point(53, 147);
            this.pictureBox_produit.Name = "pictureBox_produit";
            this.pictureBox_produit.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_produit.TabIndex = 30;
            this.pictureBox_produit.TabStop = false;
            this.pictureBox_produit.Click += new System.EventHandler(this.pictureBox_produit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Produits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(582, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Utilisateurs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox_Utilisateurs
            // 
            this.pictureBox_Utilisateurs.Location = new System.Drawing.Point(574, 147);
            this.pictureBox_Utilisateurs.Name = "pictureBox_Utilisateurs";
            this.pictureBox_Utilisateurs.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_Utilisateurs.TabIndex = 32;
            this.pictureBox_Utilisateurs.TabStop = false;
            this.pictureBox_Utilisateurs.Click += new System.EventHandler(this.pictureBox_Utilisateurs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(327, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Catégories";
            // 
            // pictureBox_categories
            // 
            this.pictureBox_categories.Location = new System.Drawing.Point(315, 233);
            this.pictureBox_categories.Name = "pictureBox_categories";
            this.pictureBox_categories.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_categories.TabIndex = 34;
            this.pictureBox_categories.TabStop = false;
            this.pictureBox_categories.Click += new System.EventHandler(this.pictureBox_categories_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Clients";
            // 
            // pictureBox_Client
            // 
            this.pictureBox_Client.Location = new System.Drawing.Point(53, 331);
            this.pictureBox_Client.Name = "pictureBox_Client";
            this.pictureBox_Client.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_Client.TabIndex = 36;
            this.pictureBox_Client.TabStop = false;
            this.pictureBox_Client.Click += new System.EventHandler(this.pictureBox_Client_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(584, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Commandes";
            // 
            // pictureBox_Commandes
            // 
            this.pictureBox_Commandes.Location = new System.Drawing.Point(574, 331);
            this.pictureBox_Commandes.Name = "pictureBox_Commandes";
            this.pictureBox_Commandes.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_Commandes.TabIndex = 38;
            this.pictureBox_Commandes.TabStop = false;
            this.pictureBox_Commandes.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(792, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(294, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 74);
            this.button1.TabIndex = 40;
            this.button1.Text = "DECONNEXION";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_Commandes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_categories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_Utilisateurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_produit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_produit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Utilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Commandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Label exit;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox_produit;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox_Utilisateurs;
        private Label label4;
        private PictureBox pictureBox_categories;
        private Label label5;
        private PictureBox pictureBox_Client;
        private Label label6;
        private PictureBox pictureBox_Commandes;
        private Label label7;
        private Button button1;
    }
}