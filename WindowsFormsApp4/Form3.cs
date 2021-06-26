using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    [Serializable]

    public partial class Form3 : Form
    {
        private Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 f2):this()
        {
            this.f2 = f2;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cin = this.txt_cin.Text.ToUpper();
                string nom = this.txt_nom.Text;
                string prenom = this.txt_prenom.Text;
                DateTime dateNaissance = this.dateTimePicker1.Value;
                int poid = int.Parse(this.txt_poid.Text);
                int longueur = int.Parse(this.txt_longeur.Text);
                string adresse = this.txt_adresse.Text;
                string tel = this.txt_tel.Text;
                this.f2.Dict.Add(cin, new Patient(cin, nom, prenom, dateNaissance, poid, longueur, adresse, tel));
                this.f2.chager_list();
                this.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
