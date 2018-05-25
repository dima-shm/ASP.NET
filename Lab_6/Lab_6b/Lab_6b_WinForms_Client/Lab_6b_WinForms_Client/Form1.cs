using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6b_WinForms_Client
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;

        public Form1()
        {
            InitializeComponent();

            client = new ServiceReference1.Service1Client();
            client.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Add(x, y).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Sub(x, y).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = textBox4.Text;
            string str2 = textBox5.Text;
            textBox6.Text = client.Concatination(str1, str2);
        }
    }
}
