namespace Inventaire
{
    partial class frm_gererclient
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
            this.txt_telClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_idClient = new System.Windows.Forms.TextBox();
            this.txt_nomClient = new System.Windows.Forms.TextBox();
            this.clm_telClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_client = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 100);
            this.panel1.TabIndex = 1;
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
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion client";
            // 
            // txt_telClient
            // 
            this.txt_telClient.Location = new System.Drawing.Point(22, 248);
            this.txt_telClient.Multiline = true;
            this.txt_telClient.Name = "txt_telClient";
            this.txt_telClient.PlaceholderText = "Telephone";
            this.txt_telClient.Size = new System.Drawing.Size(153, 27);
            this.txt_telClient.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(464, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Liste des clients";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Gray;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Location = new System.Drawing.Point(43, 386);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(78, 30);
            this.btn_home.TabIndex = 16;
            this.btn_home.Text = "Accueil";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_supprimer.Location = new System.Drawing.Point(22, 334);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(78, 30);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_modifier.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_modifier.Location = new System.Drawing.Point(106, 334);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(69, 30);
            this.btn_modifier.TabIndex = 14;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ajout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_ajout.Location = new System.Drawing.Point(22, 298);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(153, 30);
            this.btn_ajout.TabIndex = 13;
            this.btn_ajout.Text = "Ajout";
            this.btn_ajout.UseVisualStyleBackColor = false;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 15);
            this.panel2.TabIndex = 17;
            // 
            // txt_idClient
            // 
            this.txt_idClient.Location = new System.Drawing.Point(22, 160);
            this.txt_idClient.Multiline = true;
            this.txt_idClient.Name = "txt_idClient";
            this.txt_idClient.PlaceholderText = "idclient";
            this.txt_idClient.Size = new System.Drawing.Size(153, 27);
            this.txt_idClient.TabIndex = 5;
            // 
            // txt_nomClient
            // 
            this.txt_nomClient.Location = new System.Drawing.Point(22, 203);
            this.txt_nomClient.Multiline = true;
            this.txt_nomClient.Name = "txt_nomClient";
            this.txt_nomClient.PlaceholderText = "Prenom";
            this.txt_nomClient.Size = new System.Drawing.Size(153, 27);
            this.txt_nomClient.TabIndex = 6;
            // 
            // clm_telClient
            // 
            this.clm_telClient.HeaderText = "Telephone";
            this.clm_telClient.Name = "clm_telClient";
            // 
            // clm_prenomClient
            // 
            this.clm_prenomClient.HeaderText = "PRENOM";
            this.clm_prenomClient.Name = "clm_prenomClient";
            // 
            // id_client
            // 
            this.id_client.HeaderText = "ID";
            this.id_client.Name = "id_client";
            // 
            // DGV_client
            // 
            this.DGV_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_client.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.clm_prenomClient,
            this.clm_telClient});
            this.DGV_client.Location = new System.Drawing.Point(283, 160);
            this.DGV_client.Name = "DGV_client";
            this.DGV_client.RowTemplate.Height = 25;
            this.DGV_client.Size = new System.Drawing.Size(539, 376);
            this.DGV_client.TabIndex = 10;
            this.DGV_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_client_CellClick);
            this.DGV_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_client_CellContentClick);
            // 
            // frm_gererclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_client);
            this.Controls.Add(this.txt_telClient);
            this.Controls.Add(this.txt_nomClient);
            this.Controls.Add(this.txt_idClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_gererclient";
            this.Text = "gererclient";
            this.Load += new System.EventHandler(this.frm_gererclient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label1;
        private TextBox txt_telClient;
        private Label label3;
        private Button btn_home;
        private Button btn_supprimer;
        private Button btn_modifier;
        private Button btn_ajout;
        private Panel panel2;
        private TextBox txt_idClient;
        private TextBox txt_nomClient;
        private DataGridViewTextBoxColumn clm_telClient;
        private DataGridViewTextBoxColumn clm_prenomClient;
        private DataGridViewTextBoxColumn id_client;
        private DataGridView DGV_client;
    }
}