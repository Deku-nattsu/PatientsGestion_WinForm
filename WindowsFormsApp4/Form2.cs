using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApp4
{
    [Serializable]
    public partial class Form2 : Form
    {
        private List<Patient> lst = new List<Patient>();
        private Dictionary<string, Patient> dict = new Dictionary<string, Patient>();
        private string fichier;

        internal List<Patient> Lst { get => lst; set => lst = value; }
        public Dictionary<string, Patient> Dict { get => dict; set => dict = value; }
        public Form2()
        {
            InitializeComponent();
            this.fichier = Form1.login + "_P.bin";
            if (File.Exists(fichier) && Dict.Count == 0) ouvrir();
            //this.dict = new Dictionary<string, Patient>();
            //if (File.Exists(fichier) && dict.Count == 0) ouvrir();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            charger_cmb();
            chager_list();
        }
        private void charger_cmb()
        {
            this.comboBox1.Items.Add("CIN");
            this.comboBox1.Items.Add("Nom Prenom");
            this.comboBox1.Items.Add("Date de naissance");
            this.comboBox1.Items.Add("Poid");
            this.comboBox1.Items.Add("Longeur");
            this.comboBox1.Items.Add("Adresse");
            this.comboBox1.Items.Add("Téléphone");
            this.comboBox1.SelectedIndex = 0;
        }
        public void chager_list()
        {
            this.patient_grid.Rows.Clear();
            if (Dict.Count > 0)
            {
                foreach(Patient p in Dict.Values)
                {
                    fill_rows(p);
                }
            }
        }


        public void ouvrir()
        {
            FileStream fs = new FileStream(fichier, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            this.Dict = (Dictionary<string, Patient>)bf.Deserialize(fs);
            fs.Close();
        }
        public void enregistrer()
        {
            FileStream fs = new FileStream(fichier, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.Dict);
            fs.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            enregistrer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }

        private void patient_grid_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.patient_grid.CurrentCell.RowIndex.ToString(),"content",MessageBoxButtons.OK);
            //this.patient_grid.CurrentCell.Value
            if (this.patient_grid.RowCount != 0)
            {
                this.btn_modifier.Enabled = true;
                this.btn_sup.Enabled = true;
            }
            else
            {
                this.btn_modifier.Enabled = false;
                this.btn_sup.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = this.patient_grid.CurrentRow.Index;
            string cin = patient_grid.Rows[indice].Cells[0].Value.ToString();
            Dict.Remove(cin);
            patient_grid.Rows.Remove(patient_grid.CurrentRow);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            changeCellContent();
        }

        private void patient_grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            changeCellContent();
        }
        private void changeCellContent()
        {
            try
            {
                Form4 f4 = new Form4(this.patient_grid.CurrentCell.Value.ToString());
                f4.ShowDialog();
                string valeur = f4.Value;
                int indice = this.patient_grid.CurrentRow.Index;
                string cin = patient_grid.Rows[indice].Cells[0].Value.ToString();
                switch (this.patient_grid.CurrentCell.ColumnIndex)
                {
                    case 0:
                        dict[cin].Cin = valeur;
                        Dict.Add(valeur.ToUpper(), dict[cin]);
                        Dict.Remove(cin);
                        break;
                    case 1:
                        string[] x = valeur.Split(' ');
                        Dict[cin].Nom = x[0];
                        Dict[cin].Prenom = x[1];
                        break;
                    case 2:
                        Dict[cin].DateNaissance = DateTime.Parse(valeur);
                        break;
                    case 3:
                        Dict[cin].Poid = int.Parse(valeur);
                        break;
                    case 4:
                        Dict[cin].Longueur = int.Parse(valeur);
                        break;
                    case 5:
                        Dict[cin].Adresse = valeur;
                        break;
                    case 6:
                        Dict[cin].Tel = valeur;
                        break;
                }
                chager_list();
                //this.patient_grid.CurrentCell.Value = valeur;
                f4.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            try
            {
                this.patient_grid.Rows.Clear();
                string valeur = this.txt_recherche.Text;
                if (string.IsNullOrEmpty(valeur)) throw new Exception("Barre de recherche vide");
                List<Patient> lst = rechercher(valeur);
                if (lst.Count == 0) throw new Exception("patient introuvable");
                foreach (Patient p in lst) fill_rows(p);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
                chager_list();
            }

        }

        private List<Patient> rechercher(string valeur)
        {
            List<Patient> lst = new List<Patient>();
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    if (this.dict.ContainsKey(valeur)) lst.Add(dict[valeur]);
                    break;
                case 1:
                    string[] x = valeur.Split(' ');
                    foreach (Patient p in dict.Values)
                    {
                        if (p.Nom.Contains(x[0])) lst.Add(p);
                        if (x.Length > 1)
                        {
                            if (p.Prenom.Contains(x[1])) lst.Add(p);
                        }
                    }
                    break;
                case 2:
                    foreach (Patient p in dict.Values)
                    {
                        if (p.DateNaissance == DateTime.Parse(valeur)) lst.Add(p);
                    }
                    break;
                case 3:
                    foreach (Patient p in dict.Values)
                    {
                        if (p.Poid == int.Parse(valeur)) lst.Add(p);
                    }
                    break;
                case 5:
                    foreach (Patient p in dict.Values)
                    {
                        if (p.Longueur == int.Parse(valeur)) lst.Add(p);
                    }
                    break;
                case 6:
                    foreach (Patient p in dict.Values)
                    {
                        if (p.Tel.Contains(valeur)) lst.Add(p);
                    }
                    break;
            }
            return lst;
        }

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            chager_list();
        }
        private void fill_rows(Patient p)
        {
            this.patient_grid.Rows.Add(p.Cin, p.Nom + " " + p.Prenom, p.DateNaissance.ToString("dd/MM/yyyy"), p.Poid, p.Longueur, p.Adresse, p.Tel);
        }

        private void importerDepuisExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog1.Title = "Improter depuis csv";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (this.patient_grid.RowCount > 0)
                {
                    DialogResult msg = MessageBox.Show("Replace existing content??", "Warning", MessageBoxButtons.YesNo);
                    if (msg == DialogResult.No)
                    {
                        return;
                    }
                }
                CSV csv = new CSV(this.patient_grid, openFileDialog1.FileName);
                csv.Load();
                this.Dict.Clear();
                foreach (DataGridViewRow row in this.patient_grid.Rows)
                {
                    string cin = row.Cells[0].Value.ToString();
                    string[] field = row.Cells[1].Value.ToString().Split(' ');
                    string nom = field[0];
                    string prenom = field[1];
                    DateTime dateNaissance = DateTime.Parse(row.Cells[2].Value.ToString());
                    int poid = int.Parse(row.Cells[3].Value.ToString());
                    int longeur = int.Parse(row.Cells[4].Value.ToString());
                    string adresse = row.Cells[5].Value.ToString();
                    string tel = row.Cells[6].Value.ToString();
                    dict.Add(cin, new Patient(cin, nom, prenom, dateNaissance, poid, longeur, adresse, tel));
                }
            }catch(Exception)
            {

            }
        }

        private void exporterVersExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog1.Title = "Exporter vers csv";
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                CSV csv = new CSV(this.patient_grid, saveFileDialog1.FileName);
                csv.Save();
            }
            catch (Exception)
            {

            }

        }

        private void aProposNosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("boi you going to jail", "A propos nos");
        }
    }
}
