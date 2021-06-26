using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    [Serializable]
    public partial class LoginForm : Form
    {
        
        private Dictionary<string, string> login = new Dictionary<string, string>();

        public Dictionary<string, string> Login { get => login; set => login = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_password.TextLength > 0) this.btn_showpass.Visible = true;
            else this.btn_showpass.Visible = false;
        }

        public void btn_showpass_MouseDown(object sender, MouseEventArgs e)
        {
            this.txt_password.UseSystemPasswordChar = false;
        }

        public void btn_showpass_MouseUp(object sender, MouseEventArgs e)
        {
            this.txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = this.txt_email.Text;
                if (!email.Contains("@") || email.Contains(" ")) throw new Exception("Email invalide");
                if (!this.login.ContainsKey(email)) throw new Exception("Email introvable");
                if (txt_password.Text != login[email]) throw new Exception("Password incorrect");
                string username = email.Substring(0, email.IndexOf('@'));
                Form1 f1 = new Form1(username);
                f1.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(this);
            f7.ShowDialog();
            btn_login.Enabled = true;
        }

        public void ouvrir()
        {
            FileStream fs = new FileStream("login.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            this.login = (Dictionary<string, string>)bf.Deserialize(fs);
            fs.Close();
        }
        public void enregistrer()
        {
            FileStream fs = new FileStream("login.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this.login);
            fs.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("login.bin")) ouvrir(); else
            {
                btn_login.Enabled = false;
            }
        }
    }
    public class NoFocusCueButton : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
