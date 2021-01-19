using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace userpass
{
    public partial class Form1 : Form
    {
        List<string> user = new List<string>();
        List<string> pass = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@".\admindetails.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                user.Add(components[0]);
                pass.Add(components[1]);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (user.Contains(textBox1.Text) && pass.Contains(textBox2.Text))
            {
                if (pass[Array.IndexOf(user.ToArray(), textBox1.Text)] == textBox2.Text)
                {
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                }

                else
                {
                    MessageBox.Show("The Username and Password is incorrect.");
                }
            }
            else
            {
                MessageBox.Show("The Username and Password is incorrect.");
            }

            if (string.IsNullOrEmpty(textBox1.Text)&& string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill in values for Email and Password");

            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in values for Email");
            }

            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill in values for Password");
            }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string atcheck = "@";
            //string periodcheck = ".";
            string correctformat = "Correct Format";
            string incorrectformat = "Wrong Format";
           


           if (Convert.ToString(textBox1.Text).Contains(atcheck))
            {
                label1.Text = correctformat;
            }

           else
            {
                label1.Text = incorrectformat;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text = "-";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string passlengthyes = "password is in character range";
            string passlengthno = "password is not in character range";
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (textBox2.Text.Length >= 8)
            {
                label2.Text = passlengthyes;
            }
            else
            {
                label2.Text = passlengthno;
            }

            if (regexItem.IsMatch(Convert.ToString(textBox2.Text)))
            {
                label2.Text = "password must contain special character";
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                label2.Text = "-";
            }

           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.ShowDialog();
        }
    }
}
