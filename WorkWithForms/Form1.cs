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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            var result=form2.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                form2.Close();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //From parent to child
            //1.1 Send Data by Constructor
            //Form2 form2 = new Form2(textBox1.Text);
            //form2.ShowDialog();

            //1.2 Send data by property
            //Form2 form2 = new Form2();
            //form2.MyText = textBox1.Text;
            //form2.ShowDialog();


            //1.3 Send Data by ShowDialog override
            //Form2 form2 = new Form2();

            //User user = new User
            //{
            //    Username = usernameTxtb.Text,
            //    Password = passwordTxtb.Text
            //};

            //form2.ShowDialog(user);






            //From Child to parent
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                button1.Text = form2.MyText;
            }



        }
    }
   public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
