using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithForms
{
    public partial class Form2 : Form
    {
        public string MyText { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        public DialogResult ShowDialog(User user)
        {
            label1.Text = $"{user.Username}  -  {user.Password}";
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MyText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MyText = textBox1.Text;
        }
    }
}
