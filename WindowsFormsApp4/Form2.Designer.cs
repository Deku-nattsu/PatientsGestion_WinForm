
namespace WindowsFormsApp4
{
    partial class Form2
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
            this.patient_grid = new System.Windows.Forms.DataGridView();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_recharge = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerDepuisExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterVersExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposNosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patient_grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_grid
            // 
            this.patient_grid.AllowUserToAddRows = false;
            this.patient_grid.AllowUserToDeleteRows = false;
            this.patient_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patient_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cin,
            this.nom_prenom,
            this.datenaissance,
            this.poid,
            this.longueur,
            this.adresse,
            this.tel});
            this.patient_grid.Location = new System.Drawing.Point(12, 179);
            this.patient_grid.MultiSelect = false;
            this.patient_grid.Name = "patient_grid";
            this.patient_grid.ReadOnly = true;
            this.patient_grid.Size = new System.Drawing.Size(776, 297);
            this.patient_grid.TabIndex = 0;
            this.patient_grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patient_grid_CellMouseDoubleClick);
            this.patient_grid.SelectionChanged += new System.EventHandler(this.patient_grid_SelectionChanged);
            // 
            // cin
            // 
            this.cin.HeaderText = "CIN";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // nom_prenom
            // 
            this.nom_prenom.HeaderText = "Nom Prenom";
            this.nom_prenom.Name = "nom_prenom";
            this.nom_prenom.ReadOnly = true;
            // 
            // datenaissance
            // 
            this.datenaissance.HeaderText = "Date Naissance";
            this.datenaissance.Name = "datenaissance";
            this.datenaissance.ReadOnly = true;
            // 
            // poid
            // 
            this.poid.HeaderText = "Poid";
            this.poid.Name = "poid";
            this.poid.ReadOnly = true;
            // 
            // longueur
            // 
            this.longueur.HeaderText = "Longueur";
            this.longueur.Name = "longueur";
            this.longueur.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Téléphone";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // txt_recherche
            // 
            this.txt_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recherche.Location = new System.Drawing.Point(12, 41);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(287, 27);
            this.txt_recherche.TabIndex = 1;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(632, 40);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 30);
            this.btn_recherche.TabIndex = 2;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechercher par:";
            // 
            // btn_sup
            // 
            this.btn_sup.Enabled = false;
            this.btn_sup.Location = new System.Drawing.Point(632, 134);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(75, 23);
            this.btn_sup.TabIndex = 6;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Enabled = false;
            this.btn_modifier.Location = new System.Drawing.Point(632, 105);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 7;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_recharge
            // 
            this.btn_recharge.Location = new System.Drawing.Point(632, 76);
            this.btn_recharge.Name = "btn_recharge";
            this.btn_recharge.Size = new System.Drawing.Size(75, 23);
            this.btn_recharge.TabIndex = 8;
            this.btn_recharge.Text = "Recharger";
            this.btn_recharge.UseVisualStyleBackColor = true;
            this.btn_recharge.Click += new System.EventHandler(this.btn_recharge_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aProposNosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerDepuisExcelToolStripMenuItem,
            this.exporterVersExcelToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // importerDepuisExcelToolStripMenuItem
            // 
            this.importerDepuisExcelToolStripMenuItem.Name = "importerDepuisExcelToolStripMenuItem";
            this.importerDepuisExcelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importerDepuisExcelToolStripMenuItem.Text = "Importer depuis excel";
            this.importerDepuisExcelToolStripMenuItem.Click += new System.EventHandler(this.importerDepuisExcelToolStripMenuItem_Click);
            // 
            // exporterVersExcelToolStripMenuItem
            // 
            this.exporterVersExcelToolStripMenuItem.Name = "exporterVersExcelToolStripMenuItem";
            this.exporterVersExcelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exporterVersExcelToolStripMenuItem.Text = "Exporter vers excel";
            this.exporterVersExcelToolStripMenuItem.Click += new System.EventHandler(this.exporterVersExcelToolStripMenuItem_Click);
            // 
            // aProposNosToolStripMenuItem
            // 
            this.aProposNosToolStripMenuItem.Name = "aProposNosToolStripMenuItem";
            this.aProposNosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.aProposNosToolStripMenuItem.Text = "A propos nos";
            this.aProposNosToolStripMenuItem.Click += new System.EventHandler(this.aProposNosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Asset_34;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(713, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 117);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btn_recharge);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.txt_recherche);
            this.Controls.Add(this.patient_grid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des patients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patient_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn poid;
        private System.Windows.Forms.DataGridViewTextBoxColumn longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_recharge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerDepuisExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterVersExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposNosToolStripMenuItem;
    }
}