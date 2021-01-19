using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace userpass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            label2.Text = Convert.ToString(finalString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string captcha = Convert.ToString(label2.Text);
            string typedc = Convert.ToString(textBox1.Text);

            if(captcha == typedc)
            {
                MessageBox.Show("Matched! contacting admin to replace password");
                this.Close();

            }
            else
            {
                MessageBox.Show("please check your captcha value");
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                label2.Text = Convert.ToString(finalString);
                textBox1.Text = String.Empty;
            }
        }
    }
}
