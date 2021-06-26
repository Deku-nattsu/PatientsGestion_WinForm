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

namespace WindowsFormsApp4
{
    [Serializable]
    public partial class Form6 : Form
    {
        private Dictionary<string, Patient> p_dict = new Dictionary<string, Patient>();

        Form5 f5;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Form5 f5):this()
        {
            this.f5 = f5;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            foreach(Patient p in f2.Dict.Values)
            {
                if (!f5.Dict.ContainsKey(p.Cin)) p_dict.Add(p.Cin, p);
            }
            chager_list();
            this.comboBox1.Items.Add("Consultation");
            this.comboBox1.Items.Add("Contrôle");
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cin = this.p_grid.CurrentRow.Cells[0].Value.ToString();
                Patient p = p_dict[cin];
                TimeSpan heure = this.dateTimePicker2.Value.TimeOfDay;
                RendezVous RV = new RendezVous(p, this.dateTimePicker1.Value, heure, this.comboBox1.SelectedIndex);
                foreach (RendezVous rv in f5.Dict.Values)
                {
                    if (rv.Heure == heure) throw new Exception("l'heur " + heure.ToString(@"hh\:mm") + " est déjà détenue par un autre patient");
                }
                f5.Dict.Add(p.Cin, RV);
                f5.chager_list();
                this.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        private void filrer()
        {

        }
        public void chager_list()
        {
            p_grid.Rows.Clear();
            if (p_dict.Count > 0)
            {
                foreach (Patient p in p_dict.Values)
                {
                   p_grid.Rows.Add(p.Cin, p.Nom + " " + p.Prenom, p.DateNaissance.ToString("MM/dd/yyyy"), p.Poid, p.Longueur, p.Adresse, p.Tel);
                }
            }
        }
    }
}
