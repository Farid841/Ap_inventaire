namespace Inventaire
{
    partial class frm_gererCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomCat = new System.Windows.Forms.TextBox();
            this.txt_idCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_categorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categorie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 100);
            this.panel1.TabIndex = 2;
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
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Categories";
            // 
            // txt_nomCat
            // 
            this.txt_nomCat.Location = new System.Drawing.Point(33, 193);
            this.txt_nomCat.Multiline = true;
            this.txt_nomCat.Name = "txt_nomCat";
            this.txt_nomCat.PlaceholderText = "nomCat";
            this.txt_nomCat.Size = new System.Drawing.Size(153, 27);
            this.txt_nomCat.TabIndex = 8;
            // 
            // txt_idCat
            // 
            this.txt_idCat.Location = new System.Drawing.Point(33, 150);
            this.txt_idCat.Multiline = true;
            this.txt_idCat.Name = "txt_idCat";
            this.txt_idCat.PlaceholderText = "idCat";
            this.txt_idCat.Size = new System.Drawing.Size(153, 27);
            this.txt_idCat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(430, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Liste des categories";
            // 
            // DGV_categorie
            // 
            this.DGV_categorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_categorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_categorie.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_categorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_categorie.Location = new System.Drawing.Point(252, 150);
            this.DGV_categorie.Name = "DGV_categorie";
            this.DGV_categorie.RowTemplate.Height = 25;
            this.DGV_categorie.Size = new System.Drawing.Size(539, 376);
            this.DGV_categorie.TabIndex = 13;
            this.DGV_categorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_categorie_CellClick);
            this.DGV_categorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_categorie_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM";
            this.Column2.Name = "Column2";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Gray;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Location = new System.Drawing.Point(54, 330);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(78, 30);
            this.btn_home.TabIndex = 20;
            this.btn_home.Text = "Accueil";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_supprimer.Location = new System.Drawing.Point(33, 278);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(78, 30);
            this.btn_supprimer.TabIndex = 19;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modifier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_modifier.Location = new System.Drawing.Point(117, 278);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(69, 30);
            this.btn_modifier.TabIndex = 18;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ajout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_ajout.Location = new System.Drawing.Point(33, 242);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(153, 30);
            this.btn_ajout.TabIndex = 17;
            this.btn_ajout.Text = "Ajout";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(0, 618);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 15);
            this.panel4.TabIndex = 22;
            // 
            // frm_gererCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 634);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_categorie);
            this.Controls.Add(this.txt_nomCat);
            this.Controls.Add(this.txt_idCat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_gererCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gererCategories";
            this.Load += new System.EventHandler(this.frm_gererCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_categorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label1;
        private TextBox txt_nomCat;
        private TextBox txt_idCat;
        private Label label3;
        private DataGridView DGV_categorie;
        private Button btn_home;
        private Button btn_supprimer;
        private Button btn_modifier;
        private Button btn_ajout;
        private Panel panel4;
        private Label label11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}