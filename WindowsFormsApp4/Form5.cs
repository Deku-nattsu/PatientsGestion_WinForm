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
using System.Text.RegularExpressions;

namespace WindowsFormsApp4
{
    [Serializable]
    public partial class Form5 : Form
    {
        private Dictionary<string, RendezVous> dict;
        private string fichier;
        public Dictionary<string, RendezVous> Dict { get => dict; set => dict = value; }

        public Form5()
        {
            InitializeComponent();
            this.fichier = Form1.login + "_RV.bin";
            this.dict = new Dictionary<string, RendezVous>();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            charger_cmb();
            chager_list();
        }
        private void charger_cmb()
        {
            this.comboBox1.Items.Add("CIN");
            this.comboBox1.Items.Add("Nom Prenom");
            this.comboBox1.Items.Add("Date de rendez vous");
            this.comboBox1.Items.Add("Heure");
            this.comboBox1.Items.Add("Type de rendez vous");
            this.comboBox1.SelectedIndex = 0;
        }
        public void chager_list()
        {
            this.rendezvous_grid.Rows.Clear();
            if (File.Exists(fichier) && Dict.Count ==0) ouvrir();
            if (Dict.Count > 0)
            {
                foreach(RendezVous RV in Dict.Values)
                {
                    fill_rows(RV);
                }
            }
        }
        public void ouvrir()
        {
            FileStream fs = new FileStream(fichier, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            this.Dict = (Dictionary<string, RendezVous>)bf.Deserialize(fs);
            fs.Close();
        }
        public void enregistrer()
        {
            FileStream fs = new FileStream(fichier, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.Dict);
            fs.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            enregistrer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2();
                if (f2.Dict.Count == 0) throw new Exception("la liste des patients est vide");
                Form6 f6 = new Form6(this);
                f6.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void patient_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (this.rendezvous_grid.RowCount != 0)
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
            int indice = this.rendezvous_grid.CurrentRow.Index;
            string cin = rendezvous_grid.Rows[indice].Cells[0].Value.ToString();
            Dict.Remove(cin);
            rendezvous_grid.Rows.Remove(rendezvous_grid.CurrentRow);
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
                if(this.rendezvous_grid.CurrentCell.ColumnIndex > 1)
                {
                    Form4 f4 = new Form4(this.rendezvous_grid.CurrentCell.Value.ToString());
                    f4.ShowDialog();
                    if (f4.ok)
                    {
                        string valeur = f4.Value;
                        int indice = this.rendezvous_grid.CurrentRow.Index;
                        string cin = rendezvous_grid.Rows[indice].Cells[0].Value.ToString();
                        switch (this.rendezvous_grid.CurrentCell.ColumnIndex)
                        {
                            case 2:
                                Dict[cin].Date = DateTime.Parse(valeur);
                                break;
                            case 3:
                                Regex r = new Regex(@"\d[-0-9]:\d[-0-9]");
                                if (!r.IsMatch(valeur)) throw new Exception("Format d'heur incorrect");
                                Dict[cin].Heure = TimeSpan.Parse(valeur);
                                break;
                        }
                        chager_list();
                        f4.Dispose();
                    }

                }

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
                this.rendezvous_grid.Rows.Clear();
                string valeur = this.txt_recherche.Text;
                List<RendezVous> lst = rechercher(valeur);
                if (lst.Count == 0) throw new Exception("RendezVous introuvable");
                foreach (RendezVous p in lst) fill_rows(p);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK);
                chager_list();
            }

        }

        private List<RendezVous> rechercher(string valeur)
        {
            List<RendezVous> lst = new List<RendezVous>();
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    if (this.dict.ContainsKey(valeur)) lst.Add(dict[valeur]);
                    break;
                case 1:
                    string[] x = valeur.Split(' ');
                    foreach (RendezVous RV in dict.Values)
                    {
                        if (RV.Nom.Contains(x[0])) lst.Add(RV);
                        if (x.Length > 1)
                        {
                            if (RV.Prenom.Contains(x[1])) lst.Add(RV);
                        }
                    }
                    break;
                case 2:
                    foreach(RendezVous RV in dict.Values)
                    {
                        if (RV.Date == DateTime.Parse(valeur)) lst.Add(RV);
                    }
                    break;
                case 3:
                    foreach (RendezVous RV in dict.Values)
                    {
                        if (RV.Heure.ToString(@"hh\:mm") == valeur) lst.Add(RV);
                    }
                    break;
                case 4:
                    foreach (RendezVous RV in dict.Values)
                    {
                        if (RV.Type == valeur) lst.Add(RV);
                    }
                    break;

            }
            return lst;
        }

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            chager_list();
        }
        private void fill_rows(RendezVous RV)
        {
            this.rendezvous_grid.Rows.Add(RV.CIN, RV.Nom + " " + RV.Prenom,RV.Date.ToString("dd/MM/yyyy"),RV.Heure.ToString(@"hh\:mm"), RV.Type);
        }

        private void importerDepuisExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.Title = "Improter depuis csv";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (this.rendezvous_grid.RowCount > 0)
            {
                DialogResult msg = MessageBox.Show("Replace existing content??", "Warning", MessageBoxButtons.YesNo);
                if (msg == DialogResult.No)
                {
                    return;
                }
            }
            CSV csv = new CSV(this.rendezvous_grid, openFileDialog1.FileName);
            csv.Load();
            this.Dict.Clear();
            foreach (DataGridViewRow row in this.rendezvous_grid.Rows)
            {
                string cin = row.Cells[0].Value.ToString();
                DateTime daterendezvous = DateTime.Parse(row.Cells[2].Value.ToString());
                TimeSpan heure = TimeSpan.Parse(row.Cells[3].Value.ToString());
                int type = (row.Cells[4].Value.ToString() == "Consultation") ? 0 : 1;
                Form2 f2 = new Form2();
                if (f2.Dict.ContainsKey(cin))
                {
                    dict.Add(cin, new RendezVous(f2.Dict[cin], daterendezvous, heure, type));
                }
            }
        }

        private void exporterVersExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.Title = "Exporter vers csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            CSV csv = new CSV(this.rendezvous_grid, saveFileDialog1.FileName);
            csv.Save();
        }

        private void aProposNosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no", "A propos nos");

        }
    }
}
