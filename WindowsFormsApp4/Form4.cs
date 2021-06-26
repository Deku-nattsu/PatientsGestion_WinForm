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

    public partial class Form4 : Form
    {
        private string value;
        public bool ok = false;
        public string Value { get => value; set => this.value = value; }

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string value):this()
        {
            this.Value = value;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            this.value = this.textBox1.Text;
            this.Close();
        }
    }
}
