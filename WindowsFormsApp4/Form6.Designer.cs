
namespace WindowsFormsApp4
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.p_grid = new System.Windows.Forms.DataGridView();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longueur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 327);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // p_grid
            // 
            this.p_grid.AllowUserToAddRows = false;
            this.p_grid.AllowUserToDeleteRows = false;
            this.p_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.p_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cin,
            this.nom_prenom,
            this.datenaissance,
            this.poid,
            this.longueur,
            this.adresse,
            this.tel});
            this.p_grid.Location = new System.Drawing.Point(12, 12);
            this.p_grid.MultiSelect = false;
            this.p_grid.Name = "p_grid";
            this.p_grid.ReadOnly = true;
            this.p_grid.Size = new System.Drawing.Size(776, 297);
            this.p_grid.TabIndex = 4;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(400, 328);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(49, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2021, 6, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date de rendez-vous:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Heure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.p_grid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView p_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn poid;
        private System.Windows.Forms.DataGridViewTextBoxColumn longueur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}