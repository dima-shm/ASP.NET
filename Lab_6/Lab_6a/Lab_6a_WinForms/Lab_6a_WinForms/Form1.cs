using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6a_WinForms
{
    public partial class Form1 : Form
    {
        XXXServiceReference.XXXServiceSoapClient client;
        int x, y;

        public Form1()
        {
            InitializeComponent();
            client = new XXXServiceReference.XXXServiceSoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Add(x, y).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Sub(x, y).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = client.Mul(x, y).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.IncreaseСounter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = client.GetСounterValue().ToString();
        }
    }
}
