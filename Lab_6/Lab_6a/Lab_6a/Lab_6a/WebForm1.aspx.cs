using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_6a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        XXXServiceReference.XXXServiceSoapClient client;
        int x, y;

        protected void Page_Load(object sender, EventArgs e)
        {
            client = new XXXServiceReference.XXXServiceSoapClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = client.Add(x, y).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = client.Sub(x, y).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(TextBox1.Text);
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = client.Mul(x, y).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox4.Text);
            client.SetA(a);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox4.Text = client.GetA().ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            client.IncreaseСounter();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox5.Text = client.GetСounterValue().ToString();
        }
    }
}