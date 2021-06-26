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
    public partial class Form7 : Form
    {
        LoginForm lg;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(LoginForm lg) : this()
        {
            this.lg = lg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_password.Text)) throw new Exception("Required fields are empty");
                if (txt_password.Text != txt_password1.Text) throw new Exception("Password isn't matched");
                lg.Login.Add(txt_email.Text, txt_password.Text);
                lg.enregistrer();
                this.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_showpass_MouseDown(object sender, MouseEventArgs e)
        {
            this.txt_password.UseSystemPasswordChar = false;
        }

        private void btn_showpass1_MouseUp(object sender, MouseEventArgs e)
        {
            this.txt_password1.UseSystemPasswordChar = true;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_password.TextLength > 0) this.btn_showpass.Visible = true;
            else this.btn_showpass.Visible = false;
        }

        private void txt_password1_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_password1.TextLength > 0) this.btn_showpass1.Visible = true;
            else this.btn_showpass1.Visible = false;
        }

        private void btn_showpass1_MouseDown(object sender, MouseEventArgs e)
        {
            this.txt_password1.UseSystemPasswordChar = false;
        }

        private void btn_showpass_MouseUp(object sender, MouseEventArgs e)
        {
            this.txt_password.UseSystemPasswordChar = true;

        }
    }
}
